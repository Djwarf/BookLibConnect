﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using core.audiamus.aux;
using core.audiamus.aux.propgrid;
using core.audiamus.booksdb;
using core.audiamus.connect.ex;
using R = core.audiamus.connect.ui.Properties.Resources;
using static core.audiamus.aux.Logging;
using core.audiamus.aux.win;

namespace core.audiamus.connect.ui {
  public partial class BookLibForm : Form {
    const double REL_SPLITTER_DIST_BOTTOM = 0.75;
    const double REL_SPLITTER_DIST_INNER = 0.40;

    private static double? __relSplitterDistBottom;
    private static double? __relSplitterDistInner;

    private readonly AffineSynchronizationContext _sync;
    private readonly InteractionCallbackHandler<BookLibInteract> _interactionHandler;
    private IDownloadSettings _downloadSettings;
    private bool _shownFlag;
    private bool _ignoreFlag;

    private IAudibleApi Api { get; }
    
    private IDownloadSettings DownloadSettings {
      get => _downloadSettings;
      set {
        _downloadSettings = value;
        _downloadSettings.ChangedSettings += settings_ChangedSettings;
      }
    }
    private IExportSettings ExportSettings { get; }

    private BookPGA DataSource { get; set; }

    public event BookSelectionChangedEventHandler BookDownloadSelectionChanged;
    public event ConversionUpdatedEventHandler ConversionUpdated;

    [JsonIgnore]
    public bool DownloadSelectEnabled {
      get => bookLibdgvControl1.DownloadSelectEnabled;
      set => bookLibdgvControl1.DownloadSelectEnabled = value;
    }

    public BookLibForm (IAudibleApi api, IDownloadSettings downloadSettings, IExportSettings exportSettings) {
      InitializeComponent ();
      _ignoreFlag = true;

      DownloadSelectEnabled = false;

      if (api is null || downloadSettings is null || exportSettings is null)
        return;

      Log (3, this, () => $"{api.AccountAlias}, {api.Region}");

      _sync = new ();

      _interactionHandler = new InteractionCallbackHandler<BookLibInteract> (this, bookLibMessage);

      Api = api;
      DownloadSettings = downloadSettings;
      ExportSettings = exportSettings;

      bookLibdgvControl1.Settings = downloadSettings;
      bookLibdgvControl1.BookSelectionChanged += bookLibdgvControl1_BookSelectionChanged;
      bookLibdgvControl1.BookDownloadSelectionChanged += bookLibdgvControl1_BookDownloadSelectionChanged;
      bookLibdgvControl1.ConversionUpdated += bookLibdgvControl1_ConversionUpdated;
      bookLibdgvControl1.Resync += bookLibdgvControl1_Resync;

      this.Text = $"{R.Library} for \"{Api.AccountAlias}\" and region \"{Api.Region}\"";
    }

    private async void bookLibdgvControl1_Resync (object sender, EventArgs e) {
      this.Cursor = Cursors.AppStarting;
      using var rgc = new ResourceGuard (() => Cursor = Cursors.Default);
      using var rge = new ResourceGuard (x => bookLibdgvControl1.DownloadSelectEnabled = !x);

      DialogResult result = DialogResult.None;
      bool resync = true;
      if (DownloadSettings.AutoUpdateLibrary) {
        result = MsgBox.Show (this, R.MsgFullResync, this.Text, 
          MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      } else { 
        result = MsgBox.Show (this, R.MsgFullResyncOrElse, this.Text, 
          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        resync = result == DialogResult.Yes;
      }
      if (result == DialogResult.Cancel)
        return;

      await Api.GetLibraryAsync (resync);
      await Api.DownloadCoverImagesAsync ();

      var books = await Task.Run (() => loadBooks ());
      bookLibdgvControl1.Books = books;
    }

    private string bookLibMessage (BookLibInteract arg) {
      return arg.Kind switch {
        EBookLibInteract.checkFile => R.MsgBookLibMissingFiles,
        _ => string.Empty
      };
    }

    private void settings_ChangedSettings (object sender, EventArgs e) {
      DataSource?.OnUpdatedSettings (DownloadSettings.IncludeAdultProducts);
    }

    public void UpdateDownloads (IEnumerable<Book> books) => 
      bookLibdgvControl1.UpdateDownloads (books);

    public void UpdateConversion (Conversion conversion) {
      bookLibdgvControl1.UpdateConversion (conversion);
      propertyGrid1.Refresh ();
    }

    protected async override void OnLoad (EventArgs e) {
      using var _ = new LogGuard (3, this);
      base.OnLoad (e);

      this.Cursor = Cursors.AppStarting;
      using (new ResourceGuard (() => Cursor = Cursors.Default)) {
        var books = await Task.Run (() => loadBooks ());
        bookLibdgvControl1.Books = books;
      }
    
      Action<IConversion> callback = conv => _sync.Post (bookLibdgvControl1.UpdateConversionStateFromOther, conv);

      if (_interactionHandler is null)
        return;

      var interact = 
        new InteractionCallback<InteractionMessage<BookLibInteract>, bool?> (_interactionHandler.Interact);

      await Task.Run (() =>
        Api?.CheckUpdateFilesAndState (DownloadSettings, ExportSettings, callback, interact));

      DownloadSelectEnabled = true;
    }

    protected override void OnShown (EventArgs e) {
      using var rg = new ResourceGuard (() => _ignoreFlag = false);
      base.OnShown (e);
      if (_shownFlag)
        return;
      _shownFlag = true;

      var scb = splitContainerBottom;
      var sci = splitContainerInner;

      double relSplitterDistBottom = __relSplitterDistBottom ?? REL_SPLITTER_DIST_BOTTOM; 
      double relSplitterDistInner = __relSplitterDistInner ?? REL_SPLITTER_DIST_INNER; 

      scb.SplitterDistance = (int)(relSplitterDistBottom * scb.Width);
      sci.SplitterDistance = (int)(relSplitterDistInner * scb.Width);
    }


    private IEnumerable<Book> loadBooks () {
      var books = Api?.GetBooks ();
      return books;
    }

    private void bookLibdgvControl1_BookSelectionChanged (object sender, BookEventArgs args) {
      var books = args.Books;
      Log (3, this, () => $"#books={books.Count()}");

      if (books.Count () != 1) {
        propertyGrid1.SelectedObject = null;

        textBox1.Text = null;
        
        pictureBox1.Image = null;
      } else {
        var book = books.First ();
        DataSource = new BookPGA (book, DownloadSettings);
        DataSource.OnUpdatedSettings (DownloadSettings.IncludeAdultProducts);
        propertyGrid1.SelectedObject = DataSource;


        textBox1.Text = book.PublisherSummary.FormatLineBreaks();

        if (File.Exists (book.CoverImageFile))
          pictureBox1.Image = Image.FromFile (book.CoverImageFile);
        else
          pictureBox1.Image = null;
      }

    }

    private void bookLibdgvControl1_BookDownloadSelectionChanged (object sender, BookEventArgs args) {
      Log (3, this, () => $"#books={args.Books.Count ()}");
      BookDownloadSelectionChanged?.Invoke (this, args);
    }

    private void propertyGrid1_SelectedObjectsChanged (object sender, System.EventArgs e) {
      this.propertyGrid1.MoveSplitterToLongestDisplayName (10);
    }

    private void bookLibdgvControl1_ConversionUpdated (object sender, ConversionEventArgs args) {
      ConversionUpdated?.Invoke (this, args);
    }

    private void bookLibdgvControl1_Close (object sender, EventArgs e) {
      Close ();
    }

    private void splitContainerInner_SplitterMoved (object sender, SplitterEventArgs e) {
      if (_ignoreFlag)
        return;
      var scb = splitContainerBottom;
      var sci = splitContainerInner;
      //__relSplitterDistInner = (double)sci.SplitterDistance / scb.Width;
    }

    private void splitContainerBottom_SplitterMoved (object sender, SplitterEventArgs e) {
      if (_ignoreFlag)
        return;
      var scb = splitContainerBottom;
      //__relSplitterDistInner = (double)scb.SplitterDistance / scb.Width;
    }
  }

}

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using core.audiamus.booksdb;
using core.audiamus.connect.ex;

namespace core.audiamus.connect.ui
{
    [JsonSourceGenerationOptions(
        WriteIndented = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        GenerationMode = JsonSourceGenerationMode.Metadata,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonSerializable(typeof(BookDataSource))]
    [JsonSerializable(typeof(Book))]
    [JsonSerializable(typeof(IDownloadSettings))]
    [JsonSerializable(typeof(IExportSettings))]
    [JsonSerializable(typeof(IAudibleApi))]
    [JsonSerializable(typeof(bool))]
    [JsonSerializable(typeof(object))]
    [JsonSerializable(typeof(IProfileKeyEx))]
    public partial class WindowsFormsJsonContext : JsonSerializerContext
    {
    }
} 
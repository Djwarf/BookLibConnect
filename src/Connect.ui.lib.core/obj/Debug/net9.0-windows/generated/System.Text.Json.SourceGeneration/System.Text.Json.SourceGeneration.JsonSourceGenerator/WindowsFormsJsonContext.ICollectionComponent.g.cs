﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace core.audiamus.connect.ui
{
    public partial class WindowsFormsJsonContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>>? _ICollectionComponent;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>> ICollectionComponent
        #nullable enable annotations
        {
            get => _ICollectionComponent ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>>)Options.GetTypeInfo(typeof(global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>> Create_ICollectionComponent(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateICollectionInfo<global::System.Collections.Generic.ICollection<global::core.audiamus.booksdb.Component>, global::core.audiamus.booksdb.Component>(options, info);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}

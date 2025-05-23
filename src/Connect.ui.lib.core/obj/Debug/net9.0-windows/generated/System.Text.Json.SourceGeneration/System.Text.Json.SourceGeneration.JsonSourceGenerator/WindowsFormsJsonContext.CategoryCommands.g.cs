﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace core.audiamus.connect.ui
{
    public partial class WindowsFormsJsonContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.aux.propgrid.CategoryCommands>? _CategoryCommands;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.aux.propgrid.CategoryCommands> CategoryCommands
        #nullable enable annotations
        {
            get => _CategoryCommands ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.aux.propgrid.CategoryCommands>)Options.GetTypeInfo(typeof(global::core.audiamus.aux.propgrid.CategoryCommands));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.aux.propgrid.CategoryCommands> Create_CategoryCommands(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::core.audiamus.aux.propgrid.CategoryCommands>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.aux.propgrid.CategoryCommands> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::core.audiamus.aux.propgrid.CategoryCommands>
                {
                    ObjectCreator = () => new global::core.audiamus.aux.propgrid.CategoryCommands(),
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateIListInfo<global::core.audiamus.aux.propgrid.CategoryCommands>(options, info);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}

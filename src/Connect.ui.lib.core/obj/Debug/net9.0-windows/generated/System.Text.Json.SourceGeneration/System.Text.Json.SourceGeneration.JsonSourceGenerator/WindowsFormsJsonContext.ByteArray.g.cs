﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace core.audiamus.connect.ui
{
    public partial class WindowsFormsJsonContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]>? _ByteArray;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ByteArray
        #nullable enable annotations
        {
            get => _ByteArray ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]>)Options.GetTypeInfo(typeof(byte[]));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> Create_ByteArray(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<byte[]>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> jsonTypeInfo))
            {
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<byte[]>(options, global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.ByteArrayConverter);
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}

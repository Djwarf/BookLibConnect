﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace core.audiamus.connect.ui
{
    public partial class WindowsFormsJsonContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Drawing.Imaging.ColorPalette>? _ColorPalette;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Drawing.Imaging.ColorPalette> ColorPalette
        #nullable enable annotations
        {
            get => _ColorPalette ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Drawing.Imaging.ColorPalette>)Options.GetTypeInfo(typeof(global::System.Drawing.Imaging.ColorPalette));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Drawing.Imaging.ColorPalette> Create_ColorPalette(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Drawing.Imaging.ColorPalette>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Drawing.Imaging.ColorPalette> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Drawing.Imaging.ColorPalette>
                {
                    ObjectCreator = null,
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => ColorPalettePropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = null,
                    SerializeHandler = null,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::System.Drawing.Imaging.ColorPalette>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] ColorPalettePropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[2];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<int>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Drawing.Imaging.ColorPalette),
                Converter = null,
                Getter = static obj => ((global::System.Drawing.Imaging.ColorPalette)obj).Flags,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Flags",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::System.Drawing.Imaging.ColorPalette).GetProperty("Flags", InstanceMemberBindingFlags, null, typeof(int), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<int>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Drawing.Color[]>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Drawing.Imaging.ColorPalette),
                Converter = null,
                Getter = static obj => ((global::System.Drawing.Imaging.ColorPalette)obj).Entries,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Entries",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::System.Drawing.Imaging.ColorPalette).GetProperty("Entries", InstanceMemberBindingFlags, null, typeof(global::System.Drawing.Color[]), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Drawing.Color[]>(options, info1);
            properties[1].IsGetNullable = false;

            return properties;
        }
    }
}

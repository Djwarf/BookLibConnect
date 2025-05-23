﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace core.audiamus.connect.ui
{
    public partial class WindowsFormsJsonContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.common.IBookMeta>? _IBookMeta;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.common.IBookMeta> IBookMeta
        #nullable enable annotations
        {
            get => _IBookMeta ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.common.IBookMeta>)Options.GetTypeInfo(typeof(global::core.audiamus.common.IBookMeta));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.common.IBookMeta> Create_IBookMeta(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::core.audiamus.common.IBookMeta>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::core.audiamus.common.IBookMeta> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::core.audiamus.common.IBookMeta>
                {
                    ObjectCreator = null,
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => IBookMetaPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = null,
                    SerializeHandler = null,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::core.audiamus.common.IBookMeta>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] IBookMetaPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[14];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).Asin,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Asin",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("Asin", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).Title,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Title",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("Title", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).Author,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Author",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("Author", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).MultiAuthors,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "MultiAuthors",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("MultiAuthors", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info3);

            var info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<long?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).FileSizeBytes,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "FileSizeBytes",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("FileSizeBytes", InstanceMemberBindingFlags, null, typeof(long?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<long?>(options, info4);

            var info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<int?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).RunTimeLengthSeconds,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "RunTimeLengthSeconds",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("RunTimeLengthSeconds", InstanceMemberBindingFlags, null, typeof(int?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[5] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<int?>(options, info5);

            var info6 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).Narrator,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Narrator",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("Narrator", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[6] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info6);

            var info7 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).MultiNarrators,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "MultiNarrators",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("MultiNarrators", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[7] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info7);

            var info8 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).Sku,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Sku",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("Sku", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[8] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info8);

            var info9 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).SkuLite,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "SkuLite",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("SkuLite", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[9] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info9);

            var info10 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTime?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).ReleaseDate,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "ReleaseDate",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("ReleaseDate", InstanceMemberBindingFlags, null, typeof(global::System.DateTime?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[10] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.DateTime?>(options, info10);

            var info11 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTime?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IBookMeta),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IBookMeta)obj).PurchaseDate,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "PurchaseDate",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IBookMeta).GetProperty("PurchaseDate", InstanceMemberBindingFlags, null, typeof(global::System.DateTime?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[11] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.DateTime?>(options, info11);

            var info12 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<int?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IAudioQuality),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IAudioQuality)obj).SampleRate,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "SampleRate",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IAudioQuality).GetProperty("SampleRate", InstanceMemberBindingFlags, null, typeof(int?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[12] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<int?>(options, info12);

            var info13 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<int?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = true,
                DeclaringType = typeof(global::core.audiamus.common.IAudioQuality),
                Converter = null,
                Getter = static obj => ((global::core.audiamus.common.IAudioQuality)obj).BitRate,
                Setter = null,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "BitRate",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::core.audiamus.common.IAudioQuality).GetProperty("BitRate", InstanceMemberBindingFlags, null, typeof(int?), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[13] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<int?>(options, info13);

            return properties;
        }
    }
}

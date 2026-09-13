
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsSort), TypeInfoPropertyName = "GetDocumentsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsOrder), TypeInfoPropertyName = "GetDocumentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseType), TypeInfoPropertyName = "CreateDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemType), TypeInfoPropertyName = "GetDocumentsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseDataItemUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseType), TypeInfoPropertyName = "GetDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsSort?), TypeInfoPropertyName = "NullableGetDocumentsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsOrder?), TypeInfoPropertyName = "NullableGetDocumentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseType?), TypeInfoPropertyName = "NullableCreateDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemType?), TypeInfoPropertyName = "NullableGetDocumentsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseType?), TypeInfoPropertyName = "NullableGetDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItemUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseUsedByItem>))]
    internal sealed partial class KnowledgeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KnowledgeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Runway.GetDocumentsSort)

                    || typeToConvert == typeof(global::Runway.GetDocumentsSort?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsOrder)

                    || typeToConvert == typeof(global::Runway.GetDocumentsOrder?)

                    || typeToConvert == typeof(global::Runway.CreateDocumentsResponseType)

                    || typeToConvert == typeof(global::Runway.CreateDocumentsResponseType?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseType)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.GetDocumentsSort))
                {
                    return new global::Runway.JsonConverters.GetDocumentsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsSort?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsOrder))
                {
                    return new global::Runway.JsonConverters.GetDocumentsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsOrder?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateDocumentsResponseType))
                {
                    return new global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateDocumentsResponseType?))
                {
                    return new global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseType))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseType?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new KnowledgeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
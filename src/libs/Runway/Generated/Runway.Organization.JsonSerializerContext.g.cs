
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetOrganizationWebappUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType), TypeInfoPropertyName = "GetOrganizationWebappUsageResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetOrganizationWebappAuditLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction), TypeInfoPropertyName = "GetOrganizationWebappAuditLogsResponseDataItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction), TypeInfoPropertyName = "GetOrganizationWebappAuditLogsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetOrganizationResponseTierModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseTierModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetOrganizationResponseUsageModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseUsageModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel), TypeInfoPropertyName = "CreateOrganizationUsageResponseResultUsedCreditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseModel), TypeInfoPropertyName = "CreateOrganizationUsageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?), TypeInfoPropertyName = "NullableGetOrganizationWebappUsageResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?), TypeInfoPropertyName = "NullableGetOrganizationWebappAuditLogsResponseDataItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?), TypeInfoPropertyName = "NullableGetOrganizationWebappAuditLogsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseResultUsedCreditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetOrganizationWebappUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetOrganizationWebappAuditLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit>))]
    internal sealed partial class OrganizationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappUsageResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappUsageResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseDataItemActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseDataItemActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel?))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter();
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
                    0 => new OrganizationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
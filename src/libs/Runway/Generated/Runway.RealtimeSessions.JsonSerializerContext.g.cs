
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar2), TypeInfoPropertyName = "Avatar22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId), TypeInfoPropertyName = "CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ToolsItem), TypeInfoPropertyName = "ToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem), TypeInfoPropertyName = "ParametersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ParametersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem2), TypeInfoPropertyName = "ParametersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Integration), TypeInfoPropertyName = "Integration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestIntegrationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestLivekit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponse), TypeInfoPropertyName = "GetRealtimeSessionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetRealtimeSessionsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar2?), TypeInfoPropertyName = "NullableAvatar22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem?), TypeInfoPropertyName = "NullableParametersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem2?), TypeInfoPropertyName = "NullableParametersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Integration?), TypeInfoPropertyName = "NullableIntegration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestIntegrationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponse?), TypeInfoPropertyName = "NullableGetRealtimeSessionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetRealtimeSessionsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ParametersItem2>))]
    internal sealed partial class RealtimeSessionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSessionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RealtimeSessionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RealtimeSessionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Runway.JsonConverters.Avatar2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ParametersItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ParametersItem2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.IntegrationJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter());
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
                    typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter();
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
                    0 => new RealtimeSessionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
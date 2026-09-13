
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.From), TypeInfoPropertyName = "From2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel), TypeInfoPropertyName = "CreateVoicesRequestFromVoiceFromTextModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType), TypeInfoPropertyName = "CreateVoicesRequestFromDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequestModel), TypeInfoPropertyName = "CreateVoicesPreviewRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus), TypeInfoPropertyName = "GetVoicesResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse2), TypeInfoPropertyName = "GetVoicesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminatorStatus), TypeInfoPropertyName = "GetVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponse), TypeInfoPropertyName = "PatchVoicesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus), TypeInfoPropertyName = "PatchVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.From?), TypeInfoPropertyName = "NullableFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?), TypeInfoPropertyName = "NullableCreateVoicesRequestFromVoiceFromTextModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?), TypeInfoPropertyName = "NullableCreateVoicesRequestFromDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequestModel?), TypeInfoPropertyName = "NullableCreateVoicesPreviewRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetVoicesResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse2?), TypeInfoPropertyName = "NullableGetVoicesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponse?), TypeInfoPropertyName = "NullablePatchVoicesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullablePatchVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.DataItem2>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Runway.JsonConverters.FromJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchVoicesResponseJsonConverter());
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
                    typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel)

                    || typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel?)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel))
                {
                    return new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter();
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
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
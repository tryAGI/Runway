
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar), TypeInfoPropertyName = "Avatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId), TypeInfoPropertyName = "CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Speech), TypeInfoPropertyName = "Speech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice3), TypeInfoPropertyName = "Voice32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar?), TypeInfoPropertyName = "NullableAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Speech?), TypeInfoPropertyName = "NullableSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice3?), TypeInfoPropertyName = "NullableVoice32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechDiscriminatorType2")]
    internal sealed partial class AvatarVideosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AvatarVideosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AvatarVideosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AvatarVideosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Runway.JsonConverters.AvatarJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.SpeechJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice3JsonConverter());
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
                    typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter();
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
                    0 => new AvatarVideosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
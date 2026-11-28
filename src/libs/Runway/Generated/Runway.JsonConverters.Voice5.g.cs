#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice5>
    {
        /// <inheritdoc />
        public override global::Runway.Voice5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice? runwayPreset = default;
            if (discriminator?.Type == global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.RunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice)}");
                runwayPreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice? custom = default;
            if (discriminator?.Type == global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice5(
                discriminator?.Type,
                runwayPreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRunwayPreset(), typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustom(), typeInfo);
            }
        }
    }
}
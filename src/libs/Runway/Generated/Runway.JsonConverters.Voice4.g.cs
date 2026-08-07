#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice4>
    {
        /// <inheritdoc />
        public override global::Runway.Voice4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? seedPreset = default;
            if (discriminator?.Type == global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType.SeedPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice)}");
                seedPreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? referenceAudio = default;
            if (discriminator?.Type == global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType.ReferenceAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice)}");
                referenceAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice4(
                discriminator?.Type,
                seedPreset,

                referenceAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSeedPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SeedPreset!, typeInfo);
            }
            else if (value.IsReferenceAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReferenceAudio!, typeInfo);
            }
        }
    }
}
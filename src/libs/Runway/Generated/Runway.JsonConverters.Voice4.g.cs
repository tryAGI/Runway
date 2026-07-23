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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? preset = default;
            if (discriminator?.Type == global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType.Preset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice)}");
                preset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? referenceAudio = default;
            if (discriminator?.Type == global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType.ReferenceAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice)}");
                referenceAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice4(
                discriminator?.Type,
                preset,

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

            if (value.IsPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preset!, typeInfo);
            }
            else if (value.IsReferenceAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReferenceAudio!, typeInfo);
            }
        }
    }
}
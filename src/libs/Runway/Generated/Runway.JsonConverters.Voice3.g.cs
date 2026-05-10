#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice3>
    {
        /// <inheritdoc />
        public override global::Runway.Voice3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? preset = default;
            if (discriminator?.Type == global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Preset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice)}");
                preset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? custom = default;
            if (discriminator?.Type == global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice3(
                discriminator?.Type,
                preset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
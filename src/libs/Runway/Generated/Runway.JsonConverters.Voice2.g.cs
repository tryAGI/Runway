#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice2>
    {
        /// <inheritdoc />
        public override global::Runway.Voice2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsRequestVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsRequestVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsRequestVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsRequestVoiceCustomVoice? custom = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsRequestVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsRequestVoiceCustomVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsRequestVoiceCustomVoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsRequestVoiceCustomVoice)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice2(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsRequestVoiceCustomVoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsRequestVoiceCustomVoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsRequestVoiceCustomVoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
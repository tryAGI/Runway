#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice15JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice15>
    {
        /// <inheritdoc />
        public override global::Runway.Voice15 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? custom = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice15(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice15 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
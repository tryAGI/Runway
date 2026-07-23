#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice16JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice16>
    {
        /// <inheritdoc />
        public override global::Runway.Voice16 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? custom = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice16(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice16 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice14JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice14>
    {
        /// <inheritdoc />
        public override global::Runway.Voice14 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? custom = default;
            if (discriminator?.Type == global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice14(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice14 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
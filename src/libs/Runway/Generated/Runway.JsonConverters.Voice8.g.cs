#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice8>
    {
        /// <inheritdoc />
        public override global::Runway.Voice8 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? custom = default;
            if (discriminator?.Type == global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice8(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
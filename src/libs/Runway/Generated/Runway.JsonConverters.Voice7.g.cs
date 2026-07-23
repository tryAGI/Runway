#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Voice7JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Voice7>
    {
        /// <inheritdoc />
        public override global::Runway.Voice7 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse? runwayLivePreset = default;
            if (discriminator?.Type == global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.RunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse)}");
                runwayLivePreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse? custom = default;
            if (discriminator?.Type == global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Voice7(
                discriminator?.Type,
                runwayLivePreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Voice7 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayLivePreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayLivePreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
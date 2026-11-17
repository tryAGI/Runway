#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Avatar2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Avatar2>
    {
        /// <inheritdoc />
        public override global::Runway.Avatar2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? runwayPreset = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.RunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar)}");
                runwayPreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? custom = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Avatar2(
                discriminator?.Type,
                runwayPreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Avatar2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRunwayPreset(), typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustom(), typeInfo);
            }
        }
    }
}
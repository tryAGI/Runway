#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class AvatarVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.AvatarVariant13>
    {
        /// <inheritdoc />
        public override global::Runway.AvatarVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar? runwayPreset = default;
            if (discriminator?.Type == global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.RunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar)}");
                runwayPreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar? custom = default;
            if (discriminator?.Type == global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.AvatarVariant13(
                discriminator?.Type,
                runwayPreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.AvatarVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayPreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
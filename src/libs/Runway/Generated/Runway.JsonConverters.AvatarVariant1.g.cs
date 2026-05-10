#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class AvatarVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.AvatarVariant1>
    {
        /// <inheritdoc />
        public override global::Runway.AvatarVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? runwayPreset = default;
            if (discriminator?.Type == global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.RunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary)}");
                runwayPreset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? custom = default;
            if (discriminator?.Type == global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.AvatarVariant1(
                discriminator?.Type,
                runwayPreset,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.AvatarVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunwayPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunwayPreset!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
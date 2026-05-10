#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class GetAvatarConversationsResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarConversationsResponse2>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarConversationsResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetAvatarConversationsResponseVariant1? inProgress = default;
            if (discriminator?.Status == global::Runway.GetAvatarConversationsResponseDiscriminatorStatus.InProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant1)}");
                inProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarConversationsResponseVariant2? ended = default;
            if (discriminator?.Status == global::Runway.GetAvatarConversationsResponseDiscriminatorStatus.Ended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant2)}");
                ended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarConversationsResponseVariant3? failed = default;
            if (discriminator?.Status == global::Runway.GetAvatarConversationsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarConversationsResponseVariant3)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.GetAvatarConversationsResponse2(
                discriminator?.Status,
                inProgress,

                ended,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarConversationsResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InProgress!, typeInfo);
            }
            else if (value.IsEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ended!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarConversationsResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarConversationsResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarConversationsResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
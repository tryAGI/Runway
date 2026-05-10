#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class GetAvatarsResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarsResponse2>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarsResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetAvatarsResponseAvatarProcessing? processing = default;
            if (discriminator?.Status == global::Runway.GetAvatarsResponseDiscriminatorStatus.Processing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarProcessing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseAvatarProcessing)}");
                processing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarsResponseAvatarReady? ready = default;
            if (discriminator?.Status == global::Runway.GetAvatarsResponseDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseAvatarReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetAvatarsResponseAvatarFailed? failed = default;
            if (discriminator?.Status == global::Runway.GetAvatarsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetAvatarsResponseAvatarFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.GetAvatarsResponse2(
                discriminator?.Status,
                processing,

                ready,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarsResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarsResponseAvatarProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarsResponseAvatarReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetAvatarsResponseAvatarFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetAvatarsResponseAvatarFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
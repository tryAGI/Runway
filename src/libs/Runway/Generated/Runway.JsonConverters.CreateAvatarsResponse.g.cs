#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateAvatarsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateAvatarsResponse>
    {
        /// <inheritdoc />
        public override global::Runway.CreateAvatarsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateAvatarsResponseAvatarProcessing? processing = default;
            if (discriminator?.Status == global::Runway.CreateAvatarsResponseDiscriminatorStatus.Processing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarProcessing)}");
                processing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateAvatarsResponseAvatarReady? ready = default;
            if (discriminator?.Status == global::Runway.CreateAvatarsResponseDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateAvatarsResponseAvatarFailed? failed = default;
            if (discriminator?.Status == global::Runway.CreateAvatarsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarsResponseAvatarFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateAvatarsResponse(
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
            global::Runway.CreateAvatarsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarsResponseAvatarProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarsResponseAvatarReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarsResponseAvatarFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarsResponseAvatarFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
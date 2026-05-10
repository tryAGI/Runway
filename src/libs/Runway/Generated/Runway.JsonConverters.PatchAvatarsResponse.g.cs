#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class PatchAvatarsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PatchAvatarsResponse>
    {
        /// <inheritdoc />
        public override global::Runway.PatchAvatarsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchAvatarsResponseAvatarProcessing? processing = default;
            if (discriminator?.Status == global::Runway.PatchAvatarsResponseDiscriminatorStatus.Processing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarProcessing)}");
                processing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsResponseAvatarReady? ready = default;
            if (discriminator?.Status == global::Runway.PatchAvatarsResponseDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchAvatarsResponseAvatarFailed? failed = default;
            if (discriminator?.Status == global::Runway.PatchAvatarsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchAvatarsResponseAvatarFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.PatchAvatarsResponse(
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
            global::Runway.PatchAvatarsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchAvatarsResponseAvatarFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchAvatarsResponseAvatarFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchAvatarsResponseAvatarFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
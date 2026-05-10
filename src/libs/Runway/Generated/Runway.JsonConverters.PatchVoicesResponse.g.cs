#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class PatchVoicesResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PatchVoicesResponse>
    {
        /// <inheritdoc />
        public override global::Runway.PatchVoicesResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchVoicesResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.PatchVoicesResponseVoiceProcessing? processing = default;
            if (discriminator?.Status == global::Runway.PatchVoicesResponseDiscriminatorStatus.Processing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceProcessing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchVoicesResponseVoiceProcessing)}");
                processing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchVoicesResponseVoiceReady? ready = default;
            if (discriminator?.Status == global::Runway.PatchVoicesResponseDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchVoicesResponseVoiceReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.PatchVoicesResponseVoiceFailed? failed = default;
            if (discriminator?.Status == global::Runway.PatchVoicesResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.PatchVoicesResponseVoiceFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.PatchVoicesResponse(
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
            global::Runway.PatchVoicesResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
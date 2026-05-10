#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.DataItem2>
    {
        /// <inheritdoc />
        public override global::Runway.DataItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetVoicesResponseDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetVoicesResponseDataItemVoiceProcessing? processing = default;
            if (discriminator?.Status == global::Runway.GetVoicesResponseDataItemDiscriminatorStatus.Processing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceProcessing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetVoicesResponseDataItemVoiceProcessing)}");
                processing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetVoicesResponseDataItemVoiceReady? ready = default;
            if (discriminator?.Status == global::Runway.GetVoicesResponseDataItemDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetVoicesResponseDataItemVoiceReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetVoicesResponseDataItemVoiceFailed? failed = default;
            if (discriminator?.Status == global::Runway.GetVoicesResponseDataItemDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetVoicesResponseDataItemVoiceFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.DataItem2(
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
            global::Runway.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetVoicesResponseDataItemVoiceReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetVoicesResponseDataItemVoiceFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
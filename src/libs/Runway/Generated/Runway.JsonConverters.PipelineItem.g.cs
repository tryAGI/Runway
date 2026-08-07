#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class PipelineItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PipelineItem>
    {
        /// <inheritdoc />
        public override global::Runway.PipelineItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? filter = default;
            if (discriminator?.Type == global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Filter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1)}");
                filter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? capacity = default;
            if (discriminator?.Type == global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Capacity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2)}");
                capacity = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? rank = default;
            if (discriminator?.Type == global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Rank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3)}");
                rank = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.PipelineItem(
                discriminator?.Type,
                filter,

                capacity,

                rank
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.PipelineItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Filter!, typeInfo);
            }
            else if (value.IsCapacity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Capacity!, typeInfo);
            }
            else if (value.IsRank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rank!, typeInfo);
            }
        }
    }
}
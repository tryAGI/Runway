#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class NodeOutputsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.NodeOutputs>
    {
        /// <inheritdoc />
        public override global::Runway.NodeOutputs Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? primitive = default;
            if (discriminator?.Type == global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType.Primitive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive)}");
                primitive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? image = default;
            if (discriminator?.Type == global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? video = default;
            if (discriminator?.Type == global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? audio = default;
            if (discriminator?.Type == global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.NodeOutputs(
                discriminator?.Type,
                primitive,

                image,

                video,

                audio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.NodeOutputs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPrimitive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Primitive!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
        }
    }
}
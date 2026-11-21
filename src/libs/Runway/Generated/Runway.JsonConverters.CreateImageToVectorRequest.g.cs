#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateImageToVectorRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateImageToVectorRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateImageToVectorRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVectorRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVectorRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVectorRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateImageToVectorRequestIdeogramVector? ideogramVector = default;
            if (discriminator?.Model == global::Runway.CreateImageToVectorRequestDiscriminatorModel.IdeogramVector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVectorRequestIdeogramVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVectorRequestIdeogramVector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVectorRequestIdeogramVector)}");
                ideogramVector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateImageToVectorRequest(
                discriminator?.Model,
                ideogramVector
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateImageToVectorRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIdeogramVector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVectorRequestIdeogramVector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVectorRequestIdeogramVector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVectorRequestIdeogramVector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickIdeogramVector(), typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateImageUpscaleRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateImageUpscaleRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateImageUpscaleRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageUpscaleRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageUpscaleRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageUpscaleRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? magnificPrecisionUpscalerV2 = default;
            if (discriminator?.Model == global::Runway.CreateImageUpscaleRequestDiscriminatorModel.MagnificPrecisionUpscalerV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2)}");
                magnificPrecisionUpscalerV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateImageUpscaleRequest(
                discriminator?.Model,
                magnificPrecisionUpscalerV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateImageUpscaleRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMagnificPrecisionUpscalerV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MagnificPrecisionUpscalerV2!, typeInfo);
            }
        }
    }
}
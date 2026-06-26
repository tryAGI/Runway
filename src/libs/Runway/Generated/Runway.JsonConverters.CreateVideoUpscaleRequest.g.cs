#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateVideoUpscaleRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVideoUpscaleRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVideoUpscaleRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoUpscaleRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoUpscaleRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoUpscaleRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? magnificVideoUpscalerCreative = default;
            if (discriminator?.Model == global::Runway.CreateVideoUpscaleRequestDiscriminatorModel.MagnificVideoUpscalerCreative)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative)}");
                magnificVideoUpscalerCreative = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateVideoUpscaleRequest(
                discriminator?.Model,
                magnificVideoUpscalerCreative
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVideoUpscaleRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMagnificVideoUpscalerCreative)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MagnificVideoUpscalerCreative!, typeInfo);
            }
        }
    }
}
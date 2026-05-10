#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateCharacterPerformanceRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateCharacterPerformanceRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateCharacterPerformanceRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateCharacterPerformanceRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateCharacterPerformanceRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateCharacterPerformanceRequestActTwo? actTwo = default;
            if (discriminator?.Model == global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel.ActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateCharacterPerformanceRequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateCharacterPerformanceRequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateCharacterPerformanceRequestActTwo)}");
                actTwo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateCharacterPerformanceRequest(
                discriminator?.Model,
                actTwo
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateCharacterPerformanceRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateCharacterPerformanceRequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateCharacterPerformanceRequestActTwo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateCharacterPerformanceRequestActTwo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ActTwo!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateGenerateImageResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateImageResponse>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateImageResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateImageResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateImageResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateImageResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? @false = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateImageResponseDiscriminatorDryRun.False)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated)}");
                @false = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateGenerateImageResponseRoutedImageDryRun? @true = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateImageResponseDiscriminatorDryRun.True)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateImageResponseRoutedImageDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateImageResponseRoutedImageDryRun> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateImageResponseRoutedImageDryRun)}");
                @true = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateGenerateImageResponse(
                discriminator?.DryRun,
                @false,

                @true
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateImageResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFalse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.False!, typeInfo);
            }
            else if (value.IsTrue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateImageResponseRoutedImageDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateImageResponseRoutedImageDryRun?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateImageResponseRoutedImageDryRun).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.True!, typeInfo);
            }
        }
    }
}
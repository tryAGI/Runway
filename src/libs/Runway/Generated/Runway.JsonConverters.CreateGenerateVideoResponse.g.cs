#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateGenerateVideoResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateVideoResponse>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateVideoResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateVideoResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateVideoResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateVideoResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? @false = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun.False)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated)}");
                @false = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? @true = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun.True)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun)}");
                @true = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateGenerateVideoResponse(
                discriminator?.DryRun,
                @false,

                @true
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateVideoResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFalse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.False!, typeInfo);
            }
            else if (value.IsTrue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.True!, typeInfo);
            }
        }
    }
}
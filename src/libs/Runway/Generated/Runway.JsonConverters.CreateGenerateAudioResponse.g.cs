#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateGenerateAudioResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateAudioResponse>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateAudioResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? @false = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun.False)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated)}");
                @false = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? @true = default;
            if (discriminator?.DryRun == global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun.True)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun)}");
                @true = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateGenerateAudioResponse(
                discriminator?.DryRun,
                @false,

                @true
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateAudioResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFalse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.False!, typeInfo);
            }
            else if (value.IsTrue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.True!, typeInfo);
            }
        }
    }
}
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToSpeechRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToSpeechRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToSpeechRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateTextToSpeechRequestSeedAudio? seedAudio = default;
            if (discriminator?.Model == global::Runway.CreateTextToSpeechRequestDiscriminatorModel.SeedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestSeedAudio)}");
                seedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? elevenMultilingualV2 = default;
            if (discriminator?.Model == global::Runway.CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2)}");
                elevenMultilingualV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateTextToSpeechRequest(
                discriminator?.Model,
                seedAudio,

                elevenMultilingualV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToSpeechRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSeedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestSeedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestSeedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestSeedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SeedAudio!, typeInfo);
            }
            else if (value.IsElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenMultilingualV2!, typeInfo);
            }
        }
    }
}
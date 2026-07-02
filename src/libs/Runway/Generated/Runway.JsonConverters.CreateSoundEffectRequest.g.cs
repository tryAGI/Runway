#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateSoundEffectRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateSoundEffectRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateSoundEffectRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateSoundEffectRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateSoundEffectRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateSoundEffectRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateSoundEffectRequestSeedAudio? seedAudio = default;
            if (discriminator?.Model == global::Runway.CreateSoundEffectRequestDiscriminatorModel.SeedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateSoundEffectRequestSeedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateSoundEffectRequestSeedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateSoundEffectRequestSeedAudio)}");
                seedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? elevenTextToSoundV2 = default;
            if (discriminator?.Model == global::Runway.CreateSoundEffectRequestDiscriminatorModel.ElevenTextToSoundV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2)}");
                elevenTextToSoundV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateSoundEffectRequest(
                discriminator?.Model,
                seedAudio,

                elevenTextToSoundV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateSoundEffectRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSeedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateSoundEffectRequestSeedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateSoundEffectRequestSeedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateSoundEffectRequestSeedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SeedAudio!, typeInfo);
            }
            else if (value.IsElevenTextToSoundV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenTextToSoundV2!, typeInfo);
            }
        }
    }
}
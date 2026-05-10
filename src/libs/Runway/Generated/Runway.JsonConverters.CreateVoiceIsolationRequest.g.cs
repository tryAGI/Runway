#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateVoiceIsolationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVoiceIsolationRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVoiceIsolationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceIsolationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoiceIsolationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation? elevenVoiceIsolation = default;
            if (discriminator?.Model == global::Runway.CreateVoiceIsolationRequestDiscriminatorModel.ElevenVoiceIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation)}");
                elevenVoiceIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateVoiceIsolationRequest(
                discriminator?.Model,
                elevenVoiceIsolation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVoiceIsolationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenVoiceIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenVoiceIsolation!, typeInfo);
            }
        }
    }
}
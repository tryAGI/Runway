#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateVoiceDubbingRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVoiceDubbingRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVoiceDubbingRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceDubbingRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoiceDubbingRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing? elevenVoiceDubbing = default;
            if (discriminator?.Model == global::Runway.CreateVoiceDubbingRequestDiscriminatorModel.ElevenVoiceDubbing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing)}");
                elevenVoiceDubbing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateVoiceDubbingRequest(
                discriminator?.Model,
                elevenVoiceDubbing
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVoiceDubbingRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenVoiceDubbing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenVoiceDubbing!, typeInfo);
            }
        }
    }
}
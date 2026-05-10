#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class FromJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.From>
    {
        /// <inheritdoc />
        public override global::Runway.From Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoicesRequestFromDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoicesRequestFromDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoicesRequestFromDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateVoicesRequestFromVoiceFromAudio? audio = default;
            if (discriminator?.Type == global::Runway.CreateVoicesRequestFromDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoicesRequestFromVoiceFromAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoicesRequestFromVoiceFromAudio)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVoicesRequestFromVoiceFromText? text = default;
            if (discriminator?.Type == global::Runway.CreateVoicesRequestFromDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoicesRequestFromVoiceFromText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoicesRequestFromVoiceFromText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVoicesRequestFromVoiceFromText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.From(
                discriminator?.Type,
                audio,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.From value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoicesRequestFromVoiceFromAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVoicesRequestFromVoiceFromText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVoicesRequestFromVoiceFromText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVoicesRequestFromVoiceFromText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}
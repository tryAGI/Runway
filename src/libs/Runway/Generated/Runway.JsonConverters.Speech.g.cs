#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class SpeechJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Speech>
    {
        /// <inheritdoc />
        public override global::Runway.Speech Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateAvatarVideosRequestSpeechAudioInput? audio = default;
            if (discriminator?.Type == global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechAudioInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateAvatarVideosRequestSpeechTextInput? text = default;
            if (discriminator?.Type == global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateAvatarVideosRequestSpeechTextInput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Speech(
                discriminator?.Type,
                audio,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Speech value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechAudioInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateAvatarVideosRequestSpeechTextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}
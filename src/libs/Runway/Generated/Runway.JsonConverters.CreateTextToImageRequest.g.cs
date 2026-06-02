#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToImageRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToImageRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToImageRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateTextToImageRequestGen4ImageTurbo? gen4ImageTurbo = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGen4ImageTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGen4ImageTurbo)}");
                gen4ImageTurbo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGen4Image? gen4Image = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Gen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGen4Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGen4Image)}");
                gen4Image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGptImage2? gptImage2 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GptImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGptImage2)}");
                gptImage2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGeminiImage3Pro? geminiImage3Pro = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage3Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGeminiImage3Pro)}");
                geminiImage3Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGeminiImage31Flash? geminiImage31Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GeminiImage31Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGeminiImage31Flash)}");
                geminiImage31Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGemini25Flash? gemini25Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Gemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGemini25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGemini25Flash)}");
                gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateTextToImageRequest(
                discriminator?.Model,
                gen4ImageTurbo,

                gen4Image,

                gptImage2,

                geminiImage3Pro,

                geminiImage31Flash,

                gemini25Flash
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToImageRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGen4ImageTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGen4ImageTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4ImageTurbo!, typeInfo);
            }
            else if (value.IsGen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGen4Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGen4Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Image!, typeInfo);
            }
            else if (value.IsGptImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GptImage2!, typeInfo);
            }
            else if (value.IsGeminiImage3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage3Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiImage3Pro!, typeInfo);
            }
            else if (value.IsGeminiImage31Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiImage31Flash!, typeInfo);
            }
            else if (value.IsGemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGemini25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGemini25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini25Flash!, typeInfo);
            }
        }
    }
}
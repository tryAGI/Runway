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
            global::Runway.CreateTextToImageRequestGeminiImage31Flash? geminiImage31Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GeminiImage31Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGeminiImage31Flash)}");
                geminiImage31Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestMuseImage? museImage = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.MuseImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestMuseImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestMuseImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestMuseImage)}");
                museImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestSeedream5Pro? seedream5Pro = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Seedream5Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestSeedream5Pro)}");
                seedream5Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestSeedream5Lite? seedream5Lite = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Seedream5Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Lite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestSeedream5Lite)}");
                seedream5Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGrokImagineImage2? grokImagineImage2 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GrokImagineImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGrokImagineImage2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGrokImagineImage2)}");
                grokImagineImage2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? geminiImage31FlashLite = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GeminiImage31FlashLite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite)}");
                geminiImage31FlashLite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGeminiImage3Pro? geminiImage3Pro = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage3Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGeminiImage3Pro)}");
                geminiImage3Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGptImage25Flare? gptImage25Flare = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GptImage25Flare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage25Flare), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage25Flare> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGptImage25Flare)}");
                gptImage25Flare = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGptImage25Sunburst? gptImage25Sunburst = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GptImage25Sunburst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage25Sunburst), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage25Sunburst> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGptImage25Sunburst)}");
                gptImage25Sunburst = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestBriaFibo15? briaFibo15 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.BriaFibo15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestBriaFibo15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestBriaFibo15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestBriaFibo15)}");
                briaFibo15 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestBriaFiboEdit15? briaFiboEdit15 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.BriaFiboEdit15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestBriaFiboEdit15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestBriaFiboEdit15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestBriaFiboEdit15)}");
                briaFiboEdit15 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestIdeogram40? ideogram40 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Ideogram40)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestIdeogram40), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestIdeogram40> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestIdeogram40)}");
                ideogram40 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestIdeogram45? ideogram45 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Ideogram45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestIdeogram45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestIdeogram45> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestIdeogram45)}");
                ideogram45 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestSeedream5Flash? seedream5Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Seedream5Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestSeedream5Flash)}");
                seedream5Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestNanoBanana21? nanoBanana21 = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.NanoBanana21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestNanoBanana21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestNanoBanana21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestNanoBanana21)}");
                nanoBanana21 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestRecraftV41Flash? recraftV41Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.RecraftV41Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestRecraftV41Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestRecraftV41Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestRecraftV41Flash)}");
                recraftV41Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestRecraftV41Vector? recraftV41Vector = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.RecraftV41Vector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestRecraftV41Vector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestRecraftV41Vector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestRecraftV41Vector)}");
                recraftV41Vector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGemini25Flash? gemini25Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.Gemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGemini25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGemini25Flash)}");
                gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGptImage26Flare? gptImage26Flare = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GptImage26Flare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage26Flare), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage26Flare> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGptImage26Flare)}");
                gptImage26Flare = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToImageRequestGptImage26Sunburst? gptImage26Sunburst = default;
            if (discriminator?.Model == global::Runway.CreateTextToImageRequestDiscriminatorModel.GptImage26Sunburst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage26Sunburst), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage26Sunburst> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToImageRequestGptImage26Sunburst)}");
                gptImage26Sunburst = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateTextToImageRequest(
                discriminator?.Model,
                gen4ImageTurbo,

                gen4Image,

                gptImage2,

                geminiImage31Flash,

                museImage,

                seedream5Pro,

                seedream5Lite,

                grokImagineImage2,

                geminiImage31FlashLite,

                geminiImage3Pro,

                gptImage25Flare,

                gptImage25Sunburst,

                briaFibo15,

                briaFiboEdit15,

                ideogram40,

                ideogram45,

                seedream5Flash,

                nanoBanana21,

                recraftV41Flash,

                recraftV41Vector,

                gemini25Flash,

                gptImage26Flare,

                gptImage26Sunburst
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGen4ImageTurbo(), typeInfo);
            }
            else if (value.IsGen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGen4Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGen4Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGen4Image(), typeInfo);
            }
            else if (value.IsGptImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGptImage2(), typeInfo);
            }
            else if (value.IsGeminiImage31Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiImage31Flash(), typeInfo);
            }
            else if (value.IsMuseImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestMuseImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestMuseImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestMuseImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMuseImage(), typeInfo);
            }
            else if (value.IsSeedream5Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestSeedream5Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedream5Pro(), typeInfo);
            }
            else if (value.IsSeedream5Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Lite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestSeedream5Lite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedream5Lite(), typeInfo);
            }
            else if (value.IsGrokImagineImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGrokImagineImage2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrokImagineImage2(), typeInfo);
            }
            else if (value.IsGeminiImage31FlashLite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiImage31FlashLite(), typeInfo);
            }
            else if (value.IsGeminiImage3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGeminiImage3Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiImage3Pro(), typeInfo);
            }
            else if (value.IsGptImage25Flare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage25Flare), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage25Flare?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage25Flare).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGptImage25Flare(), typeInfo);
            }
            else if (value.IsGptImage25Sunburst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage25Sunburst), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage25Sunburst?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage25Sunburst).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGptImage25Sunburst(), typeInfo);
            }
            else if (value.IsBriaFibo15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestBriaFibo15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestBriaFibo15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestBriaFibo15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBriaFibo15(), typeInfo);
            }
            else if (value.IsBriaFiboEdit15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestBriaFiboEdit15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestBriaFiboEdit15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestBriaFiboEdit15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBriaFiboEdit15(), typeInfo);
            }
            else if (value.IsIdeogram40)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestIdeogram40), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestIdeogram40?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestIdeogram40).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickIdeogram40(), typeInfo);
            }
            else if (value.IsIdeogram45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestIdeogram45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestIdeogram45?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestIdeogram45).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickIdeogram45(), typeInfo);
            }
            else if (value.IsSeedream5Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestSeedream5Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestSeedream5Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestSeedream5Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedream5Flash(), typeInfo);
            }
            else if (value.IsNanoBanana21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestNanoBanana21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestNanoBanana21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestNanoBanana21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNanoBanana21(), typeInfo);
            }
            else if (value.IsRecraftV41Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestRecraftV41Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestRecraftV41Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestRecraftV41Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRecraftV41Flash(), typeInfo);
            }
            else if (value.IsRecraftV41Vector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestRecraftV41Vector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestRecraftV41Vector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestRecraftV41Vector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRecraftV41Vector(), typeInfo);
            }
            else if (value.IsGemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGemini25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGemini25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGemini25Flash(), typeInfo);
            }
            else if (value.IsGptImage26Flare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage26Flare), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage26Flare?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage26Flare).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGptImage26Flare(), typeInfo);
            }
            else if (value.IsGptImage26Sunburst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToImageRequestGptImage26Sunburst), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToImageRequestGptImage26Sunburst?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToImageRequestGptImage26Sunburst).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGptImage26Sunburst(), typeInfo);
            }
        }
    }
}
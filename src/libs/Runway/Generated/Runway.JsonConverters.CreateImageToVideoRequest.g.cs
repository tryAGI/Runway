#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateImageToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateImageToVideoRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateImageToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateImageToVideoRequestGen45? gen45 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Gen45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGen45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGen45> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGen45)}");
                gen45 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGen4Turbo? gen4Turbo = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGen4Turbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGen4Turbo)}");
                gen4Turbo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestVeo31? veo31 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Veo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestVeo31)}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestVeo31Fast? veo31Fast = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Veo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestVeo31Fast)}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKlingO34k? klingO34k = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.KlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO34k> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKlingO34k)}");
                klingO34k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestHailuo3? hailuo3 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Hailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestHailuo3)}");
                hailuo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling304k? kling304k = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling304k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling304k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling304k> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling304k)}");
                kling304k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestHappyhorse10? happyhorse10 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Happyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHappyhorse10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestHappyhorse10)}");
                happyhorse10 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling25TurboPro? kling25TurboPro = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling25TurboPro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling25TurboPro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling25TurboPro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling25TurboPro)}");
                kling25TurboPro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling30Pro? kling30Pro = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling30Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling30Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling30Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling30Pro)}");
                kling30Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling30Standard? kling30Standard = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling30Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling30Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling30Standard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling30Standard)}");
                kling30Standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKlingO3Pro? klingO3Pro = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.KlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO3Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKlingO3Pro)}");
                klingO3Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKlingO3Standard? klingO3Standard = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.KlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO3Standard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKlingO3Standard)}");
                klingO3Standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestSeedance2? seedance2 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Seedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestSeedance2)}");
                seedance2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestSeedance2Fast? seedance2Fast = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestSeedance2Fast)}");
                seedance2Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestSeedance2Mini? seedance2Mini = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Seedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Mini> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestSeedance2Mini)}");
                seedance2Mini = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash? geminiOmniFlash = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash)}");
                geminiOmniFlash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGrokImagine15? grokImagine15 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.GrokImagine15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGrokImagine15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGrokImagine15)}");
                grokImagine15 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestWan3? wan3 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Wan3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestWan3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestWan3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestWan3)}");
                wan3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? geminiOmniFlash11 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11)}");
                geminiOmniFlash11 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestWan3Prime? wan3Prime = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Wan3Prime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestWan3Prime), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestWan3Prime> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestWan3Prime)}");
                wan3Prime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestH3Max? h3Max = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.H3Max)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestH3Max), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestH3Max> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestH3Max)}");
                h3Max = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestSeedance25? seedance25 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Seedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestSeedance25)}");
                seedance25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGrokImagine15Lite? grokImagine15Lite = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.GrokImagine15Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGrokImagine15Lite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGrokImagine15Lite)}");
                grokImagine15Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling4? kling4 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling4)}");
                kling4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? geminiOmniFlash12 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12)}");
                geminiOmniFlash12 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestKling4Flash? kling4Flash = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Kling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling4Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestKling4Flash)}");
                kling4Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestHailuo3Highspeed? hailuo3Highspeed = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Hailuo3Highspeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3Highspeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3Highspeed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestHailuo3Highspeed)}");
                hailuo3Highspeed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestHailuo3Lite? hailuo3Lite = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Hailuo3Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3Lite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestHailuo3Lite)}");
                hailuo3Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateImageToVideoRequestSeedance25Flash? seedance25Flash = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Seedance25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestSeedance25Flash)}");
                seedance25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateImageToVideoRequest(
                discriminator?.Model,
                gen45,

                gen4Turbo,

                veo31,

                veo31Fast,

                klingO34k,

                hailuo3,

                kling304k,

                happyhorse10,

                kling25TurboPro,

                kling30Pro,

                kling30Standard,

                klingO3Pro,

                klingO3Standard,

                seedance2,

                seedance2Fast,

                seedance2Mini,

                geminiOmniFlash,

                grokImagine15,

                wan3,

                geminiOmniFlash11,

                wan3Prime,

                h3Max,

                seedance25,

                grokImagine15Lite,

                kling4,

                geminiOmniFlash12,

                kling4Flash,

                hailuo3Highspeed,

                hailuo3Lite,

                seedance25Flash
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateImageToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGen45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGen45?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGen45).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGen45(), typeInfo);
            }
            else if (value.IsGen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGen4Turbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGen4Turbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGen4Turbo(), typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVeo31(), typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVeo31Fast(), typeInfo);
            }
            else if (value.IsKlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO34k?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKlingO34k).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO34k(), typeInfo);
            }
            else if (value.IsHailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestHailuo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3(), typeInfo);
            }
            else if (value.IsKling304k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling304k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling304k?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling304k).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling304k(), typeInfo);
            }
            else if (value.IsHappyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHappyhorse10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestHappyhorse10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHappyhorse10(), typeInfo);
            }
            else if (value.IsKling25TurboPro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling25TurboPro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling25TurboPro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling25TurboPro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling25TurboPro(), typeInfo);
            }
            else if (value.IsKling30Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling30Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling30Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling30Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling30Pro(), typeInfo);
            }
            else if (value.IsKling30Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling30Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling30Standard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling30Standard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling30Standard(), typeInfo);
            }
            else if (value.IsKlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO3Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKlingO3Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Pro(), typeInfo);
            }
            else if (value.IsKlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKlingO3Standard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKlingO3Standard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Standard(), typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2(), typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Fast(), typeInfo);
            }
            else if (value.IsSeedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Mini?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Mini(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash(), typeInfo);
            }
            else if (value.IsGrokImagine15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGrokImagine15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGrokImagine15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrokImagine15(), typeInfo);
            }
            else if (value.IsWan3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestWan3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestWan3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestWan3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWan3(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash11(), typeInfo);
            }
            else if (value.IsWan3Prime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestWan3Prime), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestWan3Prime?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestWan3Prime).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWan3Prime(), typeInfo);
            }
            else if (value.IsH3Max)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestH3Max), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestH3Max?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestH3Max).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickH3Max(), typeInfo);
            }
            else if (value.IsSeedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance25(), typeInfo);
            }
            else if (value.IsGrokImagine15Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGrokImagine15Lite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Lite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrokImagine15Lite(), typeInfo);
            }
            else if (value.IsKling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash12(), typeInfo);
            }
            else if (value.IsKling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestKling4Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestKling4Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4Flash(), typeInfo);
            }
            else if (value.IsHailuo3Highspeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3Highspeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3Highspeed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestHailuo3Highspeed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3Highspeed(), typeInfo);
            }
            else if (value.IsHailuo3Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHailuo3Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHailuo3Lite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestHailuo3Lite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3Lite(), typeInfo);
            }
            else if (value.IsSeedance25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance25Flash(), typeInfo);
            }
        }
    }
}
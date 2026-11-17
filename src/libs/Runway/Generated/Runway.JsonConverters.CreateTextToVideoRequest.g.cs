#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToVideoRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateTextToVideoRequestGen45? gen45 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Gen45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGen45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGen45> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGen45)}");
                gen45 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestVeo31? veo31 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Veo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestVeo31)}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestVeo31Fast? veo31Fast = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Veo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestVeo31Fast)}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKlingO34k? klingO34k = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.KlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO34k> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKlingO34k)}");
                klingO34k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestHailuo3? hailuo3 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Hailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHailuo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestHailuo3)}");
                hailuo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling304k? kling304k = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling304k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling304k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling304k> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling304k)}");
                kling304k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestHappyhorse10? happyhorse10 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Happyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHappyhorse10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestHappyhorse10)}");
                happyhorse10 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling25TurboPro? kling25TurboPro = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling25TurboPro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling25TurboPro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling25TurboPro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling25TurboPro)}");
                kling25TurboPro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling30Pro? kling30Pro = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling30Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling30Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling30Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling30Pro)}");
                kling30Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling30Standard? kling30Standard = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling30Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling30Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling30Standard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling30Standard)}");
                kling30Standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKlingO3Pro? klingO3Pro = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.KlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO3Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKlingO3Pro)}");
                klingO3Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKlingO3Standard? klingO3Standard = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.KlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO3Standard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKlingO3Standard)}");
                klingO3Standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestSeedance2? seedance2 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Seedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestSeedance2)}");
                seedance2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestSeedance2Fast? seedance2Fast = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestSeedance2Fast)}");
                seedance2Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestSeedance2Mini? seedance2Mini = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Seedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Mini> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestSeedance2Mini)}");
                seedance2Mini = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestGeminiOmniFlash? geminiOmniFlash = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash)}");
                geminiOmniFlash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestGrokImagine15? grokImagine15 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.GrokImagine15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGrokImagine15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGrokImagine15)}");
                grokImagine15 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestWan3? wan3 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Wan3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestWan3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestWan3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestWan3)}");
                wan3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestGeminiOmniFlash11? geminiOmniFlash11 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash11)}");
                geminiOmniFlash11 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestWan3Prime? wan3Prime = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Wan3Prime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestWan3Prime), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestWan3Prime> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestWan3Prime)}");
                wan3Prime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestH3Max? h3Max = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.H3Max)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestH3Max), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestH3Max> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestH3Max)}");
                h3Max = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestSeedance25? seedance25 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Seedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestSeedance25)}");
                seedance25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestGrokImagine15Lite? grokImagine15Lite = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.GrokImagine15Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGrokImagine15Lite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGrokImagine15Lite)}");
                grokImagine15Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling4? kling4 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling4)}");
                kling4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestKling4Flash? kling4Flash = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Kling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling4Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestKling4Flash)}");
                kling4Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateTextToVideoRequestGeminiOmniFlash12? geminiOmniFlash12 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash12)}");
                geminiOmniFlash12 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateTextToVideoRequest(
                discriminator?.Model,
                gen45,

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

                kling4Flash,

                geminiOmniFlash12
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGen45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGen45?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGen45).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGen45(), typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVeo31(), typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVeo31Fast(), typeInfo);
            }
            else if (value.IsKlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO34k?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKlingO34k).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO34k(), typeInfo);
            }
            else if (value.IsHailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHailuo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestHailuo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3(), typeInfo);
            }
            else if (value.IsKling304k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling304k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling304k?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling304k).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling304k(), typeInfo);
            }
            else if (value.IsHappyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHappyhorse10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestHappyhorse10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHappyhorse10(), typeInfo);
            }
            else if (value.IsKling25TurboPro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling25TurboPro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling25TurboPro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling25TurboPro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling25TurboPro(), typeInfo);
            }
            else if (value.IsKling30Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling30Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling30Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling30Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling30Pro(), typeInfo);
            }
            else if (value.IsKling30Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling30Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling30Standard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling30Standard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling30Standard(), typeInfo);
            }
            else if (value.IsKlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO3Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKlingO3Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Pro(), typeInfo);
            }
            else if (value.IsKlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKlingO3Standard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKlingO3Standard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Standard(), typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2(), typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Fast(), typeInfo);
            }
            else if (value.IsSeedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Mini?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Mini(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash(), typeInfo);
            }
            else if (value.IsGrokImagine15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGrokImagine15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGrokImagine15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrokImagine15(), typeInfo);
            }
            else if (value.IsWan3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestWan3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestWan3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestWan3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWan3(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash11(), typeInfo);
            }
            else if (value.IsWan3Prime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestWan3Prime), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestWan3Prime?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestWan3Prime).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWan3Prime(), typeInfo);
            }
            else if (value.IsH3Max)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestH3Max), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestH3Max?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestH3Max).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickH3Max(), typeInfo);
            }
            else if (value.IsSeedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance25(), typeInfo);
            }
            else if (value.IsGrokImagine15Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGrokImagine15Lite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Lite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrokImagine15Lite(), typeInfo);
            }
            else if (value.IsKling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4(), typeInfo);
            }
            else if (value.IsKling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestKling4Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestKling4Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4Flash(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash12(), typeInfo);
            }
        }
    }
}
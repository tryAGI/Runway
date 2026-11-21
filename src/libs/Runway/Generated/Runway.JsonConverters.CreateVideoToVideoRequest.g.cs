#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateVideoToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVideoToVideoRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVideoToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateVideoToVideoRequestVariant1? aleph2 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Aleph2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestVariant1)}");
                aleph2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestKlingO34k? klingO34k = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.KlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO34k> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestKlingO34k)}");
                klingO34k = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestHailuo3? hailuo3 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Hailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestHailuo3)}");
                hailuo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestKlingO3Pro? klingO3Pro = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.KlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO3Pro> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestKlingO3Pro)}");
                klingO3Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestKlingO3Standard? klingO3Standard = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.KlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO3Standard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestKlingO3Standard)}");
                klingO3Standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestSeedance2? seedance2 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Seedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestSeedance2)}");
                seedance2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestSeedance2Fast? seedance2Fast = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Seedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestSeedance2Fast)}");
                seedance2Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestSeedance2Mini? seedance2Mini = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Seedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2Mini> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestSeedance2Mini)}");
                seedance2Mini = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? geminiOmniFlash = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash)}");
                geminiOmniFlash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? geminiOmniFlash11 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11)}");
                geminiOmniFlash11 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestSeedance25? seedance25 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Seedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestSeedance25)}");
                seedance25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestKling4? kling4 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Kling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKling4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestKling4)}");
                kling4 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? geminiOmniFlash12 = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12)}");
                geminiOmniFlash12 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestKling4Flash? kling4Flash = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Kling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKling4Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestKling4Flash)}");
                kling4Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestHailuo3Highspeed? hailuo3Highspeed = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Highspeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Highspeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3Highspeed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestHailuo3Highspeed)}");
                hailuo3Highspeed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestHailuo3Lite? hailuo3Lite = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3Lite> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestHailuo3Lite)}");
                hailuo3Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateVideoToVideoRequestSeedance25Flash? seedance25Flash = default;
            if (discriminator?.Model == global::Runway.CreateVideoToVideoRequestDiscriminatorModel.Seedance25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateVideoToVideoRequestSeedance25Flash)}");
                seedance25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateVideoToVideoRequest(
                discriminator?.Model,
                aleph2,

                klingO34k,

                hailuo3,

                klingO3Pro,

                klingO3Standard,

                seedance2,

                seedance2Fast,

                seedance2Mini,

                geminiOmniFlash,

                geminiOmniFlash11,

                seedance25,

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
            global::Runway.CreateVideoToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAleph2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAleph2(), typeInfo);
            }
            else if (value.IsKlingO34k)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO34k), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO34k?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestKlingO34k).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO34k(), typeInfo);
            }
            else if (value.IsHailuo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestHailuo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3(), typeInfo);
            }
            else if (value.IsKlingO3Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO3Pro), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO3Pro?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestKlingO3Pro).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Pro(), typeInfo);
            }
            else if (value.IsKlingO3Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKlingO3Standard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKlingO3Standard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestKlingO3Standard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKlingO3Standard(), typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2(), typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Fast(), typeInfo);
            }
            else if (value.IsSeedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2Mini?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance2Mini(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash11(), typeInfo);
            }
            else if (value.IsSeedance25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance25(), typeInfo);
            }
            else if (value.IsKling4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKling4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKling4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestKling4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4(), typeInfo);
            }
            else if (value.IsGeminiOmniFlash12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGeminiOmniFlash12(), typeInfo);
            }
            else if (value.IsKling4Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestKling4Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestKling4Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestKling4Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKling4Flash(), typeInfo);
            }
            else if (value.IsHailuo3Highspeed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Highspeed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3Highspeed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestHailuo3Highspeed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3Highspeed(), typeInfo);
            }
            else if (value.IsHailuo3Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Lite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestHailuo3Lite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestHailuo3Lite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHailuo3Lite(), typeInfo);
            }
            else if (value.IsSeedance25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeedance25Flash(), typeInfo);
            }
        }
    }
}
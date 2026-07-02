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
            global::Runway.CreateImageToVideoRequestHappyhorse10? happyhorse10 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Happyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHappyhorse10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestHappyhorse10)}");
                happyhorse10 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            global::Runway.CreateImageToVideoRequestVeo3? veo3 = default;
            if (discriminator?.Model == global::Runway.CreateImageToVideoRequestDiscriminatorModel.Veo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateImageToVideoRequestVeo3)}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateImageToVideoRequest(
                discriminator?.Model,
                gen45,

                gen4Turbo,

                veo31,

                veo31Fast,

                happyhorse10,

                seedance2,

                seedance2Fast,

                seedance2Mini,

                geminiOmniFlash,

                veo3
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen45!, typeInfo);
            }
            else if (value.IsGen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGen4Turbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGen4Turbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Turbo!, typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31!, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast!, typeInfo);
            }
            else if (value.IsHappyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestHappyhorse10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestHappyhorse10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Happyhorse10!, typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2!, typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2Fast!, typeInfo);
            }
            else if (value.IsSeedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestSeedance2Mini?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2Mini!, typeInfo);
            }
            else if (value.IsGeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestGeminiOmniFlash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiOmniFlash!, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateImageToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateImageToVideoRequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateImageToVideoRequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3!, typeInfo);
            }
        }
    }
}
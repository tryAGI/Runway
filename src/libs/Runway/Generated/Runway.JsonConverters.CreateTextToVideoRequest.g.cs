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
            global::Runway.CreateTextToVideoRequestHappyhorse10? happyhorse10 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Happyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHappyhorse10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestHappyhorse10)}");
                happyhorse10 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            global::Runway.CreateTextToVideoRequestVeo3? veo3 = default;
            if (discriminator?.Model == global::Runway.CreateTextToVideoRequestDiscriminatorModel.Veo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateTextToVideoRequestVeo3)}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateTextToVideoRequest(
                discriminator?.Model,
                gen45,

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
            global::Runway.CreateTextToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen45)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGen45), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGen45?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGen45).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen45!, typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31!, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast!, typeInfo);
            }
            else if (value.IsHappyhorse10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestHappyhorse10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestHappyhorse10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Happyhorse10!, typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2!, typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2Fast!, typeInfo);
            }
            else if (value.IsSeedance2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestSeedance2Mini?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2Mini!, typeInfo);
            }
            else if (value.IsGeminiOmniFlash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestGeminiOmniFlash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiOmniFlash!, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateTextToVideoRequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateTextToVideoRequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3!, typeInfo);
            }
        }
    }
}
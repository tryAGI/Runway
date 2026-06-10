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

            var __value = new global::Runway.CreateVideoToVideoRequest(
                discriminator?.Model,
                aleph2,

                seedance2,

                seedance2Fast
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aleph2!, typeInfo);
            }
            else if (value.IsSeedance2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2!, typeInfo);
            }
            else if (value.IsSeedance2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateVideoToVideoRequestSeedance2Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Seedance2Fast!, typeInfo);
            }
        }
    }
}
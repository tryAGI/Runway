#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class CreateRecipesMultiShotVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateRecipesMultiShotVideoRequest>
    {
        /// <inheritdoc />
        public override global::Runway.CreateRecipesMultiShotVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRecipesMultiShotVideoRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRecipesMultiShotVideoRequestVariant1? auto = default;
            if (discriminator?.Mode == global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRecipesMultiShotVideoRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1)}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2? custom = default;
            if (discriminator?.Mode == global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRecipesMultiShotVideoRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.CreateRecipesMultiShotVideoRequest(
                discriminator?.Mode,
                auto,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateRecipesMultiShotVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRecipesMultiShotVideoRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRecipesMultiShotVideoRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}
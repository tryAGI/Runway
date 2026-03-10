#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Request5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Request5>
    {
        /// <inheritdoc />
        public override global::Runway.Request5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Runway.RequestActTwo? actTwo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestActTwo).Name}");
                actTwo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Runway.Request5(
                actTwo
                );

            if (actTwo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestActTwo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestActTwo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Request5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsActTwo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestActTwo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestActTwo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestActTwo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ActTwo, typeInfo);
            }
        }
    }
}
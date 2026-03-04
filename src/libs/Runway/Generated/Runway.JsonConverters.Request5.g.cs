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
            global::Runway.RequestVariant15? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant15).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Runway.Request5(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant15).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Request5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}
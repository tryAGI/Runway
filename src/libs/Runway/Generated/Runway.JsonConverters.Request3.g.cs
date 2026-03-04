#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class Request3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Request3>
    {
        /// <inheritdoc />
        public override global::Runway.Request3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Runway.RequestGen4Aleph? gen4Aleph = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Aleph), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Aleph> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Aleph).Name}");
                gen4Aleph = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Runway.Request3(
                gen4Aleph
                );

            if (gen4Aleph != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Aleph), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Aleph> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Aleph).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Request3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4Aleph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Aleph), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Aleph?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Aleph).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Aleph, typeInfo);
            }
        }
    }
}
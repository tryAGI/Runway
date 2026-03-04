#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class RequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Request>
    {
        /// <inheritdoc />
        public override global::Runway.Request Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Runway.RequestVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVariant4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVariant5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Runway.Request(
                value1,
                value2,
                value3,
                value4,
                value5
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
        }
    }
}
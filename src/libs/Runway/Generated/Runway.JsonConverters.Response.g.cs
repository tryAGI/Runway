#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Response>
    {
        /// <inheritdoc />
        public override global::Runway.Response Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Runway.ResponseVariant1? pENDING = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant1).Name}");
                pENDING = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.ResponseVariant2? tHROTTLED = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant2).Name}");
                tHROTTLED = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.ResponseVariant3? cANCELLED = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant3).Name}");
                cANCELLED = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.ResponseVariant4? rUNNING = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant4).Name}");
                rUNNING = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.ResponseVariant5? fAILED = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant5).Name}");
                fAILED = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.ResponseVariant6? sUCCEEDED = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant6).Name}");
                sUCCEEDED = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Runway.Response(
                pENDING,
                tHROTTLED,
                cANCELLED,
                rUNNING,
                fAILED,
                sUCCEEDED
                );

            if (pENDING != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tHROTTLED != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (cANCELLED != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (rUNNING != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fAILED != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sUCCEEDED != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPENDING)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PENDING, typeInfo);
            }
            else if (value.IsTHROTTLED)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.THROTTLED, typeInfo);
            }
            else if (value.IsCANCELLED)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CANCELLED, typeInfo);
            }
            else if (value.IsRUNNING)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RUNNING, typeInfo);
            }
            else if (value.IsFAILED)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FAILED, typeInfo);
            }
            else if (value.IsSUCCEEDED)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.ResponseVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.ResponseVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.ResponseVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SUCCEEDED, typeInfo);
            }
        }
    }
}
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
            global::Runway.RequestGen4Turbo? gen4Turbo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Turbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Turbo).Name}");
                gen4Turbo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVeo31? veo31 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31).Name}");
                veo31 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestGen3aTurbo? gen3aTurbo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen3aTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen3aTurbo).Name}");
                gen3aTurbo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVeo31Fast? veo31Fast = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31Fast).Name}");
                veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Runway.RequestVeo3? veo3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo3).Name}");
                veo3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Runway.Request(
                gen4Turbo,

                veo31,

                gen3aTurbo,

                veo31Fast,

                veo3
                );

            if (gen4Turbo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Turbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Turbo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (veo31 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (gen3aTurbo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen3aTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen3aTurbo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (veo31Fast != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31Fast> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31Fast).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (veo3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen4Turbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen4Turbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Turbo, typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31, typeInfo);
            }
            else if (value.IsGen3aTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestGen3aTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestGen3aTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen3aTurbo, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.RequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.RequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3, typeInfo);
            }
        }
    }
}
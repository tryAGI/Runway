#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class ParametersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.ParametersItem>
    {
        /// <inheritdoc />
        public override global::Runway.ParametersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? @string = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? integer = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Integer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter)}");
                integer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? number = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? boolean = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? array = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? objectValue = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.ParametersItem(
                discriminator?.Type,
                @string,

                integer,

                number,

                boolean,

                array,

                objectValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.ParametersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String!, typeInfo);
            }
            else if (value.IsInteger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Integer!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean!, typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Array!, typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!, typeInfo);
            }
        }
    }
}
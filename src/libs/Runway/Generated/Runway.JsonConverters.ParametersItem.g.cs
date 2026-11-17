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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? @string = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? integer = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Integer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter)}");
                integer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? number = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? boolean = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? array = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? objectValue = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter)}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickString(), typeInfo);
            }
            else if (value.IsInteger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInteger(), typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNumber(), typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBoolean(), typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArray(), typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickObjectValue(), typeInfo);
            }
        }
    }
}
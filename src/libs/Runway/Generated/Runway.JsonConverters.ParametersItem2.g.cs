#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class ParametersItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.ParametersItem2>
    {
        /// <inheritdoc />
        public override global::Runway.ParametersItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? @string = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? integer = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Integer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter)}");
                integer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? number = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? boolean = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? array = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? objectValue = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.ParametersItem2(
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
            global::Runway.ParametersItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickString(), typeInfo);
            }
            else if (value.IsInteger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInteger(), typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNumber(), typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBoolean(), typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArray(), typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickObjectValue(), typeInfo);
            }
        }
    }
}
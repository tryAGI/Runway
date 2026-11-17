#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.ToolsItem>
    {
        /// <inheritdoc />
        public override global::Runway.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? clientEvent = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.ClientEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool)}");
                clientEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? backendRpc = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.BackendRpc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool)}");
                backendRpc = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.ToolsItem(
                discriminator?.Type,
                clientEvent,

                backendRpc
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClientEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClientEvent(), typeInfo);
            }
            else if (value.IsBackendRpc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBackendRpc(), typeInfo);
            }
        }
    }
}
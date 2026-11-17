#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.Integration>
    {
        /// <inheritdoc />
        public override global::Runway.Integration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? elevenlabs = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Elevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration)}");
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? livekit = default;
            if (discriminator?.Type == global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Livekit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration)}");
                livekit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.Integration(
                discriminator?.Type,
                elevenlabs,

                livekit
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.Integration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickElevenlabs(), typeInfo);
            }
            else if (value.IsLivekit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLivekit(), typeInfo);
            }
        }
    }
}
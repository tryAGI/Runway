#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class GetRealtimeSessionsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetRealtimeSessionsResponse>
    {
        /// <inheritdoc />
        public override global::Runway.GetRealtimeSessionsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetRealtimeSessionsResponseSessionNotReady? notReady = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.NotReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionNotReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionNotReady)}");
                notReady = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRealtimeSessionsResponseSessionReady? ready = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.Ready)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionReady)}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRealtimeSessionsResponseSessionRunning? running = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionRunning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionRunning)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRealtimeSessionsResponseSessionCompleted? completed = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRealtimeSessionsResponseSessionFailed? failed = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetRealtimeSessionsResponseSessionCancelled? cancelled = default;
            if (discriminator?.Status == global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus.Cancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCancelled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetRealtimeSessionsResponseSessionCancelled)}");
                cancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.GetRealtimeSessionsResponse(
                discriminator?.Status,
                notReady,

                ready,

                running,

                completed,

                failed,

                cancelled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetRealtimeSessionsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNotReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionNotReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotReady!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionRunning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running!, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCancelled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled!, typeInfo);
            }
        }
    }
}
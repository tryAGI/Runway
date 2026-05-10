#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class GetWorkflowInvocationsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetWorkflowInvocationsResponse>
    {
        /// <inheritdoc />
        public override global::Runway.GetWorkflowInvocationsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? pending = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? throttled = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Throttled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled)}");
                throttled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? cancelled = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Cancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled)}");
                cancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? running = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? failed = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? succeeded = default;
            if (discriminator?.Status == global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus.Succeeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded)}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Runway.GetWorkflowInvocationsResponse(
                discriminator?.Status,
                pending,

                throttled,

                cancelled,

                running,

                failed,

                succeeded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetWorkflowInvocationsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending!, typeInfo);
            }
            else if (value.IsThrottled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Throttled!, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled!, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
            else if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded!, typeInfo);
            }
        }
    }
}
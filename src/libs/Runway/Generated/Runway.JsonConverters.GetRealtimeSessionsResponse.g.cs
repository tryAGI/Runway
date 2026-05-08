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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("queued")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("expiresAt")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("sessionKey")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("createdAt")) __score3++;
            if (__jsonProps.Contains("duration")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("createdAt")) __score4++;
            if (__jsonProps.Contains("failure")) __score4++;
            if (__jsonProps.Contains("failureCode")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("createdAt")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Runway.GetRealtimeSessionsResponseSessionNotReady? notReady = default;
            global::Runway.GetRealtimeSessionsResponseSessionReady? ready = default;
            global::Runway.GetRealtimeSessionsResponseSessionRunning? running = default;
            global::Runway.GetRealtimeSessionsResponseSessionCompleted? completed = default;
            global::Runway.GetRealtimeSessionsResponseSessionFailed? failed = default;
            global::Runway.GetRealtimeSessionsResponseSessionCancelled? cancelled = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionNotReady> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady).Name}");
                        notReady = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionReady> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionReady).Name}");
                        ready = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionRunning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning).Name}");
                        running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted).Name}");
                        completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed).Name}");
                        failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCancelled> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled).Name}");
                        cancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (notReady == null && ready == null && running == null && completed == null && failed == null && cancelled == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionNotReady> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady).Name}");
                    notReady = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionReady> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionReady).Name}");
                    ready = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionRunning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning).Name}");
                    running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted).Name}");
                    completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed).Name}");
                    failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.GetRealtimeSessionsResponseSessionCancelled> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled).Name}");
                    cancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Runway.GetRealtimeSessionsResponse(
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
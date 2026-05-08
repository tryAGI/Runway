#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public class PatchVoicesResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PatchVoicesResponse>
    {
        /// <inheritdoc />
        public override global::Runway.PatchVoicesResponse Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("previewUrl")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("failureReason")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Runway.PatchVoicesResponseVoiceProcessing? processing = default;
            global::Runway.PatchVoicesResponseVoiceReady? ready = default;
            global::Runway.PatchVoicesResponseVoiceFailed? failed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceProcessing> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceProcessing).Name}");
                        processing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceReady> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceReady).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceFailed).Name}");
                        failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (processing == null && ready == null && failed == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceProcessing> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceProcessing).Name}");
                    processing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceReady> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceReady).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceFailed).Name}");
                    failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Runway.PatchVoicesResponse(
                processing,

                ready,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.PatchVoicesResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Runway.PatchVoicesResponseVoiceFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Runway.PatchVoicesResponseVoiceFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Runway.PatchVoicesResponseVoiceFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}
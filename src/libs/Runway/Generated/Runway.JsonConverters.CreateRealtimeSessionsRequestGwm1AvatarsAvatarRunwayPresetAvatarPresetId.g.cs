#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId>
    {
        /// <inheritdoc />
        public override global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetIdExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetIdExtensions.ToValueString(value));
        }
    }
}

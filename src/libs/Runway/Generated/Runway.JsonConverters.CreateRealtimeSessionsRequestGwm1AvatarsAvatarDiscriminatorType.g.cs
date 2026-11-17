#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType Read(
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
                        return global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorTypeExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}

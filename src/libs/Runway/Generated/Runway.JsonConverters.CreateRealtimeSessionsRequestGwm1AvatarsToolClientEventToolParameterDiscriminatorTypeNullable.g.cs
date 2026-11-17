#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType? Read(
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
                        return global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

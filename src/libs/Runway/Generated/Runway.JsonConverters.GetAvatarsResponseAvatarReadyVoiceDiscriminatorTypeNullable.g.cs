#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType? Read(
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
                        return global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

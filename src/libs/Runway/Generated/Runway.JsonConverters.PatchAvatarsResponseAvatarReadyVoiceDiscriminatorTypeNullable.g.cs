#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType? Read(
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
                        return global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

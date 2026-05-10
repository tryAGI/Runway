#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType Read(
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
                        return global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}

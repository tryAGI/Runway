#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? Read(
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
                        return global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToValueString(value.Value));
            }
        }
    }
}

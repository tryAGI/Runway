#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId>
    {
        /// <inheritdoc />
        public override global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId Read(
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
                        return global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToValueString(value));
        }
    }
}

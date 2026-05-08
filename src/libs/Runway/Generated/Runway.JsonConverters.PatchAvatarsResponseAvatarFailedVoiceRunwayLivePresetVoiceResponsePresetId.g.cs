#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId>
    {
        /// <inheritdoc />
        public override global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId Read(
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
                        return global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions.ToValueString(value));
        }
    }
}

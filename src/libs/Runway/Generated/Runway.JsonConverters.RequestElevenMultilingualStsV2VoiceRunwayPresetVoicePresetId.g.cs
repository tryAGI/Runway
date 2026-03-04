#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId>
    {
        /// <inheritdoc />
        public override global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId Read(
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
                        return global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdExtensions.ToValueString(value));
        }
    }
}

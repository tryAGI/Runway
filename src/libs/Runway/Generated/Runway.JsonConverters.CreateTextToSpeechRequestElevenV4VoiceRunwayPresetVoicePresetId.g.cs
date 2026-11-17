#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId Read(
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
                        return global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetIdExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetIdExtensions.ToValueString(value));
        }
    }
}

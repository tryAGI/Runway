#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice Read(
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
                        return global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoiceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoiceExtensions.ToValueString(value));
        }
    }
}

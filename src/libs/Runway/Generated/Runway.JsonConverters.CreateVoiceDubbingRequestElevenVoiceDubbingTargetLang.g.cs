#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang Read(
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
                        return global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangExtensions.ToValueString(value));
        }
    }
}

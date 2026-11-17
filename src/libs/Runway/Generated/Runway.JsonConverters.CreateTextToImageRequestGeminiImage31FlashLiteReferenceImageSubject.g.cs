#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject Read(
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
                        return global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubjectExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubjectExtensions.ToValueString(value));
        }
    }
}

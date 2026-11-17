#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePositionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition>
    {
        /// <inheritdoc />
        public override global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition Read(
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
                        return global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePositionExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePositionExtensions.ToValueString(value));
        }
    }
}

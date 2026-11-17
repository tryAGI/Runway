#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePositionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition Read(
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
                        return global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePositionExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePosition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImagePositionExtensions.ToValueString(value));
        }
    }
}

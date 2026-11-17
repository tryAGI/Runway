#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToVideoRequestGrokImagine15LiteRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio>
    {
        /// <inheritdoc />
        public override global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio Read(
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
                        return global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatioExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatioExtensions.ToValueString(value));
        }
    }
}

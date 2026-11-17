#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageToVideoRequestGeminiOmniFlash11RatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio>
    {
        /// <inheritdoc />
        public override global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio Read(
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
                        return global::Runway.CreateImageToVideoRequestGeminiOmniFlash11RatioExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash11Ratio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11RatioExtensions.ToValueString(value));
        }
    }
}

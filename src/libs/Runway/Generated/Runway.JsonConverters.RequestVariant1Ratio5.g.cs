#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestVariant1Ratio5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.RequestVariant1Ratio5>
    {
        /// <inheritdoc />
        public override global::Runway.RequestVariant1Ratio5 Read(
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
                        return global::Runway.RequestVariant1Ratio5Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.RequestVariant1Ratio5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.RequestVariant1Ratio5);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.RequestVariant1Ratio5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.RequestVariant1Ratio5Extensions.ToValueString(value));
        }
    }
}

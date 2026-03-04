#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestVariant3PromptImageVariant2ItemPositionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.RequestVariant3PromptImageVariant2ItemPosition>
    {
        /// <inheritdoc />
        public override global::Runway.RequestVariant3PromptImageVariant2ItemPosition Read(
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
                        return global::Runway.RequestVariant3PromptImageVariant2ItemPositionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.RequestVariant3PromptImageVariant2ItemPosition)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.RequestVariant3PromptImageVariant2ItemPosition);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.RequestVariant3PromptImageVariant2ItemPosition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.RequestVariant3PromptImageVariant2ItemPositionExtensions.ToValueString(value));
        }
    }
}

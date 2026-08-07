#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRoutersRequestsResponseDataItemEmptiedByItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?>
    {
        /// <inheritdoc />
        public override global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem? Read(
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
                        return global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItemExtensions.ToValueString(value.Value));
            }
        }
    }
}

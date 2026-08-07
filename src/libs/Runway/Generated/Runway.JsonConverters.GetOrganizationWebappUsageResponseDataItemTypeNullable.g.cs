#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationWebappUsageResponseDataItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetOrganizationWebappUsageResponseDataItemType?>
    {
        /// <inheritdoc />
        public override global::Runway.GetOrganizationWebappUsageResponseDataItemType? Read(
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
                        return global::Runway.GetOrganizationWebappUsageResponseDataItemTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetOrganizationWebappUsageResponseDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetOrganizationWebappUsageResponseDataItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetOrganizationWebappUsageResponseDataItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.GetOrganizationWebappUsageResponseDataItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

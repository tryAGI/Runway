#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationWebappMembersResponseDataItemRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.GetOrganizationWebappMembersResponseDataItemRole?>
    {
        /// <inheritdoc />
        public override global::Runway.GetOrganizationWebappMembersResponseDataItemRole? Read(
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
                        return global::Runway.GetOrganizationWebappMembersResponseDataItemRoleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.GetOrganizationWebappMembersResponseDataItemRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.GetOrganizationWebappMembersResponseDataItemRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.GetOrganizationWebappMembersResponseDataItemRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.GetOrganizationWebappMembersResponseDataItemRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}

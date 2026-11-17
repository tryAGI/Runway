#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType Read(
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
                        return global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotTypeExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotTypeExtensions.ToValueString(value));
        }
    }
}

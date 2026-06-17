#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?>
    {
        /// <inheritdoc />
        public override global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version? Read(
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
                        return global::Runway.CreateRecipesMultiShotVideoRequestVariant2VersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.CreateRecipesMultiShotVideoRequestVariant2VersionExtensions.ToValueString(value.Value));
            }
        }
    }
}

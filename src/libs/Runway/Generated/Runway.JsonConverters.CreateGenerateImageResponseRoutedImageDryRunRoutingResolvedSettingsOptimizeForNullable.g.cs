#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeForNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor?>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor? Read(
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
                        return global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeForExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeForExtensions.ToValueString(value.Value));
            }
        }
    }
}

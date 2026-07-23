#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerateAudioResponseVariant1EmptiedByItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem?>
    {
        /// <inheritdoc />
        public override global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem? Read(
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
                        return global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItemExtensions.ToValueString(value.Value));
            }
        }
    }
}

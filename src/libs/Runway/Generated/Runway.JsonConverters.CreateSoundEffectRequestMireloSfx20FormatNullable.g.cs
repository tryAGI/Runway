#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSoundEffectRequestMireloSfx20FormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateSoundEffectRequestMireloSfx20Format?>
    {
        /// <inheritdoc />
        public override global::Runway.CreateSoundEffectRequestMireloSfx20Format? Read(
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
                        return global::Runway.CreateSoundEffectRequestMireloSfx20FormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateSoundEffectRequestMireloSfx20Format)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateSoundEffectRequestMireloSfx20Format?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateSoundEffectRequestMireloSfx20Format? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Runway.CreateSoundEffectRequestMireloSfx20FormatExtensions.ToValueString(value.Value));
            }
        }
    }
}

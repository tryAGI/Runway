#nullable enable

namespace Runway.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoToVideoRequestGen4AlephRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Runway.CreateVideoToVideoRequestGen4AlephRatio>
    {
        /// <inheritdoc />
        public override global::Runway.CreateVideoToVideoRequestGen4AlephRatio Read(
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
                        return global::Runway.CreateVideoToVideoRequestGen4AlephRatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Runway.CreateVideoToVideoRequestGen4AlephRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Runway.CreateVideoToVideoRequestGen4AlephRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Runway.CreateVideoToVideoRequestGen4AlephRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Runway.CreateVideoToVideoRequestGen4AlephRatioExtensions.ToValueString(value));
        }
    }
}

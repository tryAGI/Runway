
#nullable enable

namespace Runway
{
    /// <summary>
    /// How much the model reasons about the prompt before generating. Defaults to medium.
    /// </summary>
    public enum CreateTextToImageRequestNanoBanana21ThinkingLevel
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestNanoBanana21ThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestNanoBanana21ThinkingLevel value)
        {
            return value switch
            {
                CreateTextToImageRequestNanoBanana21ThinkingLevel.High => "high",
                CreateTextToImageRequestNanoBanana21ThinkingLevel.Medium => "medium",
                CreateTextToImageRequestNanoBanana21ThinkingLevel.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestNanoBanana21ThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestNanoBanana21ThinkingLevel.High,
                "medium" => CreateTextToImageRequestNanoBanana21ThinkingLevel.Medium,
                "minimal" => CreateTextToImageRequestNanoBanana21ThinkingLevel.Minimal,
                _ => null,
            };
        }
    }
}
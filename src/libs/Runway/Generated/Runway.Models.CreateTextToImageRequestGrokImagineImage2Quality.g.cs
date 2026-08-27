
#nullable enable

namespace Runway
{
    /// <summary>
    /// How much rendering effort the model spends on the output. Defaults to `medium`; `low` is faster and costs 2 fewer credits per image.
    /// </summary>
    public enum CreateTextToImageRequestGrokImagineImage2Quality
    {
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGrokImagineImage2QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGrokImagineImage2Quality value)
        {
            return value switch
            {
                CreateTextToImageRequestGrokImagineImage2Quality.Low => "low",
                CreateTextToImageRequestGrokImagineImage2Quality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGrokImagineImage2Quality? ToEnum(string value)
        {
            return value switch
            {
                "low" => CreateTextToImageRequestGrokImagineImage2Quality.Low,
                "medium" => CreateTextToImageRequestGrokImagineImage2Quality.Medium,
                _ => null,
            };
        }
    }
}
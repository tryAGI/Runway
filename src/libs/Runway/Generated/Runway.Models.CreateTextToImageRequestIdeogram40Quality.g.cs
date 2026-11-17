
#nullable enable

namespace Runway
{
    /// <summary>
    /// How much rendering effort the model spends on each image. `low` costs 4 credits per image, `medium` 7 and `high` 11.
    /// </summary>
    public enum CreateTextToImageRequestIdeogram40Quality
    {
        /// <summary>
        ///
        /// </summary>
        High,
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
    public static class CreateTextToImageRequestIdeogram40QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestIdeogram40Quality value)
        {
            return value switch
            {
                CreateTextToImageRequestIdeogram40Quality.High => "high",
                CreateTextToImageRequestIdeogram40Quality.Low => "low",
                CreateTextToImageRequestIdeogram40Quality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestIdeogram40Quality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestIdeogram40Quality.High,
                "low" => CreateTextToImageRequestIdeogram40Quality.Low,
                "medium" => CreateTextToImageRequestIdeogram40Quality.Medium,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// How much rendering effort the model spends on each image. Defaults to `medium` (8 credits per image) when generating from reference images and `high` (25 credits) otherwise, including `preciseEdit`. `low` costs 4 credits and `very_low` 1; `very_low` requires reference images and is not available with `preciseEdit`.
    /// </summary>
    public enum CreateTextToImageRequestIdeogram45Quality
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
        /// <summary>
        ///
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestIdeogram45QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestIdeogram45Quality value)
        {
            return value switch
            {
                CreateTextToImageRequestIdeogram45Quality.High => "high",
                CreateTextToImageRequestIdeogram45Quality.Low => "low",
                CreateTextToImageRequestIdeogram45Quality.Medium => "medium",
                CreateTextToImageRequestIdeogram45Quality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestIdeogram45Quality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestIdeogram45Quality.High,
                "low" => CreateTextToImageRequestIdeogram45Quality.Low,
                "medium" => CreateTextToImageRequestIdeogram45Quality.Medium,
                "very_low" => CreateTextToImageRequestIdeogram45Quality.VeryLow,
                _ => null,
            };
        }
    }
}
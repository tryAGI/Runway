
#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
    /// </summary>
    public enum CreateTextToImageRequestGptImage26FlareQuality
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
    public static class CreateTextToImageRequestGptImage26FlareQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26FlareQuality value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26FlareQuality.High => "high",
                CreateTextToImageRequestGptImage26FlareQuality.Low => "low",
                CreateTextToImageRequestGptImage26FlareQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26FlareQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage26FlareQuality.High,
                "low" => CreateTextToImageRequestGptImage26FlareQuality.Low,
                "medium" => CreateTextToImageRequestGptImage26FlareQuality.Medium,
                _ => null,
            };
        }
    }
}
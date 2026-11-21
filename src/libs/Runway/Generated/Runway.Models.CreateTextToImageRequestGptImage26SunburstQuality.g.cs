
#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
    /// </summary>
    public enum CreateTextToImageRequestGptImage26SunburstQuality
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
    public static class CreateTextToImageRequestGptImage26SunburstQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26SunburstQuality value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26SunburstQuality.High => "high",
                CreateTextToImageRequestGptImage26SunburstQuality.Low => "low",
                CreateTextToImageRequestGptImage26SunburstQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26SunburstQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage26SunburstQuality.High,
                "low" => CreateTextToImageRequestGptImage26SunburstQuality.Low,
                "medium" => CreateTextToImageRequestGptImage26SunburstQuality.Medium,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
    /// </summary>
    public enum CreateTextToImageRequestGptImage25SunburstQuality
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
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage25SunburstQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage25SunburstQuality value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage25SunburstQuality.High => "high",
                CreateTextToImageRequestGptImage25SunburstQuality.Low => "low",
                CreateTextToImageRequestGptImage25SunburstQuality.Max => "max",
                CreateTextToImageRequestGptImage25SunburstQuality.Medium => "medium",
                CreateTextToImageRequestGptImage25SunburstQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage25SunburstQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage25SunburstQuality.High,
                "low" => CreateTextToImageRequestGptImage25SunburstQuality.Low,
                "max" => CreateTextToImageRequestGptImage25SunburstQuality.Max,
                "medium" => CreateTextToImageRequestGptImage25SunburstQuality.Medium,
                "xhigh" => CreateTextToImageRequestGptImage25SunburstQuality.Xhigh,
                _ => null,
            };
        }
    }
}
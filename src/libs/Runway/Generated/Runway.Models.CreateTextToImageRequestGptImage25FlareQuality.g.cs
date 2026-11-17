
#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
    /// </summary>
    public enum CreateTextToImageRequestGptImage25FlareQuality
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
    public static class CreateTextToImageRequestGptImage25FlareQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage25FlareQuality value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage25FlareQuality.High => "high",
                CreateTextToImageRequestGptImage25FlareQuality.Low => "low",
                CreateTextToImageRequestGptImage25FlareQuality.Max => "max",
                CreateTextToImageRequestGptImage25FlareQuality.Medium => "medium",
                CreateTextToImageRequestGptImage25FlareQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage25FlareQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage25FlareQuality.High,
                "low" => CreateTextToImageRequestGptImage25FlareQuality.Low,
                "max" => CreateTextToImageRequestGptImage25FlareQuality.Max,
                "medium" => CreateTextToImageRequestGptImage25FlareQuality.Medium,
                "xhigh" => CreateTextToImageRequestGptImage25FlareQuality.Xhigh,
                _ => null,
            };
        }
    }
}
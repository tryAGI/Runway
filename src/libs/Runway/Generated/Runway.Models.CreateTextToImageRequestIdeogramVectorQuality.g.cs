
#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher quality costs more credits.
    /// </summary>
    public enum CreateTextToImageRequestIdeogramVectorQuality
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
    public static class CreateTextToImageRequestIdeogramVectorQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestIdeogramVectorQuality value)
        {
            return value switch
            {
                CreateTextToImageRequestIdeogramVectorQuality.High => "high",
                CreateTextToImageRequestIdeogramVectorQuality.Low => "low",
                CreateTextToImageRequestIdeogramVectorQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestIdeogramVectorQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestIdeogramVectorQuality.High,
                "low" => CreateTextToImageRequestIdeogramVectorQuality.Low,
                "medium" => CreateTextToImageRequestIdeogramVectorQuality.Medium,
                _ => null,
            };
        }
    }
}
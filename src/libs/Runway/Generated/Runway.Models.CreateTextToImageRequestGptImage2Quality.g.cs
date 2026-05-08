
#nullable enable

namespace Runway
{
    /// <summary>
    /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
    /// </summary>
    public enum CreateTextToImageRequestGptImage2Quality
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
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
    public static class CreateTextToImageRequestGptImage2QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage2Quality value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage2Quality.Auto => "auto",
                CreateTextToImageRequestGptImage2Quality.High => "high",
                CreateTextToImageRequestGptImage2Quality.Low => "low",
                CreateTextToImageRequestGptImage2Quality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage2Quality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage2Quality.Auto,
                "high" => CreateTextToImageRequestGptImage2Quality.High,
                "low" => CreateTextToImageRequestGptImage2Quality.Low,
                "medium" => CreateTextToImageRequestGptImage2Quality.Medium,
                _ => null,
            };
        }
    }
}
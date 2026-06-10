
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold.Auto => "auto",
                CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold.Auto,
                "low" => CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
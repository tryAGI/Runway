
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold
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
    public static class CreateGenerateVideoRequestInputContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold.Auto => "auto",
                CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold.Auto,
                "low" => CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
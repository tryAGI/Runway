
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold
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
    public static class CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold.Auto => "auto",
                CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold.Auto,
                "low" => CreateVideoToVideoRequestAleph2ContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
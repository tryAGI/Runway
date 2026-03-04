
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum RequestVariant2ContentModerationPublicFigureThreshold
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
    public static class RequestVariant2ContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant2ContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                RequestVariant2ContentModerationPublicFigureThreshold.Auto => "auto",
                RequestVariant2ContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant2ContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestVariant2ContentModerationPublicFigureThreshold.Auto,
                "low" => RequestVariant2ContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum RequestVariant1ContentModerationPublicFigureThreshold3
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
    public static class RequestVariant1ContentModerationPublicFigureThreshold3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant1ContentModerationPublicFigureThreshold3 value)
        {
            return value switch
            {
                RequestVariant1ContentModerationPublicFigureThreshold3.Auto => "auto",
                RequestVariant1ContentModerationPublicFigureThreshold3.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant1ContentModerationPublicFigureThreshold3? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestVariant1ContentModerationPublicFigureThreshold3.Auto,
                "low" => RequestVariant1ContentModerationPublicFigureThreshold3.Low,
                _ => null,
            };
        }
    }
}
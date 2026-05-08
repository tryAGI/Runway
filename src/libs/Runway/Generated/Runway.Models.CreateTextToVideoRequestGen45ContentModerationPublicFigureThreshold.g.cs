
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold
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
    public static class CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold.Auto => "auto",
                CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold.Auto,
                "low" => CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
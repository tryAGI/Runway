
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold
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
    public static class CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold.Auto => "auto",
                CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold.Auto,
                "low" => CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
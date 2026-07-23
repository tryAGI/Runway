
#nullable enable

namespace Runway
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateGenerateImageRequestInputContentModerationPublicFigureThreshold
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
    public static class CreateGenerateImageRequestInputContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageRequestInputContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateGenerateImageRequestInputContentModerationPublicFigureThreshold.Auto => "auto",
                CreateGenerateImageRequestInputContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageRequestInputContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateGenerateImageRequestInputContentModerationPublicFigureThreshold.Auto,
                "low" => CreateGenerateImageRequestInputContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}
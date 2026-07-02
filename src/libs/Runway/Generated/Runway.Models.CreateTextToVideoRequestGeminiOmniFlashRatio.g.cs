
#nullable enable

namespace Runway
{
    /// <summary>
    /// The aspect ratio of the output video: `1280:720` (landscape) or `720:1280` (portrait).
    /// </summary>
    public enum CreateTextToVideoRequestGeminiOmniFlashRatio
    {
        /// <summary>
        /// `1280:720` (landscape) or `720:1280` (portrait).
        /// </summary>
        x1280_720,
        /// <summary>
        /// `1280:720` (landscape) or `720:1280` (portrait).
        /// </summary>
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestGeminiOmniFlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGeminiOmniFlashRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestGeminiOmniFlashRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestGeminiOmniFlashRatio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGeminiOmniFlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateTextToVideoRequestGeminiOmniFlashRatio.x1280_720,
                "720:1280" => CreateTextToVideoRequestGeminiOmniFlashRatio.x720_1280,
                _ => null,
            };
        }
    }
}
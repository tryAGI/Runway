
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution and aspect ratio of the output video.
    /// </summary>
    public enum CreateVideoToVideoRequestGeminiOmniFlash11Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
        /// <summary>
        ///
        /// </summary>
        x2160_3840,
        /// <summary>
        ///
        /// </summary>
        x360_640,
        /// <summary>
        ///
        /// </summary>
        x3840_2160,
        /// <summary>
        ///
        /// </summary>
        x640_360,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestGeminiOmniFlash11RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGeminiOmniFlash11Ratio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1080_1920 => "1080:1920",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1280_720 => "1280:720",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1920_1080 => "1920:1080",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x2160_3840 => "2160:3840",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x360_640 => "360:640",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x3840_2160 => "3840:2160",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x640_360 => "640:360",
                CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGeminiOmniFlash11Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1080_1920,
                "1280:720" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1280_720,
                "1920:1080" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x1920_1080,
                "2160:3840" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x2160_3840,
                "360:640" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x360_640,
                "3840:2160" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x3840_2160,
                "640:360" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x640_360,
                "720:1280" => CreateVideoToVideoRequestGeminiOmniFlash11Ratio.x720_1280,
                _ => null,
            };
        }
    }
}
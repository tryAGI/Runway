
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution and aspect ratio of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestGeminiOmniFlash12Ratio
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
    public static class CreateTextToVideoRequestGeminiOmniFlash12RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGeminiOmniFlash12Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1280_720 => "1280:720",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1920_1080 => "1920:1080",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x2160_3840 => "2160:3840",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x360_640 => "360:640",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x3840_2160 => "3840:2160",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x640_360 => "640:360",
                CreateTextToVideoRequestGeminiOmniFlash12Ratio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGeminiOmniFlash12Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1080_1920,
                "1280:720" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1280_720,
                "1920:1080" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x1920_1080,
                "2160:3840" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x2160_3840,
                "360:640" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x360_640,
                "3840:2160" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x3840_2160,
                "640:360" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x640_360,
                "720:1280" => CreateTextToVideoRequestGeminiOmniFlash12Ratio.x720_1280,
                _ => null,
            };
        }
    }
}
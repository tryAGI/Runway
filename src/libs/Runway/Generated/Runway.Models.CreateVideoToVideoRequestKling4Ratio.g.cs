
#nullable enable

namespace Runway
{
    /// <summary>
    /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
    /// </summary>
    public enum CreateVideoToVideoRequestKling4Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1440_1440,
        /// <summary>
        ///
        /// </summary>
        x1460_624,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
        /// <summary>
        ///
        /// </summary>
        x2200_940,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x940_940,
        /// <summary>
        /// 720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </summary>
        Auto1080p,
        /// <summary>
        /// 720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestKling4RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKling4Ratio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKling4Ratio.x1080_1920 => "1080:1920",
                CreateVideoToVideoRequestKling4Ratio.x1280_720 => "1280:720",
                CreateVideoToVideoRequestKling4Ratio.x1440_1440 => "1440:1440",
                CreateVideoToVideoRequestKling4Ratio.x1460_624 => "1460:624",
                CreateVideoToVideoRequestKling4Ratio.x1920_1080 => "1920:1080",
                CreateVideoToVideoRequestKling4Ratio.x2200_940 => "2200:940",
                CreateVideoToVideoRequestKling4Ratio.x720_1280 => "720:1280",
                CreateVideoToVideoRequestKling4Ratio.x940_940 => "940:940",
                CreateVideoToVideoRequestKling4Ratio.Auto1080p => "auto_1080p",
                CreateVideoToVideoRequestKling4Ratio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKling4Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateVideoToVideoRequestKling4Ratio.x1080_1920,
                "1280:720" => CreateVideoToVideoRequestKling4Ratio.x1280_720,
                "1440:1440" => CreateVideoToVideoRequestKling4Ratio.x1440_1440,
                "1460:624" => CreateVideoToVideoRequestKling4Ratio.x1460_624,
                "1920:1080" => CreateVideoToVideoRequestKling4Ratio.x1920_1080,
                "2200:940" => CreateVideoToVideoRequestKling4Ratio.x2200_940,
                "720:1280" => CreateVideoToVideoRequestKling4Ratio.x720_1280,
                "940:940" => CreateVideoToVideoRequestKling4Ratio.x940_940,
                "auto_1080p" => CreateVideoToVideoRequestKling4Ratio.Auto1080p,
                "auto_720p" => CreateVideoToVideoRequestKling4Ratio.Auto720p,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video, as `&lt;width&gt;:&lt;height&gt;`. Use `auto_480p`, `auto_720p`, or `auto_1080p` to let the model pick framing at that quality tier.
    /// </summary>
    public enum CreateTextToVideoRequestWan3Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1080,
        /// <summary>
        ///
        /// </summary>
        x1080_1440,
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
        x1440_1080,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
        /// <summary>
        ///
        /// </summary>
        x480_480,
        /// <summary>
        ///
        /// </summary>
        x480_640,
        /// <summary>
        ///
        /// </summary>
        x480_832,
        /// <summary>
        ///
        /// </summary>
        x640_480,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x720_720,
        /// <summary>
        ///
        /// </summary>
        x720_960,
        /// <summary>
        ///
        /// </summary>
        x832_480,
        /// <summary>
        ///
        /// </summary>
        x960_720,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_480p`, `auto_720p`, or `auto_1080p` to let the model pick framing at that quality tier.
        /// </summary>
        Auto1080p,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_480p`, `auto_720p`, or `auto_1080p` to let the model pick framing at that quality tier.
        /// </summary>
        Auto480p,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_480p`, `auto_720p`, or `auto_1080p` to let the model pick framing at that quality tier.
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestWan3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestWan3Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestWan3Ratio.x1080_1080 => "1080:1080",
                CreateTextToVideoRequestWan3Ratio.x1080_1440 => "1080:1440",
                CreateTextToVideoRequestWan3Ratio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestWan3Ratio.x1280_720 => "1280:720",
                CreateTextToVideoRequestWan3Ratio.x1440_1080 => "1440:1080",
                CreateTextToVideoRequestWan3Ratio.x1920_1080 => "1920:1080",
                CreateTextToVideoRequestWan3Ratio.x480_480 => "480:480",
                CreateTextToVideoRequestWan3Ratio.x480_640 => "480:640",
                CreateTextToVideoRequestWan3Ratio.x480_832 => "480:832",
                CreateTextToVideoRequestWan3Ratio.x640_480 => "640:480",
                CreateTextToVideoRequestWan3Ratio.x720_1280 => "720:1280",
                CreateTextToVideoRequestWan3Ratio.x720_720 => "720:720",
                CreateTextToVideoRequestWan3Ratio.x720_960 => "720:960",
                CreateTextToVideoRequestWan3Ratio.x832_480 => "832:480",
                CreateTextToVideoRequestWan3Ratio.x960_720 => "960:720",
                CreateTextToVideoRequestWan3Ratio.Auto1080p => "auto_1080p",
                CreateTextToVideoRequestWan3Ratio.Auto480p => "auto_480p",
                CreateTextToVideoRequestWan3Ratio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestWan3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1080" => CreateTextToVideoRequestWan3Ratio.x1080_1080,
                "1080:1440" => CreateTextToVideoRequestWan3Ratio.x1080_1440,
                "1080:1920" => CreateTextToVideoRequestWan3Ratio.x1080_1920,
                "1280:720" => CreateTextToVideoRequestWan3Ratio.x1280_720,
                "1440:1080" => CreateTextToVideoRequestWan3Ratio.x1440_1080,
                "1920:1080" => CreateTextToVideoRequestWan3Ratio.x1920_1080,
                "480:480" => CreateTextToVideoRequestWan3Ratio.x480_480,
                "480:640" => CreateTextToVideoRequestWan3Ratio.x480_640,
                "480:832" => CreateTextToVideoRequestWan3Ratio.x480_832,
                "640:480" => CreateTextToVideoRequestWan3Ratio.x640_480,
                "720:1280" => CreateTextToVideoRequestWan3Ratio.x720_1280,
                "720:720" => CreateTextToVideoRequestWan3Ratio.x720_720,
                "720:960" => CreateTextToVideoRequestWan3Ratio.x720_960,
                "832:480" => CreateTextToVideoRequestWan3Ratio.x832_480,
                "960:720" => CreateTextToVideoRequestWan3Ratio.x960_720,
                "auto_1080p" => CreateTextToVideoRequestWan3Ratio.Auto1080p,
                "auto_480p" => CreateTextToVideoRequestWan3Ratio.Auto480p,
                "auto_720p" => CreateTextToVideoRequestWan3Ratio.Auto720p,
                _ => null,
            };
        }
    }
}
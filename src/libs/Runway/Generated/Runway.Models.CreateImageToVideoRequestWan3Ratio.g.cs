
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video, as `&lt;width&gt;:&lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
    /// </summary>
    public enum CreateImageToVideoRequestWan3Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        ///
        /// </summary>
        x1104_832,
        /// <summary>
        ///
        /// </summary>
        x1248_1648,
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1440_1440,
        /// <summary>
        ///
        /// </summary>
        x1648_1248,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
        /// <summary>
        ///
        /// </summary>
        x480_832,
        /// <summary>
        ///
        /// </summary>
        x544_720,
        /// <summary>
        ///
        /// </summary>
        x624_624,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x720_544,
        /// <summary>
        ///
        /// </summary>
        x832_1104,
        /// <summary>
        ///
        /// </summary>
        x832_480,
        /// <summary>
        ///
        /// </summary>
        x960_960,
        /// <summary>
        /// &lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
        /// </summary>
        Auto1080p,
        /// <summary>
        /// &lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
        /// </summary>
        Auto480p,
        /// <summary>
        /// &lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestWan3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestWan3Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestWan3Ratio.x1080_1920 => "1080:1920",
                CreateImageToVideoRequestWan3Ratio.x1104_832 => "1104:832",
                CreateImageToVideoRequestWan3Ratio.x1248_1648 => "1248:1648",
                CreateImageToVideoRequestWan3Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestWan3Ratio.x1440_1440 => "1440:1440",
                CreateImageToVideoRequestWan3Ratio.x1648_1248 => "1648:1248",
                CreateImageToVideoRequestWan3Ratio.x1920_1080 => "1920:1080",
                CreateImageToVideoRequestWan3Ratio.x480_832 => "480:832",
                CreateImageToVideoRequestWan3Ratio.x544_720 => "544:720",
                CreateImageToVideoRequestWan3Ratio.x624_624 => "624:624",
                CreateImageToVideoRequestWan3Ratio.x720_1280 => "720:1280",
                CreateImageToVideoRequestWan3Ratio.x720_544 => "720:544",
                CreateImageToVideoRequestWan3Ratio.x832_1104 => "832:1104",
                CreateImageToVideoRequestWan3Ratio.x832_480 => "832:480",
                CreateImageToVideoRequestWan3Ratio.x960_960 => "960:960",
                CreateImageToVideoRequestWan3Ratio.Auto1080p => "auto_1080p",
                CreateImageToVideoRequestWan3Ratio.Auto480p => "auto_480p",
                CreateImageToVideoRequestWan3Ratio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestWan3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateImageToVideoRequestWan3Ratio.x1080_1920,
                "1104:832" => CreateImageToVideoRequestWan3Ratio.x1104_832,
                "1248:1648" => CreateImageToVideoRequestWan3Ratio.x1248_1648,
                "1280:720" => CreateImageToVideoRequestWan3Ratio.x1280_720,
                "1440:1440" => CreateImageToVideoRequestWan3Ratio.x1440_1440,
                "1648:1248" => CreateImageToVideoRequestWan3Ratio.x1648_1248,
                "1920:1080" => CreateImageToVideoRequestWan3Ratio.x1920_1080,
                "480:832" => CreateImageToVideoRequestWan3Ratio.x480_832,
                "544:720" => CreateImageToVideoRequestWan3Ratio.x544_720,
                "624:624" => CreateImageToVideoRequestWan3Ratio.x624_624,
                "720:1280" => CreateImageToVideoRequestWan3Ratio.x720_1280,
                "720:544" => CreateImageToVideoRequestWan3Ratio.x720_544,
                "832:1104" => CreateImageToVideoRequestWan3Ratio.x832_1104,
                "832:480" => CreateImageToVideoRequestWan3Ratio.x832_480,
                "960:960" => CreateImageToVideoRequestWan3Ratio.x960_960,
                "auto_1080p" => CreateImageToVideoRequestWan3Ratio.Auto1080p,
                "auto_480p" => CreateImageToVideoRequestWan3Ratio.Auto480p,
                "auto_720p" => CreateImageToVideoRequestWan3Ratio.Auto720p,
                _ => null,
            };
        }
    }
}
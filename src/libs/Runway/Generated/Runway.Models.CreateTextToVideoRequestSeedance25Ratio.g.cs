
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. Seedance 2.5 supports 480p, 720p, 1080p, and 4K. Defaults to `1280:720`.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance25Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        ///
        /// </summary>
        x1112_834,
        /// <summary>
        ///
        /// </summary>
        x1248_1664,
        /// <summary>
        /// 720`.
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1440_1440,
        /// <summary>
        ///
        /// </summary>
        x1470_630,
        /// <summary>
        ///
        /// </summary>
        x1664_1248,
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
        x2206_946,
        /// <summary>
        ///
        /// </summary>
        x2880_3840,
        /// <summary>
        ///
        /// </summary>
        x3840_1646,
        /// <summary>
        ///
        /// </summary>
        x3840_2160,
        /// <summary>
        ///
        /// </summary>
        x3840_2880,
        /// <summary>
        ///
        /// </summary>
        x3840_3840,
        /// <summary>
        ///
        /// </summary>
        x480_854,
        /// <summary>
        ///
        /// </summary>
        x560_752,
        /// <summary>
        ///
        /// </summary>
        x640_640,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x752_560,
        /// <summary>
        ///
        /// </summary>
        x834_1112,
        /// <summary>
        ///
        /// </summary>
        x854_480,
        /// <summary>
        ///
        /// </summary>
        x960_960,
        /// <summary>
        ///
        /// </summary>
        x992_432,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestSeedance25RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance25Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance25Ratio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestSeedance25Ratio.x1112_834 => "1112:834",
                CreateTextToVideoRequestSeedance25Ratio.x1248_1664 => "1248:1664",
                CreateTextToVideoRequestSeedance25Ratio.x1280_720 => "1280:720",
                CreateTextToVideoRequestSeedance25Ratio.x1440_1440 => "1440:1440",
                CreateTextToVideoRequestSeedance25Ratio.x1470_630 => "1470:630",
                CreateTextToVideoRequestSeedance25Ratio.x1664_1248 => "1664:1248",
                CreateTextToVideoRequestSeedance25Ratio.x1920_1080 => "1920:1080",
                CreateTextToVideoRequestSeedance25Ratio.x2160_3840 => "2160:3840",
                CreateTextToVideoRequestSeedance25Ratio.x2206_946 => "2206:946",
                CreateTextToVideoRequestSeedance25Ratio.x2880_3840 => "2880:3840",
                CreateTextToVideoRequestSeedance25Ratio.x3840_1646 => "3840:1646",
                CreateTextToVideoRequestSeedance25Ratio.x3840_2160 => "3840:2160",
                CreateTextToVideoRequestSeedance25Ratio.x3840_2880 => "3840:2880",
                CreateTextToVideoRequestSeedance25Ratio.x3840_3840 => "3840:3840",
                CreateTextToVideoRequestSeedance25Ratio.x480_854 => "480:854",
                CreateTextToVideoRequestSeedance25Ratio.x560_752 => "560:752",
                CreateTextToVideoRequestSeedance25Ratio.x640_640 => "640:640",
                CreateTextToVideoRequestSeedance25Ratio.x720_1280 => "720:1280",
                CreateTextToVideoRequestSeedance25Ratio.x752_560 => "752:560",
                CreateTextToVideoRequestSeedance25Ratio.x834_1112 => "834:1112",
                CreateTextToVideoRequestSeedance25Ratio.x854_480 => "854:480",
                CreateTextToVideoRequestSeedance25Ratio.x960_960 => "960:960",
                CreateTextToVideoRequestSeedance25Ratio.x992_432 => "992:432",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance25Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateTextToVideoRequestSeedance25Ratio.x1080_1920,
                "1112:834" => CreateTextToVideoRequestSeedance25Ratio.x1112_834,
                "1248:1664" => CreateTextToVideoRequestSeedance25Ratio.x1248_1664,
                "1280:720" => CreateTextToVideoRequestSeedance25Ratio.x1280_720,
                "1440:1440" => CreateTextToVideoRequestSeedance25Ratio.x1440_1440,
                "1470:630" => CreateTextToVideoRequestSeedance25Ratio.x1470_630,
                "1664:1248" => CreateTextToVideoRequestSeedance25Ratio.x1664_1248,
                "1920:1080" => CreateTextToVideoRequestSeedance25Ratio.x1920_1080,
                "2160:3840" => CreateTextToVideoRequestSeedance25Ratio.x2160_3840,
                "2206:946" => CreateTextToVideoRequestSeedance25Ratio.x2206_946,
                "2880:3840" => CreateTextToVideoRequestSeedance25Ratio.x2880_3840,
                "3840:1646" => CreateTextToVideoRequestSeedance25Ratio.x3840_1646,
                "3840:2160" => CreateTextToVideoRequestSeedance25Ratio.x3840_2160,
                "3840:2880" => CreateTextToVideoRequestSeedance25Ratio.x3840_2880,
                "3840:3840" => CreateTextToVideoRequestSeedance25Ratio.x3840_3840,
                "480:854" => CreateTextToVideoRequestSeedance25Ratio.x480_854,
                "560:752" => CreateTextToVideoRequestSeedance25Ratio.x560_752,
                "640:640" => CreateTextToVideoRequestSeedance25Ratio.x640_640,
                "720:1280" => CreateTextToVideoRequestSeedance25Ratio.x720_1280,
                "752:560" => CreateTextToVideoRequestSeedance25Ratio.x752_560,
                "834:1112" => CreateTextToVideoRequestSeedance25Ratio.x834_1112,
                "854:480" => CreateTextToVideoRequestSeedance25Ratio.x854_480,
                "960:960" => CreateTextToVideoRequestSeedance25Ratio.x960_960,
                "992:432" => CreateTextToVideoRequestSeedance25Ratio.x992_432,
                _ => null,
            };
        }
    }
}
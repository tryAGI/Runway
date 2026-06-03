
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateImageToVideoRequestSeedance2Ratio
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
        x2206_946,
        /// <summary>
        /// 
        /// </summary>
        x496_864,
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
        x864_496,
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
    public static class CreateImageToVideoRequestSeedance2RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSeedance2Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestSeedance2Ratio.x1080_1920 => "1080:1920",
                CreateImageToVideoRequestSeedance2Ratio.x1112_834 => "1112:834",
                CreateImageToVideoRequestSeedance2Ratio.x1248_1664 => "1248:1664",
                CreateImageToVideoRequestSeedance2Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestSeedance2Ratio.x1440_1440 => "1440:1440",
                CreateImageToVideoRequestSeedance2Ratio.x1470_630 => "1470:630",
                CreateImageToVideoRequestSeedance2Ratio.x1664_1248 => "1664:1248",
                CreateImageToVideoRequestSeedance2Ratio.x1920_1080 => "1920:1080",
                CreateImageToVideoRequestSeedance2Ratio.x2206_946 => "2206:946",
                CreateImageToVideoRequestSeedance2Ratio.x496_864 => "496:864",
                CreateImageToVideoRequestSeedance2Ratio.x560_752 => "560:752",
                CreateImageToVideoRequestSeedance2Ratio.x640_640 => "640:640",
                CreateImageToVideoRequestSeedance2Ratio.x720_1280 => "720:1280",
                CreateImageToVideoRequestSeedance2Ratio.x752_560 => "752:560",
                CreateImageToVideoRequestSeedance2Ratio.x834_1112 => "834:1112",
                CreateImageToVideoRequestSeedance2Ratio.x864_496 => "864:496",
                CreateImageToVideoRequestSeedance2Ratio.x960_960 => "960:960",
                CreateImageToVideoRequestSeedance2Ratio.x992_432 => "992:432",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSeedance2Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateImageToVideoRequestSeedance2Ratio.x1080_1920,
                "1112:834" => CreateImageToVideoRequestSeedance2Ratio.x1112_834,
                "1248:1664" => CreateImageToVideoRequestSeedance2Ratio.x1248_1664,
                "1280:720" => CreateImageToVideoRequestSeedance2Ratio.x1280_720,
                "1440:1440" => CreateImageToVideoRequestSeedance2Ratio.x1440_1440,
                "1470:630" => CreateImageToVideoRequestSeedance2Ratio.x1470_630,
                "1664:1248" => CreateImageToVideoRequestSeedance2Ratio.x1664_1248,
                "1920:1080" => CreateImageToVideoRequestSeedance2Ratio.x1920_1080,
                "2206:946" => CreateImageToVideoRequestSeedance2Ratio.x2206_946,
                "496:864" => CreateImageToVideoRequestSeedance2Ratio.x496_864,
                "560:752" => CreateImageToVideoRequestSeedance2Ratio.x560_752,
                "640:640" => CreateImageToVideoRequestSeedance2Ratio.x640_640,
                "720:1280" => CreateImageToVideoRequestSeedance2Ratio.x720_1280,
                "752:560" => CreateImageToVideoRequestSeedance2Ratio.x752_560,
                "834:1112" => CreateImageToVideoRequestSeedance2Ratio.x834_1112,
                "864:496" => CreateImageToVideoRequestSeedance2Ratio.x864_496,
                "960:960" => CreateImageToVideoRequestSeedance2Ratio.x960_960,
                "992:432" => CreateImageToVideoRequestSeedance2Ratio.x992_432,
                _ => null,
            };
        }
    }
}
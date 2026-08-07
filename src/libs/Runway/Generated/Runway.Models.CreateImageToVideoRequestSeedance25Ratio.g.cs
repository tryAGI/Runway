
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. Seedance 2.5 supports 480p and 720p only.
    /// </summary>
    public enum CreateImageToVideoRequestSeedance25Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1112_834,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1470_630,
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
    public static class CreateImageToVideoRequestSeedance25RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSeedance25Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestSeedance25Ratio.x1112_834 => "1112:834",
                CreateImageToVideoRequestSeedance25Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestSeedance25Ratio.x1470_630 => "1470:630",
                CreateImageToVideoRequestSeedance25Ratio.x480_854 => "480:854",
                CreateImageToVideoRequestSeedance25Ratio.x560_752 => "560:752",
                CreateImageToVideoRequestSeedance25Ratio.x640_640 => "640:640",
                CreateImageToVideoRequestSeedance25Ratio.x720_1280 => "720:1280",
                CreateImageToVideoRequestSeedance25Ratio.x752_560 => "752:560",
                CreateImageToVideoRequestSeedance25Ratio.x834_1112 => "834:1112",
                CreateImageToVideoRequestSeedance25Ratio.x854_480 => "854:480",
                CreateImageToVideoRequestSeedance25Ratio.x960_960 => "960:960",
                CreateImageToVideoRequestSeedance25Ratio.x992_432 => "992:432",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSeedance25Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1112:834" => CreateImageToVideoRequestSeedance25Ratio.x1112_834,
                "1280:720" => CreateImageToVideoRequestSeedance25Ratio.x1280_720,
                "1470:630" => CreateImageToVideoRequestSeedance25Ratio.x1470_630,
                "480:854" => CreateImageToVideoRequestSeedance25Ratio.x480_854,
                "560:752" => CreateImageToVideoRequestSeedance25Ratio.x560_752,
                "640:640" => CreateImageToVideoRequestSeedance25Ratio.x640_640,
                "720:1280" => CreateImageToVideoRequestSeedance25Ratio.x720_1280,
                "752:560" => CreateImageToVideoRequestSeedance25Ratio.x752_560,
                "834:1112" => CreateImageToVideoRequestSeedance25Ratio.x834_1112,
                "854:480" => CreateImageToVideoRequestSeedance25Ratio.x854_480,
                "960:960" => CreateImageToVideoRequestSeedance25Ratio.x960_960,
                "992:432" => CreateImageToVideoRequestSeedance25Ratio.x992_432,
                _ => null,
            };
        }
    }
}
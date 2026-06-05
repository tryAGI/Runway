
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. Seedance 2.0 Fast supports 480p and 720p only.
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance2FastRatio
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
    public static class CreateVideoToVideoRequestSeedance2FastRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance2FastRatio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance2FastRatio.x1112_834 => "1112:834",
                CreateVideoToVideoRequestSeedance2FastRatio.x1280_720 => "1280:720",
                CreateVideoToVideoRequestSeedance2FastRatio.x1470_630 => "1470:630",
                CreateVideoToVideoRequestSeedance2FastRatio.x496_864 => "496:864",
                CreateVideoToVideoRequestSeedance2FastRatio.x560_752 => "560:752",
                CreateVideoToVideoRequestSeedance2FastRatio.x640_640 => "640:640",
                CreateVideoToVideoRequestSeedance2FastRatio.x720_1280 => "720:1280",
                CreateVideoToVideoRequestSeedance2FastRatio.x752_560 => "752:560",
                CreateVideoToVideoRequestSeedance2FastRatio.x834_1112 => "834:1112",
                CreateVideoToVideoRequestSeedance2FastRatio.x864_496 => "864:496",
                CreateVideoToVideoRequestSeedance2FastRatio.x960_960 => "960:960",
                CreateVideoToVideoRequestSeedance2FastRatio.x992_432 => "992:432",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance2FastRatio? ToEnum(string value)
        {
            return value switch
            {
                "1112:834" => CreateVideoToVideoRequestSeedance2FastRatio.x1112_834,
                "1280:720" => CreateVideoToVideoRequestSeedance2FastRatio.x1280_720,
                "1470:630" => CreateVideoToVideoRequestSeedance2FastRatio.x1470_630,
                "496:864" => CreateVideoToVideoRequestSeedance2FastRatio.x496_864,
                "560:752" => CreateVideoToVideoRequestSeedance2FastRatio.x560_752,
                "640:640" => CreateVideoToVideoRequestSeedance2FastRatio.x640_640,
                "720:1280" => CreateVideoToVideoRequestSeedance2FastRatio.x720_1280,
                "752:560" => CreateVideoToVideoRequestSeedance2FastRatio.x752_560,
                "834:1112" => CreateVideoToVideoRequestSeedance2FastRatio.x834_1112,
                "864:496" => CreateVideoToVideoRequestSeedance2FastRatio.x864_496,
                "960:960" => CreateVideoToVideoRequestSeedance2FastRatio.x960_960,
                "992:432" => CreateVideoToVideoRequestSeedance2FastRatio.x992_432,
                _ => null,
            };
        }
    }
}
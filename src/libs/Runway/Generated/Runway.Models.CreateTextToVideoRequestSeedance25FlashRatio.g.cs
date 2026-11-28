
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. Seedance 2.5 Flash supports 480p and 720p. Defaults to `1280:720`.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance25FlashRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1112_834,
        /// <summary>
        /// 720`.
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
    public static class CreateTextToVideoRequestSeedance25FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance25FlashRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance25FlashRatio.x1112_834 => "1112:834",
                CreateTextToVideoRequestSeedance25FlashRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestSeedance25FlashRatio.x1470_630 => "1470:630",
                CreateTextToVideoRequestSeedance25FlashRatio.x480_854 => "480:854",
                CreateTextToVideoRequestSeedance25FlashRatio.x560_752 => "560:752",
                CreateTextToVideoRequestSeedance25FlashRatio.x640_640 => "640:640",
                CreateTextToVideoRequestSeedance25FlashRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestSeedance25FlashRatio.x752_560 => "752:560",
                CreateTextToVideoRequestSeedance25FlashRatio.x834_1112 => "834:1112",
                CreateTextToVideoRequestSeedance25FlashRatio.x854_480 => "854:480",
                CreateTextToVideoRequestSeedance25FlashRatio.x960_960 => "960:960",
                CreateTextToVideoRequestSeedance25FlashRatio.x992_432 => "992:432",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance25FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1112:834" => CreateTextToVideoRequestSeedance25FlashRatio.x1112_834,
                "1280:720" => CreateTextToVideoRequestSeedance25FlashRatio.x1280_720,
                "1470:630" => CreateTextToVideoRequestSeedance25FlashRatio.x1470_630,
                "480:854" => CreateTextToVideoRequestSeedance25FlashRatio.x480_854,
                "560:752" => CreateTextToVideoRequestSeedance25FlashRatio.x560_752,
                "640:640" => CreateTextToVideoRequestSeedance25FlashRatio.x640_640,
                "720:1280" => CreateTextToVideoRequestSeedance25FlashRatio.x720_1280,
                "752:560" => CreateTextToVideoRequestSeedance25FlashRatio.x752_560,
                "834:1112" => CreateTextToVideoRequestSeedance25FlashRatio.x834_1112,
                "854:480" => CreateTextToVideoRequestSeedance25FlashRatio.x854_480,
                "960:960" => CreateTextToVideoRequestSeedance25FlashRatio.x960_960,
                "992:432" => CreateTextToVideoRequestSeedance25FlashRatio.x992_432,
                _ => null,
            };
        }
    }
}
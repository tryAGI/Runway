
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output size, or auto_720p for adaptive framing. Legacy values 940:940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
    /// </summary>
    public enum CreateVideoToVideoRequestKling4FlashRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        /// 940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        x1460_624,
        /// <summary>
        /// 940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        x1464_628,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        /// 940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        x940_940,
        /// <summary>
        /// 940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        x960_960,
        /// <summary>
        /// 940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestKling4FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKling4FlashRatio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKling4FlashRatio.x1280_720 => "1280:720",
                CreateVideoToVideoRequestKling4FlashRatio.x1460_624 => "1460:624",
                CreateVideoToVideoRequestKling4FlashRatio.x1464_628 => "1464:628",
                CreateVideoToVideoRequestKling4FlashRatio.x720_1280 => "720:1280",
                CreateVideoToVideoRequestKling4FlashRatio.x940_940 => "940:940",
                CreateVideoToVideoRequestKling4FlashRatio.x960_960 => "960:960",
                CreateVideoToVideoRequestKling4FlashRatio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKling4FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateVideoToVideoRequestKling4FlashRatio.x1280_720,
                "1460:624" => CreateVideoToVideoRequestKling4FlashRatio.x1460_624,
                "1464:628" => CreateVideoToVideoRequestKling4FlashRatio.x1464_628,
                "720:1280" => CreateVideoToVideoRequestKling4FlashRatio.x720_1280,
                "940:940" => CreateVideoToVideoRequestKling4FlashRatio.x940_940,
                "960:960" => CreateVideoToVideoRequestKling4FlashRatio.x960_960,
                "auto_720p" => CreateVideoToVideoRequestKling4FlashRatio.Auto720p,
                _ => null,
            };
        }
    }
}
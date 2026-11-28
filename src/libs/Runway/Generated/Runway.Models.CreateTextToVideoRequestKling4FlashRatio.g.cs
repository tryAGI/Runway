
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output size, or auto_720p for adaptive framing. Legacy values 940:940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
    /// </summary>
    public enum CreateTextToVideoRequestKling4FlashRatio
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
    public static class CreateTextToVideoRequestKling4FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling4FlashRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling4FlashRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestKling4FlashRatio.x1460_624 => "1460:624",
                CreateTextToVideoRequestKling4FlashRatio.x1464_628 => "1464:628",
                CreateTextToVideoRequestKling4FlashRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestKling4FlashRatio.x940_940 => "940:940",
                CreateTextToVideoRequestKling4FlashRatio.x960_960 => "960:960",
                CreateTextToVideoRequestKling4FlashRatio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling4FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateTextToVideoRequestKling4FlashRatio.x1280_720,
                "1460:624" => CreateTextToVideoRequestKling4FlashRatio.x1460_624,
                "1464:628" => CreateTextToVideoRequestKling4FlashRatio.x1464_628,
                "720:1280" => CreateTextToVideoRequestKling4FlashRatio.x720_1280,
                "940:940" => CreateTextToVideoRequestKling4FlashRatio.x940_940,
                "960:960" => CreateTextToVideoRequestKling4FlashRatio.x960_960,
                "auto_720p" => CreateTextToVideoRequestKling4FlashRatio.Auto720p,
                _ => null,
            };
        }
    }
}
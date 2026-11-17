
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output quality tier. The video keeps the input media framing.
    /// </summary>
    public enum CreateVideoToVideoRequestKling4FlashRatio
    {
        /// <summary>
        ///
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
                "auto_720p" => CreateVideoToVideoRequestKling4FlashRatio.Auto720p,
                _ => null,
            };
        }
    }
}
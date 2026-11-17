
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output quality tier. The video keeps the input media framing.
    /// </summary>
    public enum CreateImageToVideoRequestKling4FlashRatio
    {
        /// <summary>
        ///
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestKling4FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKling4FlashRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestKling4FlashRatio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKling4FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "auto_720p" => CreateImageToVideoRequestKling4FlashRatio.Auto720p,
                _ => null,
            };
        }
    }
}
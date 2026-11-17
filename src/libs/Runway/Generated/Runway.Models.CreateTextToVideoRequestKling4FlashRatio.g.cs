
#nullable enable

namespace Runway
{
    /// <summary>
    /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
    /// </summary>
    public enum CreateTextToVideoRequestKling4FlashRatio
    {
        /// <summary>
        /// 720` or `auto_720p` / `auto_1080p` for adaptive framing.
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
                "auto_720p" => CreateTextToVideoRequestKling4FlashRatio.Auto720p,
                _ => null,
            };
        }
    }
}
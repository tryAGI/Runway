
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. The output keeps the input image's aspect ratio. `auto_1080p` is rendered at 720p and upscaled.
    /// </summary>
    public enum CreateImageToVideoRequestGrokImagine15LiteRatio
    {
        /// <summary>
        ///
        /// </summary>
        Auto1080p,
        /// <summary>
        ///
        /// </summary>
        Auto480p,
        /// <summary>
        ///
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGrokImagine15LiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGrokImagine15LiteRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestGrokImagine15LiteRatio.Auto1080p => "auto_1080p",
                CreateImageToVideoRequestGrokImagine15LiteRatio.Auto480p => "auto_480p",
                CreateImageToVideoRequestGrokImagine15LiteRatio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGrokImagine15LiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "auto_1080p" => CreateImageToVideoRequestGrokImagine15LiteRatio.Auto1080p,
                "auto_480p" => CreateImageToVideoRequestGrokImagine15LiteRatio.Auto480p,
                "auto_720p" => CreateImageToVideoRequestGrokImagine15LiteRatio.Auto720p,
                _ => null,
            };
        }
    }
}
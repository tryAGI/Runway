
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. Output aspect ratio follows the input image.
    /// </summary>
    public enum CreateImageToVideoRequestGrokImagine15Resolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGrokImagine15ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGrokImagine15Resolution value)
        {
            return value switch
            {
                CreateImageToVideoRequestGrokImagine15Resolution.x1080p => "1080p",
                CreateImageToVideoRequestGrokImagine15Resolution.x480p => "480p",
                CreateImageToVideoRequestGrokImagine15Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGrokImagine15Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => CreateImageToVideoRequestGrokImagine15Resolution.x1080p,
                "480p" => CreateImageToVideoRequestGrokImagine15Resolution.x480p,
                "720p" => CreateImageToVideoRequestGrokImagine15Resolution.x720p,
                _ => null,
            };
        }
    }
}
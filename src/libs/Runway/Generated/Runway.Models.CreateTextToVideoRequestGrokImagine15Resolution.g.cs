
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. Requests with image references are capped at 720p.
    /// </summary>
    public enum CreateTextToVideoRequestGrokImagine15Resolution
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
    public static class CreateTextToVideoRequestGrokImagine15ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGrokImagine15Resolution value)
        {
            return value switch
            {
                CreateTextToVideoRequestGrokImagine15Resolution.x1080p => "1080p",
                CreateTextToVideoRequestGrokImagine15Resolution.x480p => "480p",
                CreateTextToVideoRequestGrokImagine15Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGrokImagine15Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => CreateTextToVideoRequestGrokImagine15Resolution.x1080p,
                "480p" => CreateTextToVideoRequestGrokImagine15Resolution.x480p,
                "720p" => CreateTextToVideoRequestGrokImagine15Resolution.x720p,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution when editing or extending a video. In reference mode, use ratio instead.
    /// </summary>
    public enum CreateVideoToVideoRequestGeminiOmniFlash12Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x360p,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestGeminiOmniFlash12ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGeminiOmniFlash12Resolution value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x1080p => "1080p",
                CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x360p => "360p",
                CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x4k => "4k",
                CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGeminiOmniFlash12Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x1080p,
                "360p" => CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x360p,
                "4k" => CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x4k,
                "720p" => CreateVideoToVideoRequestGeminiOmniFlash12Resolution.x720p,
                _ => null,
            };
        }
    }
}
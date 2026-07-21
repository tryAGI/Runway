
#nullable enable

namespace Runway
{
    /// <summary>
    /// Desired output resolution tier. Models that do not support the requested tier are excluded.
    /// </summary>
    public enum CreateGenerateVideoRequestInputResolution
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
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateVideoRequestInputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoRequestInputResolution value)
        {
            return value switch
            {
                CreateGenerateVideoRequestInputResolution.x1080p => "1080p",
                CreateGenerateVideoRequestInputResolution.x480p => "480p",
                CreateGenerateVideoRequestInputResolution.x4k => "4k",
                CreateGenerateVideoRequestInputResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoRequestInputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => CreateGenerateVideoRequestInputResolution.x1080p,
                "480p" => CreateGenerateVideoRequestInputResolution.x480p,
                "4k" => CreateGenerateVideoRequestInputResolution.x4k,
                "720p" => CreateGenerateVideoRequestInputResolution.x720p,
                _ => null,
            };
        }
    }
}
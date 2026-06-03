
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output quality tier. Output aspect ratio follows the input image.
    /// </summary>
    public enum CreateImageToVideoRequestHappyhorse10Resolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestHappyhorse10ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHappyhorse10Resolution value)
        {
            return value switch
            {
                CreateImageToVideoRequestHappyhorse10Resolution.x1080p => "1080P",
                CreateImageToVideoRequestHappyhorse10Resolution.x720p => "720P",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHappyhorse10Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080P" => CreateImageToVideoRequestHappyhorse10Resolution.x1080p,
                "720P" => CreateImageToVideoRequestHappyhorse10Resolution.x720p,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Target output resolution from 720p to 4k. Defaults to `2k`.
    /// </summary>
    public enum CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
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
    public static class CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution value)
        {
            return value switch
            {
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x1k => "1k",
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x2k => "2k",
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x4k => "4k",
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x1k,
                "2k" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x2k,
                "4k" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x4k,
                "720p" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution.x720p,
                _ => null,
            };
        }
    }
}
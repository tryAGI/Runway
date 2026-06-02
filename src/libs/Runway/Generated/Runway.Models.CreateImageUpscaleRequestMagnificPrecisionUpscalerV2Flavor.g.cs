
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optimization preset: `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
    /// </summary>
    public enum CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor
    {
        /// <summary>
        /// `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
        /// </summary>
        Photo,
        /// <summary>
        /// `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
        /// </summary>
        PhotoDenoiser,
        /// <summary>
        /// `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
        /// </summary>
        Sublime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor value)
        {
            return value switch
            {
                CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.Photo => "photo",
                CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.PhotoDenoiser => "photo_denoiser",
                CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.Sublime => "sublime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor? ToEnum(string value)
        {
            return value switch
            {
                "photo" => CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.Photo,
                "photo_denoiser" => CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.PhotoDenoiser,
                "sublime" => CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor.Sublime,
                _ => null,
            };
        }
    }
}
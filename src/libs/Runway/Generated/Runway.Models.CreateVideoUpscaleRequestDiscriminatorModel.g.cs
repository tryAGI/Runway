
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoUpscaleRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        MagnificVideoUpscalerCreative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoUpscaleRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoUpscaleRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVideoUpscaleRequestDiscriminatorModel.MagnificVideoUpscalerCreative => "magnific_video_upscaler_creative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoUpscaleRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "magnific_video_upscaler_creative" => CreateVideoUpscaleRequestDiscriminatorModel.MagnificVideoUpscalerCreative,
                _ => null,
            };
        }
    }
}
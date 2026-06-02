
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageUpscaleRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        MagnificPrecisionUpscalerV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageUpscaleRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageUpscaleRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateImageUpscaleRequestDiscriminatorModel.MagnificPrecisionUpscalerV2 => "magnific_precision_upscaler_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageUpscaleRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "magnific_precision_upscaler_v2" => CreateImageUpscaleRequestDiscriminatorModel.MagnificPrecisionUpscalerV2,
                _ => null,
            };
        }
    }
}
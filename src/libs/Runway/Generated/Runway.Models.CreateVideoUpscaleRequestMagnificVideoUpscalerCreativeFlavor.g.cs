
#nullable enable

namespace Runway
{
    /// <summary>
    /// Processing style: `vivid` for enhanced color and detail, `natural` for faithful reproduction.
    /// </summary>
    public enum CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor
    {
        /// <summary>
        /// `vivid` for enhanced color and detail, `natural` for faithful reproduction.
        /// </summary>
        Natural,
        /// <summary>
        /// `vivid` for enhanced color and detail, `natural` for faithful reproduction.
        /// </summary>
        Vivid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor value)
        {
            return value switch
            {
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor.Natural => "natural",
                CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor.Vivid => "vivid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor? ToEnum(string value)
        {
            return value switch
            {
                "natural" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor.Natural,
                "vivid" => CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor.Vivid,
                _ => null,
            };
        }
    }
}
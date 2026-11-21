
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output resolution tier. Defaults to auto, which adapts to the input image. The base image and layers preserve their respective aspect ratios.
    /// </summary>
    public enum CreateTextToImageRequestSeedream55LayersResolution
    {
        /// <summary>
        ///
        /// </summary>
        x15k,
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
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream55LayersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream55LayersResolution value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream55LayersResolution.x15k => "1.5k",
                CreateTextToImageRequestSeedream55LayersResolution.x1k => "1k",
                CreateTextToImageRequestSeedream55LayersResolution.x2k => "2k",
                CreateTextToImageRequestSeedream55LayersResolution.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream55LayersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1.5k" => CreateTextToImageRequestSeedream55LayersResolution.x15k,
                "1k" => CreateTextToImageRequestSeedream55LayersResolution.x1k,
                "2k" => CreateTextToImageRequestSeedream55LayersResolution.x2k,
                "auto" => CreateTextToImageRequestSeedream55LayersResolution.Auto,
                _ => null,
            };
        }
    }
}
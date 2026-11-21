
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output resolution tier. Defaults to auto, which adapts to the input image. The base image and layers preserve their respective aspect ratios.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5ProLayersResolution
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
    public static class CreateTextToImageRequestSeedream5ProLayersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5ProLayersResolution value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5ProLayersResolution.x15k => "1.5k",
                CreateTextToImageRequestSeedream5ProLayersResolution.x1k => "1k",
                CreateTextToImageRequestSeedream5ProLayersResolution.x2k => "2k",
                CreateTextToImageRequestSeedream5ProLayersResolution.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5ProLayersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1.5k" => CreateTextToImageRequestSeedream5ProLayersResolution.x15k,
                "1k" => CreateTextToImageRequestSeedream5ProLayersResolution.x1k,
                "2k" => CreateTextToImageRequestSeedream5ProLayersResolution.x2k,
                "auto" => CreateTextToImageRequestSeedream5ProLayersResolution.Auto,
                _ => null,
            };
        }
    }
}
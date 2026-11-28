
#nullable enable

namespace Runway
{
    /// <summary>
    /// Whether the image has a transparent or an opaque background. A transparent background needs the png output format. Omit to let the model decide from the prompt.
    /// </summary>
    public enum CreateTextToImageRequestSeedream55Background
    {
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream55BackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream55Background value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream55Background.Opaque => "opaque",
                CreateTextToImageRequestSeedream55Background.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream55Background? ToEnum(string value)
        {
            return value switch
            {
                "opaque" => CreateTextToImageRequestSeedream55Background.Opaque,
                "transparent" => CreateTextToImageRequestSeedream55Background.Transparent,
                _ => null,
            };
        }
    }
}
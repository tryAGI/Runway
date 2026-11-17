
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. MiniMax H3 Max supports 480p and 768p.<br/>
    /// Example: 768p
    /// </summary>
    public enum CreateImageToVideoRequestH3MaxResolution
    {
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x768p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestH3MaxResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestH3MaxResolution value)
        {
            return value switch
            {
                CreateImageToVideoRequestH3MaxResolution.x480p => "480p",
                CreateImageToVideoRequestH3MaxResolution.x768p => "768p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestH3MaxResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreateImageToVideoRequestH3MaxResolution.x480p,
                "768p" => CreateImageToVideoRequestH3MaxResolution.x768p,
                _ => null,
            };
        }
    }
}
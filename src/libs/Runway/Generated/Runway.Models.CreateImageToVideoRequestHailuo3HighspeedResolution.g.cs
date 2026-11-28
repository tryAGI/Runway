
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output video resolution.<br/>
    /// Default Value: 768p
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3HighspeedResolution
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
    public static class CreateImageToVideoRequestHailuo3HighspeedResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3HighspeedResolution value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3HighspeedResolution.x480p => "480p",
                CreateImageToVideoRequestHailuo3HighspeedResolution.x768p => "768p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3HighspeedResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreateImageToVideoRequestHailuo3HighspeedResolution.x480p,
                "768p" => CreateImageToVideoRequestHailuo3HighspeedResolution.x768p,
                _ => null,
            };
        }
    }
}
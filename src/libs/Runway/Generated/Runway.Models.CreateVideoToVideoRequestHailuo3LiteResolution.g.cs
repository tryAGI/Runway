
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output video resolution.<br/>
    /// Default Value: 768p
    /// </summary>
    public enum CreateVideoToVideoRequestHailuo3LiteResolution
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
    public static class CreateVideoToVideoRequestHailuo3LiteResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestHailuo3LiteResolution value)
        {
            return value switch
            {
                CreateVideoToVideoRequestHailuo3LiteResolution.x480p => "480p",
                CreateVideoToVideoRequestHailuo3LiteResolution.x768p => "768p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestHailuo3LiteResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreateVideoToVideoRequestHailuo3LiteResolution.x480p,
                "768p" => CreateVideoToVideoRequestHailuo3LiteResolution.x768p,
                _ => null,
            };
        }
    }
}
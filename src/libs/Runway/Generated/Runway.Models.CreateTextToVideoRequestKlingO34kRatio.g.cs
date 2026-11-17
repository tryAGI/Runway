
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO34kRatio
    {
        /// <summary>
        ///
        /// </summary>
        x2160_3840,
        /// <summary>
        ///
        /// </summary>
        x2880_2880,
        /// <summary>
        ///
        /// </summary>
        x3840_2160,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestKlingO34kRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO34kRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO34kRatio.x2160_3840 => "2160:3840",
                CreateTextToVideoRequestKlingO34kRatio.x2880_2880 => "2880:2880",
                CreateTextToVideoRequestKlingO34kRatio.x3840_2160 => "3840:2160",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO34kRatio? ToEnum(string value)
        {
            return value switch
            {
                "2160:3840" => CreateTextToVideoRequestKlingO34kRatio.x2160_3840,
                "2880:2880" => CreateTextToVideoRequestKlingO34kRatio.x2880_2880,
                "3840:2160" => CreateTextToVideoRequestKlingO34kRatio.x3840_2160,
                _ => null,
            };
        }
    }
}
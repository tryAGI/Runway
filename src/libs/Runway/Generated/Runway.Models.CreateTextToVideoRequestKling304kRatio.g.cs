
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestKling304kRatio
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
    public static class CreateTextToVideoRequestKling304kRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling304kRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling304kRatio.x2160_3840 => "2160:3840",
                CreateTextToVideoRequestKling304kRatio.x2880_2880 => "2880:2880",
                CreateTextToVideoRequestKling304kRatio.x3840_2160 => "3840:2160",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling304kRatio? ToEnum(string value)
        {
            return value switch
            {
                "2160:3840" => CreateTextToVideoRequestKling304kRatio.x2160_3840,
                "2880:2880" => CreateTextToVideoRequestKling304kRatio.x2880_2880,
                "3840:2160" => CreateTextToVideoRequestKling304kRatio.x3840_2160,
                _ => null,
            };
        }
    }
}
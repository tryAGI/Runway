
#nullable enable

namespace Runway
{
    /// <summary>
    /// Bitrate of the output video. `high` keeps more detail with fewer compression artifacts, at a larger file size. Defaults to `standard`.<br/>
    /// Default Value: standard
    /// </summary>
    public enum CreateTextToVideoRequestSeedance2MiniBitrate
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestSeedance2MiniBitrateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance2MiniBitrate value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance2MiniBitrate.High => "high",
                CreateTextToVideoRequestSeedance2MiniBitrate.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2MiniBitrate? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToVideoRequestSeedance2MiniBitrate.High,
                "standard" => CreateTextToVideoRequestSeedance2MiniBitrate.Standard,
                _ => null,
            };
        }
    }
}
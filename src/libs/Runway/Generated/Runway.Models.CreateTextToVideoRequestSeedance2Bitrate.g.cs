
#nullable enable

namespace Runway
{
    /// <summary>
    /// Bitrate of the output video. `high` keeps more detail with fewer compression artifacts, at a larger file size. Defaults to `standard`.<br/>
    /// Default Value: standard
    /// </summary>
    public enum CreateTextToVideoRequestSeedance2Bitrate
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
    public static class CreateTextToVideoRequestSeedance2BitrateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance2Bitrate value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance2Bitrate.High => "high",
                CreateTextToVideoRequestSeedance2Bitrate.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2Bitrate? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToVideoRequestSeedance2Bitrate.High,
                "standard" => CreateTextToVideoRequestSeedance2Bitrate.Standard,
                _ => null,
            };
        }
    }
}
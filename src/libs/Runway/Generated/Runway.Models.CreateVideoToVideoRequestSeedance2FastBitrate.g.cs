
#nullable enable

namespace Runway
{
    /// <summary>
    /// Bitrate of the output video. `high` keeps more detail with fewer compression artifacts, at a larger file size. Defaults to `standard`.<br/>
    /// Default Value: standard
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance2FastBitrate
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
    public static class CreateVideoToVideoRequestSeedance2FastBitrateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance2FastBitrate value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance2FastBitrate.High => "high",
                CreateVideoToVideoRequestSeedance2FastBitrate.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance2FastBitrate? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateVideoToVideoRequestSeedance2FastBitrate.High,
                "standard" => CreateVideoToVideoRequestSeedance2FastBitrate.Standard,
                _ => null,
            };
        }
    }
}
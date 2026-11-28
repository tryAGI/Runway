
#nullable enable

namespace Runway
{
    /// <summary>
    /// Bitrate of the output video. `high` keeps more detail with fewer compression artifacts, at a larger file size. Defaults to `standard`.<br/>
    /// Default Value: standard
    /// </summary>
    public enum CreateImageToVideoRequestSeedance2FastBitrate
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
    public static class CreateImageToVideoRequestSeedance2FastBitrateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSeedance2FastBitrate value)
        {
            return value switch
            {
                CreateImageToVideoRequestSeedance2FastBitrate.High => "high",
                CreateImageToVideoRequestSeedance2FastBitrate.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSeedance2FastBitrate? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateImageToVideoRequestSeedance2FastBitrate.High,
                "standard" => CreateImageToVideoRequestSeedance2FastBitrate.Standard,
                _ => null,
            };
        }
    }
}
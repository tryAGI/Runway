
#nullable enable

namespace Runway
{
    /// <summary>
    /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames (plus a separate .wav artifact when the output has audio). Non-mp4 formats incur an additional surcharge of 5 credits per second of output.
    /// </summary>
    public enum CreateVideoToVideoRequestVariant1OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        PngSequence,
        /// <summary>
        /// 
        /// </summary>
        Prores,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestVariant1OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestVariant1OutputFormat value)
        {
            return value switch
            {
                CreateVideoToVideoRequestVariant1OutputFormat.Mp4 => "mp4",
                CreateVideoToVideoRequestVariant1OutputFormat.PngSequence => "png_sequence",
                CreateVideoToVideoRequestVariant1OutputFormat.Prores => "prores",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestVariant1OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp4" => CreateVideoToVideoRequestVariant1OutputFormat.Mp4,
                "png_sequence" => CreateVideoToVideoRequestVariant1OutputFormat.PngSequence,
                "prores" => CreateVideoToVideoRequestVariant1OutputFormat.Prores,
                _ => null,
            };
        }
    }
}
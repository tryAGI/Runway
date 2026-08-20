
#nullable enable

namespace Runway
{
    /// <summary>
    /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames. `sdr_rec709_10bit` returns a 10-bit Rec.709 HEVC .mp4 for SDR grading pipelines. Non-mp4 formats incur an additional surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
    /// </summary>
    public enum CreateVideoToVideoRequestVariant1OutputFormat
    {
        /// <summary>
        /// 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Mp4,
        /// <summary>
        /// 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        PngSequence,
        /// <summary>
        /// 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Prores,
        /// <summary>
        /// 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        SdrRec70910bit,
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
                CreateVideoToVideoRequestVariant1OutputFormat.SdrRec70910bit => "sdr_rec709_10bit",
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
                "sdr_rec709_10bit" => CreateVideoToVideoRequestVariant1OutputFormat.SdrRec70910bit,
                _ => null,
            };
        }
    }
}
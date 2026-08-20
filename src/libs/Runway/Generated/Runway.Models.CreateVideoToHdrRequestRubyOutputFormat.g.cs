
#nullable enable

namespace Runway
{
    /// <summary>
    /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite. The EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. All four profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
    /// </summary>
    public enum CreateVideoToHdrRequestRubyOutputFormat
    {
        /// <summary>
        /// 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Hdr10,
        /// <summary>
        /// 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrExrSequence,
        /// <summary>
        /// 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrProres,
        /// <summary>
        /// 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Hlg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToHdrRequestRubyOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToHdrRequestRubyOutputFormat value)
        {
            return value switch
            {
                CreateVideoToHdrRequestRubyOutputFormat.Hdr10 => "hdr10",
                CreateVideoToHdrRequestRubyOutputFormat.HdrExrSequence => "hdr_exr_sequence",
                CreateVideoToHdrRequestRubyOutputFormat.HdrProres => "hdr_prores",
                CreateVideoToHdrRequestRubyOutputFormat.Hlg => "hlg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToHdrRequestRubyOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "hdr10" => CreateVideoToHdrRequestRubyOutputFormat.Hdr10,
                "hdr_exr_sequence" => CreateVideoToHdrRequestRubyOutputFormat.HdrExrSequence,
                "hdr_prores" => CreateVideoToHdrRequestRubyOutputFormat.HdrProres,
                "hlg" => CreateVideoToHdrRequestRubyOutputFormat.Hlg,
                _ => null,
            };
        }
    }
}
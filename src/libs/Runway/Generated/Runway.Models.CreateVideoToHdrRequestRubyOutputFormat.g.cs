
#nullable enable

namespace Runway
{
    /// <summary>
    /// HDR delivery format. `hdr10` (default) and `hlg` deliver 10-bit HEVC without alpha. `hdr_prores` delivers BT.2020 + PQ ProRes and preserves source alpha as 4444. `hdr_exr_sequence` delivers linear BT.2020 EXR; `hdr_exr_acescg_sequence_1_3` and `hdr_exr_acescg_sequence_2_0` deliver scene-referred ACEScg EXR. EXR sequences preserve source alpha in the A channel and include colorimetry and provenance sidecars, plus source audio when present. All formats cost 20 credits per second, or 40 above 4 megapixels.
    /// </summary>
    public enum CreateVideoToHdrRequestRubyOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Hdr10,
        /// <summary>
        ///
        /// </summary>
        HdrExrAcescgSequence13,
        /// <summary>
        ///
        /// </summary>
        HdrExrAcescgSequence20,
        /// <summary>
        ///
        /// </summary>
        HdrExrSequence,
        /// <summary>
        ///
        /// </summary>
        HdrProres,
        /// <summary>
        ///
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
                CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence13 => "hdr_exr_acescg_sequence_1_3",
                CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence20 => "hdr_exr_acescg_sequence_2_0",
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
                "hdr_exr_acescg_sequence_1_3" => CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence13,
                "hdr_exr_acescg_sequence_2_0" => CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence20,
                "hdr_exr_sequence" => CreateVideoToHdrRequestRubyOutputFormat.HdrExrSequence,
                "hdr_prores" => CreateVideoToHdrRequestRubyOutputFormat.HdrProres,
                "hlg" => CreateVideoToHdrRequestRubyOutputFormat.Hlg,
                _ => null,
            };
        }
    }
}
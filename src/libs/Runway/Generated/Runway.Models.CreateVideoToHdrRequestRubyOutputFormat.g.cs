
#nullable enable

namespace Runway
{
    /// <summary>
    /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite; `hdr_exr_acescg_sequence_1_3` returns a scene-referred ACEScg sequence with VFX frame naming (frame.0001.exr): the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
    /// </summary>
    public enum CreateVideoToHdrRequestRubyOutputFormat
    {
        /// <summary>
        /// the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </summary>
        Hdr10,
        /// <summary>
        /// the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </summary>
        HdrExrAcescgSequence13,
        /// <summary>
        ///
        /// </summary>
        HdrExrAcescgSequence20,
        /// <summary>
        /// the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </summary>
        HdrExrSequence,
        /// <summary>
        /// the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </summary>
        HdrProres,
        /// <summary>
        /// the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
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
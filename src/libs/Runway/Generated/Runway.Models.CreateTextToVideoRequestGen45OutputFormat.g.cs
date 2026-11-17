
#nullable enable

namespace Runway
{
    /// <summary>
    /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames (plus a separate .wav artifact when the output has audio). `hdr10` (HEVC Main 10, BT.2020 + PQ) and `hlg` (HEVC Main 10, BT.2020 + HLG) return true-HDR 10-bit .mp4s; `sdr_rec709_10bit` returns a 10-bit Rec.709 HEVC .mp4 for SDR grading pipelines; `hdr_pq_12bit_master` returns a 12-bit 4:4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
    /// </summary>
    public enum CreateTextToVideoRequestGen45OutputFormat
    {
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        Hdr10,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        HdrExrAcescgSequence13,
        /// <summary>
        ///
        /// </summary>
        HdrExrAcescgSequence20,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        HdrExrSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        HdrPngSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        HdrPq12bitMaster,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        HdrProres,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        Hlg,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        Mp4,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        PngSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        Prores,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_acescg_sequence_1_3` returns the same delivery as scene-referred ACEScg (inverted through the ACES 1.3 Output Transform), reading correctly with the stock `ACES - ACEScg` input transform in ACES-configured pipelines, with VFX sequence frame naming (frame.0001.exr). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels — that includes 1440p (2560x1440 is under the line, but anything larger crosses it) up through 4K.
        /// </summary>
        SdrRec70910bit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestGen45OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGen45OutputFormat value)
        {
            return value switch
            {
                CreateTextToVideoRequestGen45OutputFormat.Hdr10 => "hdr10",
                CreateTextToVideoRequestGen45OutputFormat.HdrExrAcescgSequence13 => "hdr_exr_acescg_sequence_1_3",
                CreateTextToVideoRequestGen45OutputFormat.HdrExrAcescgSequence20 => "hdr_exr_acescg_sequence_2_0",
                CreateTextToVideoRequestGen45OutputFormat.HdrExrSequence => "hdr_exr_sequence",
                CreateTextToVideoRequestGen45OutputFormat.HdrPngSequence => "hdr_png_sequence",
                CreateTextToVideoRequestGen45OutputFormat.HdrPq12bitMaster => "hdr_pq_12bit_master",
                CreateTextToVideoRequestGen45OutputFormat.HdrProres => "hdr_prores",
                CreateTextToVideoRequestGen45OutputFormat.Hlg => "hlg",
                CreateTextToVideoRequestGen45OutputFormat.Mp4 => "mp4",
                CreateTextToVideoRequestGen45OutputFormat.PngSequence => "png_sequence",
                CreateTextToVideoRequestGen45OutputFormat.Prores => "prores",
                CreateTextToVideoRequestGen45OutputFormat.SdrRec70910bit => "sdr_rec709_10bit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGen45OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "hdr10" => CreateTextToVideoRequestGen45OutputFormat.Hdr10,
                "hdr_exr_acescg_sequence_1_3" => CreateTextToVideoRequestGen45OutputFormat.HdrExrAcescgSequence13,
                "hdr_exr_acescg_sequence_2_0" => CreateTextToVideoRequestGen45OutputFormat.HdrExrAcescgSequence20,
                "hdr_exr_sequence" => CreateTextToVideoRequestGen45OutputFormat.HdrExrSequence,
                "hdr_png_sequence" => CreateTextToVideoRequestGen45OutputFormat.HdrPngSequence,
                "hdr_pq_12bit_master" => CreateTextToVideoRequestGen45OutputFormat.HdrPq12bitMaster,
                "hdr_prores" => CreateTextToVideoRequestGen45OutputFormat.HdrProres,
                "hlg" => CreateTextToVideoRequestGen45OutputFormat.Hlg,
                "mp4" => CreateTextToVideoRequestGen45OutputFormat.Mp4,
                "png_sequence" => CreateTextToVideoRequestGen45OutputFormat.PngSequence,
                "prores" => CreateTextToVideoRequestGen45OutputFormat.Prores,
                "sdr_rec709_10bit" => CreateTextToVideoRequestGen45OutputFormat.SdrRec70910bit,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames (plus a separate .wav artifact when the output has audio). `hdr10` (HEVC Main 10, BT.2020 + PQ) and `hlg` (HEVC Main 10, BT.2020 + HLG) return true-HDR 10-bit .mp4s; `sdr_rec709_10bit` returns a 10-bit Rec.709 HEVC .mp4 for SDR grading pipelines; `hdr_pq_12bit_master` returns a 12-bit 4:4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
    /// </summary>
    public enum CreateImageToVideoRequestGen45OutputFormat
    {
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Hdr10,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrExrSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrPngSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrPq12bitMaster,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        HdrProres,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Hlg,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Mp4,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        PngSequence,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        Prores,
        /// <summary>
        /// 4:4 BT.2020 + PQ HEVC .mov with measured HDR10 content-light metadata for mastering; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile` (`422`, `422 HQ`, or `4444`; defaults to `422 HQ`); `hdr_png_sequence` returns a .zip of 16-bit PNG frames carrying the PQ signal losslessly (plus a colorimetry.json sidecar and a separate .wav when the output has audio); `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames carrying the HDR signal as linear BT.2020 display light, 1.0 = 100 nits (plus a colorimetry.json sidecar and a separate .wav when the output has audio). Non-mp4 formats incur an additional per-second credit surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for every 10-bit and deeper profile (including the 12-bit, 16-bit, and EXR ones), rising to 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        SdrRec70910bit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGen45OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen45OutputFormat value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen45OutputFormat.Hdr10 => "hdr10",
                CreateImageToVideoRequestGen45OutputFormat.HdrExrSequence => "hdr_exr_sequence",
                CreateImageToVideoRequestGen45OutputFormat.HdrPngSequence => "hdr_png_sequence",
                CreateImageToVideoRequestGen45OutputFormat.HdrPq12bitMaster => "hdr_pq_12bit_master",
                CreateImageToVideoRequestGen45OutputFormat.HdrProres => "hdr_prores",
                CreateImageToVideoRequestGen45OutputFormat.Hlg => "hlg",
                CreateImageToVideoRequestGen45OutputFormat.Mp4 => "mp4",
                CreateImageToVideoRequestGen45OutputFormat.PngSequence => "png_sequence",
                CreateImageToVideoRequestGen45OutputFormat.Prores => "prores",
                CreateImageToVideoRequestGen45OutputFormat.SdrRec70910bit => "sdr_rec709_10bit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen45OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "hdr10" => CreateImageToVideoRequestGen45OutputFormat.Hdr10,
                "hdr_exr_sequence" => CreateImageToVideoRequestGen45OutputFormat.HdrExrSequence,
                "hdr_png_sequence" => CreateImageToVideoRequestGen45OutputFormat.HdrPngSequence,
                "hdr_pq_12bit_master" => CreateImageToVideoRequestGen45OutputFormat.HdrPq12bitMaster,
                "hdr_prores" => CreateImageToVideoRequestGen45OutputFormat.HdrProres,
                "hlg" => CreateImageToVideoRequestGen45OutputFormat.Hlg,
                "mp4" => CreateImageToVideoRequestGen45OutputFormat.Mp4,
                "png_sequence" => CreateImageToVideoRequestGen45OutputFormat.PngSequence,
                "prores" => CreateImageToVideoRequestGen45OutputFormat.Prores,
                "sdr_rec709_10bit" => CreateImageToVideoRequestGen45OutputFormat.SdrRec70910bit,
                _ => null,
            };
        }
    }
}
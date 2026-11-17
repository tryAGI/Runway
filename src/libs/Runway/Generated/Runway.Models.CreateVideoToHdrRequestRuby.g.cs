
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToHdrRequestRuby
    {
        /// <summary>
        /// The SDR input video to upconvert. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite; `hdr_exr_acescg_sequence_1_3` returns a scene-referred ACEScg sequence with VFX frame naming (frame.0001.exr): the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToHdrRequestRubyOutputFormatJsonConverter))]
        public global::Runway.CreateVideoToHdrRequestRubyOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`. A source with an alpha channel is always delivered as `4444`, the only tier with an alpha plane, whatever tier is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proresProfile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToHdrRequestRubyProresProfileJsonConverter))]
        public global::Runway.CreateVideoToHdrRequestRubyProresProfile? ProresProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"ruby"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "ruby";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToHdrRequestRuby" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The SDR input video to upconvert. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="outputFormat">
        /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite; `hdr_exr_acescg_sequence_1_3` returns a scene-referred ACEScg sequence with VFX frame naming (frame.0001.exr): the source plate brought into ACES through the inverse ACES 1.3 SDR (Rec.709) Output Transform, with the highlight detail Ruby recovers added on top — read it with the stock `ACES - ACEScg` input transform; the ACES SDR view reproduces your source, and the ACES HDR views render the same scene with the recovered highlights (this is a scene, not the `hdr10` display grade, so an ACES HDR view is not expected to match `hdr10`). An EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. A source with an alpha channel (ProRes 4444, WebM with alpha, RGBA codecs) keeps it where the container can carry one: the EXR profiles write it as the A channel and `hdr_prores` delivers a 4444 with an alpha plane; the alpha is passed through as received (not premultiplied). `hdr10` and `hlg` cannot carry alpha and deliver the picture without it. All five profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels — that includes anything larger than 1440p, up through 4K.
        /// </param>
        /// <param name="proresProfile">
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`. A source with an alpha channel is always delivered as `4444`, the only tier with an alpha plane, whatever tier is requested.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToHdrRequestRuby(
            string videoUri,
            global::Runway.CreateVideoToHdrRequestRubyOutputFormat? outputFormat,
            global::Runway.CreateVideoToHdrRequestRubyProresProfile? proresProfile,
            string model = "ruby")
        {
            this.VideoUri = videoUri;
            this.OutputFormat = outputFormat;
            this.ProresProfile = proresProfile;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToHdrRequestRuby" /> class.
        /// </summary>
        public CreateVideoToHdrRequestRuby()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToHdrRequestRuby"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToHdrRequestRuby FromVideoUri(string videoUri)
        {
            return new CreateVideoToHdrRequestRuby
            {
                VideoUri = videoUri,
            };
        }

    }
}
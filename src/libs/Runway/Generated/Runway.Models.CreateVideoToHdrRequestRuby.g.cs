
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
        /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite. The EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. All four profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToHdrRequestRubyOutputFormatJsonConverter))]
        public global::Runway.CreateVideoToHdrRequestRubyOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`.
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
        /// The HDR delivery profile of the output. `hdr10` (default) returns an HEVC Main 10, BT.2020 + PQ .mp4; `hlg` returns an HEVC Main 10, BT.2020 + HLG .mp4; `hdr_prores` returns a BT.2020 + PQ ProRes .mov editorial mezzanine, whose tier is selectable with `proresProfile`; `hdr_exr_sequence` returns a .zip of half-float OpenEXR frames holding the HDR signal as linear BT.2020 display light, 1.0 = 100 nits, ready to composite. The EXR zip is the whole delivery — the frames, a colorimetry.json sidecar, a provenance.json sidecar declaring the upconvert, and the source audio as audio.wav when the source has any. All four profiles bill at the same rate: 20 credits per second of output, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K).
        /// </param>
        /// <param name="proresProfile">
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`.
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
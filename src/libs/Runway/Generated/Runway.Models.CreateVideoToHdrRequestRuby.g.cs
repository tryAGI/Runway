
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToHdrRequestRuby
    {
        /// <summary>
        /// The SDR input video to upconvert. Must be 30 seconds or shorter. Alpha in ProRes 4444, WebM, and RGBA sources is detected automatically.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// HDR delivery format. `hdr10` (default) and `hlg` deliver 10-bit HEVC without alpha. `hdr_prores` delivers BT.2020 + PQ ProRes and preserves source alpha as 4444. `hdr_exr_sequence` delivers linear BT.2020 EXR; `hdr_exr_acescg_sequence_1_3` and `hdr_exr_acescg_sequence_2_0` deliver scene-referred ACEScg EXR. EXR sequences preserve source alpha in the A channel and include colorimetry and provenance sidecars, plus source audio when present. All formats cost 20 credits per second, or 40 above 4 megapixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToHdrRequestRubyOutputFormatJsonConverter))]
        public global::Runway.CreateVideoToHdrRequestRubyOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`; sources with alpha are delivered as `4444` regardless of this value.
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
        /// The SDR input video to upconvert. Must be 30 seconds or shorter. Alpha in ProRes 4444, WebM, and RGBA sources is detected automatically.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="outputFormat">
        /// HDR delivery format. `hdr10` (default) and `hlg` deliver 10-bit HEVC without alpha. `hdr_prores` delivers BT.2020 + PQ ProRes and preserves source alpha as 4444. `hdr_exr_sequence` delivers linear BT.2020 EXR; `hdr_exr_acescg_sequence_1_3` and `hdr_exr_acescg_sequence_2_0` deliver scene-referred ACEScg EXR. EXR sequences preserve source alpha in the A channel and include colorimetry and provenance sidecars, plus source audio when present. All formats cost 20 credits per second, or 40 above 4 megapixels.
        /// </param>
        /// <param name="proresProfile">
        /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`; sources with alpha are delivered as `4444` regardless of this value.
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
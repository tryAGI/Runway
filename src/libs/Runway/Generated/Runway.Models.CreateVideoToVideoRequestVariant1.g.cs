
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestVariant1
    {
        /// <summary>
        /// A non-empty and optional string describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Timed guidance images placed at specific points in the input video. Up to 5 keyframes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>? Keyframes { get; set; }

        /// <summary>
        /// The input video to edit. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Ratio { get; set; }

        /// <summary>
        /// Target aspect ratio for expand/outpaint. Letterboxes the input video and keyframes before generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetAspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio? TargetAspectRatio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.CreateVideoToVideoRequestVariant1ContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames. `sdr_rec709_10bit` returns a 10-bit Rec.709 HEVC .mp4 for SDR grading pipelines. Non-mp4 formats incur an additional surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1OutputFormatJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestVariant1OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The ProRes profile to use. Only valid when `outputFormat` is `prores`. Defaults to `4444`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proresProfile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ProresProfileJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestVariant1ProresProfile? ProresProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"aleph2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "aleph2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The input video to edit. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A non-empty and optional string describing what should appear in the output.
        /// </param>
        /// <param name="keyframes">
        /// Timed guidance images placed at specific points in the input video. Up to 5 keyframes.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="targetAspectRatio">
        /// Target aspect ratio for expand/outpaint. Letterboxes the input video and keyframes before generation.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="outputFormat">
        /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames. `sdr_rec709_10bit` returns a 10-bit Rec.709 HEVC .mp4 for SDR grading pipelines. Non-mp4 formats incur an additional surcharge: 5 credits per second for `prores` and `png_sequence`, and 20 credits per second for `sdr_rec709_10bit` — 40 credits per second when the output is larger than 4 megapixels (roughly 4K).
        /// </param>
        /// <param name="proresProfile">
        /// The ProRes profile to use. Only valid when `outputFormat` is `prores`. Defaults to `4444`.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestVariant1(
            string videoUri,
            string? promptText,
            global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>? keyframes,
            int? seed,
            global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio? targetAspectRatio,
            global::Runway.CreateVideoToVideoRequestVariant1ContentModeration? contentModeration,
            global::Runway.CreateVideoToVideoRequestVariant1OutputFormat? outputFormat,
            global::Runway.CreateVideoToVideoRequestVariant1ProresProfile? proresProfile,
            string model = "aleph2")
        {
            this.PromptText = promptText;
            this.Keyframes = keyframes;
            this.VideoUri = videoUri;
            this.Seed = seed;
            this.TargetAspectRatio = targetAspectRatio;
            this.ContentModeration = contentModeration;
            this.OutputFormat = outputFormat;
            this.ProresProfile = proresProfile;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1" /> class.
        /// </summary>
        public CreateVideoToVideoRequestVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestVariant1 FromVideoUri(string videoUri)
        {
            return new CreateVideoToVideoRequestVariant1
            {
                VideoUri = videoUri,
            };
        }

    }
}
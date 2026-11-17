
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestSeedance25
    {
        /// <summary>
        /// An optional text prompt up to 15000 characters describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Whether to generate audio for the video. Defaults to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`. Draft mode only supports `mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance25OutputFormatJsonConverter))]
        public global::Runway.CreateTextToVideoRequestSeedance25OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes. Defaults to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Runway.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.5 supports 480p, 720p, and 1080p. Defaults to `1280:720`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance25RatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestSeedance25Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 30). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25Reference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 30 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        /// Generate a cheap 480p preview instead of a full-quality video. The returned task ID can later be enhanced to a 1080p video with the same content by passing it as `draftTaskId` to `text_to_video`. Drafts can be enhanced within 7 days of creation. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// The ID of a succeeded draft task to enhance to 1080p. The draft is regenerated with its original prompt, references, and settings, so no other generation fields may be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftTaskId")]
        public global::System.Guid? DraftTaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedance2_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedance2_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance25" /> class.
        /// </summary>
        /// <param name="promptText">
        /// An optional text prompt up to 15000 characters describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video. Defaults to `true`.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="outputFormat">
        /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`. Draft mode only supports `mp4`.
        /// </param>
        /// <param name="duration">
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes. Defaults to 5.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.5 supports 480p, 720p, and 1080p. Defaults to `1280:720`.
        /// </param>
        /// <param name="references">
        /// An optional array of image references (up to 30). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="referenceVideos">
        /// An optional array of video references. The combined duration across all video references must not exceed 30 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </param>
        /// <param name="draft">
        /// Generate a cheap 480p preview instead of a full-quality video. The returned task ID can later be enhanced to a 1080p video with the same content by passing it as `draftTaskId` to `text_to_video`. Drafts can be enhanced within 7 days of creation. Defaults to false.
        /// </param>
        /// <param name="draftTaskId">
        /// The ID of a succeeded draft task to enhance to 1080p. The draft is regenerated with its original prompt, references, and settings, so no other generation fields may be provided.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestSeedance25(
            string? promptText,
            bool? audio,
            int? seed,
            global::Runway.CreateTextToVideoRequestSeedance25OutputFormat? outputFormat,
            global::Runway.AnyOf<int?, string>? duration,
            global::Runway.CreateTextToVideoRequestSeedance25Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceAudioItem>? referenceAudio,
            bool? draft,
            global::System.Guid? draftTaskId,
            string model = "seedance2_5")
        {
            this.PromptText = promptText;
            this.Audio = audio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Draft = draft;
            this.DraftTaskId = draftTaskId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance25" /> class.
        /// </summary>
        public CreateTextToVideoRequestSeedance25()
        {
        }

    }
}
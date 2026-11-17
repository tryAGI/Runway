
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestSeedance25
    {
        /// <summary>
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// An optional text prompt up to 15000 characters describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25OutputFormatJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance25OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Runway.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.5 supports 480p, 720p, and 1080p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25RatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance25Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must not exceed 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25ReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        /// Generate a cheap 480p preview instead of a full-quality video. The returned task ID can later be enhanced to a 1080p video with the same content by passing it as `draftTaskId` to `text_to_video`. Drafts can be enhanced within 7 days of creation. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance25" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt up to 15000 characters describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="outputFormat">
        /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`. Draft mode only supports `mp4`.
        /// </param>
        /// <param name="duration">
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.5 supports 480p, 720p, and 1080p.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. The total combined duration must not exceed 30 seconds.
        /// </param>
        /// <param name="draft">
        /// Generate a cheap 480p preview instead of a full-quality video. The returned task ID can later be enhanced to a 1080p video with the same content by passing it as `draftTaskId` to `text_to_video`. Drafts can be enhanced within 7 days of creation. Defaults to false.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestSeedance25(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>> promptImage,
            string? promptText,
            bool? audio,
            int? seed,
            global::Runway.CreateImageToVideoRequestSeedance25OutputFormat? outputFormat,
            global::Runway.AnyOf<int?, string>? duration,
            global::Runway.CreateImageToVideoRequestSeedance25Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25ReferenceAudioItem>? referenceAudio,
            bool? draft,
            string model = "seedance2_5")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Duration = duration;
            this.Ratio = ratio;
            this.ReferenceAudio = referenceAudio;
            this.Draft = draft;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance25" /> class.
        /// </summary>
        public CreateImageToVideoRequestSeedance25()
        {
        }

    }
}
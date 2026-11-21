
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestSeedance25Flash
    {
        /// <summary>
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25FlashPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25FlashPromptImagePromptImage>> PromptImage { get; set; }

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
        /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25FlashOutputFormatJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance25FlashOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Runway.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.5 Flash supports 480p and 720p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25FlashRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance25FlashRatio? Ratio { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25FlashReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedance2_5_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedance2_5_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance25Flash" /> class.
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
        /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`.
        /// </param>
        /// <param name="duration">
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.5 Flash supports 480p and 720p.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestSeedance25Flash(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25FlashPromptImagePromptImage>> promptImage,
            string? promptText,
            bool? audio,
            int? seed,
            global::Runway.CreateImageToVideoRequestSeedance25FlashOutputFormat? outputFormat,
            global::Runway.AnyOf<int?, string>? duration,
            global::Runway.CreateImageToVideoRequestSeedance25FlashRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25FlashReferenceAudioItem>? referenceAudio,
            string model = "seedance2_5_flash")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Duration = duration;
            this.Ratio = ratio;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance25Flash" /> class.
        /// </summary>
        public CreateImageToVideoRequestSeedance25Flash()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestSeedance25Flash
    {
        /// <summary>
        /// The input video to use as a reference for the output video. If additional video references are provided, the combined duration across all video references must not exceed 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVideo { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25FlashOutputFormatJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance25FlashOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided. `edit` modifies the input video in place, requires `promptText`, requires `duration: "auto"`, and does not accept `ratio`.<br/>
        /// Default Value: reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25FlashModeJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance25FlashMode? Mode { get; set; }

        /// <summary>
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes. Defaults to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Runway.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.5 Flash supports 480p and 720p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25FlashRatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance25FlashRatio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 10). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 30 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReferenceAudioItem>? ReferenceAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance25Flash" /> class.
        /// </summary>
        /// <param name="promptVideo">
        /// The input video to use as a reference for the output video. If additional video references are provided, the combined duration across all video references must not exceed 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
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
        /// <param name="mode">
        /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided. `edit` modifies the input video in place, requires `promptText`, requires `duration: "auto"`, and does not accept `ratio`.<br/>
        /// Default Value: reference
        /// </param>
        /// <param name="duration">
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes. Defaults to 5.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.5 Flash supports 480p and 720p.
        /// </param>
        /// <param name="references">
        /// An optional array of image references (up to 10). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="referenceVideos">
        /// An optional array of video references. The combined duration across all video references must not exceed 30 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestSeedance25Flash(
            string promptVideo,
            string? promptText,
            bool? audio,
            int? seed,
            global::Runway.CreateVideoToVideoRequestSeedance25FlashOutputFormat? outputFormat,
            global::Runway.CreateVideoToVideoRequestSeedance25FlashMode? mode,
            global::Runway.AnyOf<int?, string>? duration,
            global::Runway.CreateVideoToVideoRequestSeedance25FlashRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25FlashReferenceAudioItem>? referenceAudio,
            string model = "seedance2_5_flash")
        {
            this.PromptVideo = promptVideo;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Mode = mode;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance25Flash" /> class.
        /// </summary>
        public CreateVideoToVideoRequestSeedance25Flash()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestSeedance25Flash"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance25Flash FromPromptVideo(string promptVideo)
        {
            return new CreateVideoToVideoRequestSeedance25Flash
            {
                PromptVideo = promptVideo,
            };
        }

    }
}
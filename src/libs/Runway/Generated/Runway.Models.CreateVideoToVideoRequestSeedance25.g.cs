
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestSeedance25
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
        /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided.<br/>
        /// Default Value: reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25ModeJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance25Mode? Mode { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video. Defaults to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.5 supports 480p and 720p only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25RatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance25Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 30). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25Reference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 30 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must be less than 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceAudioItem>? ReferenceAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance25" /> class.
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
        /// <param name="mode">
        /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided.<br/>
        /// Default Value: reference
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video. Defaults to 5.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.5 supports 480p and 720p only.
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
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestSeedance25(
            string promptVideo,
            string? promptText,
            bool? audio,
            global::Runway.CreateVideoToVideoRequestSeedance25Mode? mode,
            int? duration,
            global::Runway.CreateVideoToVideoRequestSeedance25Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceAudioItem>? referenceAudio,
            string model = "seedance2_5")
        {
            this.PromptVideo = promptVideo;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Mode = mode;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance25" /> class.
        /// </summary>
        public CreateVideoToVideoRequestSeedance25()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestSeedance25"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance25 FromPromptVideo(string promptVideo)
        {
            return new CreateVideoToVideoRequestSeedance25
            {
                PromptVideo = promptVideo,
            };
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestSeedance2
    {
        /// <summary>
        /// The input video to use as a reference for the output video. If additional video references are provided, the combined duration across all video references must not exceed 15 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVideo { get; set; }

        /// <summary>
        /// An optional text prompt up to 3500 characters describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Whether to generate audio for the video. Audio inclusion affects pricing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestSeedance2Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 9). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2Reference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"seedance2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedance2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance2" /> class.
        /// </summary>
        /// <param name="promptVideo">
        /// The input video to use as a reference for the output video. If additional video references are provided, the combined duration across all video references must not exceed 15 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt up to 3500 characters describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video. Audio inclusion affects pricing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="references">
        /// An optional array of image references (up to 9). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="referenceVideos">
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestSeedance2(
            string promptVideo,
            string? promptText,
            bool? audio,
            int? duration,
            global::Runway.CreateVideoToVideoRequestSeedance2Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceAudioItem>? referenceAudio,
            string model = "seedance2")
        {
            this.PromptVideo = promptVideo;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestSeedance2" /> class.
        /// </summary>
        public CreateVideoToVideoRequestSeedance2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestSeedance2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance2 FromPromptVideo(string promptVideo)
        {
            return new CreateVideoToVideoRequestSeedance2
            {
                PromptVideo = promptVideo,
            };
        }

    }
}
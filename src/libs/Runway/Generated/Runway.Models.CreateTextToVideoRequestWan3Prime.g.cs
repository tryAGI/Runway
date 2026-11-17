
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestWan3Prime
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Whether to generate audio with the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video, as `&lt;width&gt;:&lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestWan3PrimeRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestWan3PrimeRatio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 10). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"wan3_prime"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "wan3_prime";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestWan3Prime" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio with the video.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video, as `&lt;width&gt;:&lt;height&gt;`. Keyframe image-to-video requests must use `auto_480p`, `auto_720p`, or `auto_1080p` because their aspect ratio follows the first frame.
        /// </param>
        /// <param name="references">
        /// An optional array of image references (up to 10). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="referenceVideos">
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. The total combined duration must not exceed 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestWan3Prime(
            string promptText,
            bool? audio,
            int? duration,
            global::Runway.CreateTextToVideoRequestWan3PrimeRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3PrimeReferenceAudioItem>? referenceAudio,
            string model = "wan3_prime")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Audio = audio;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestWan3Prime" /> class.
        /// </summary>
        public CreateTextToVideoRequestWan3Prime()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestWan3Prime"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestWan3Prime FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestWan3Prime
            {
                PromptText = promptText,
            };
        }

    }
}
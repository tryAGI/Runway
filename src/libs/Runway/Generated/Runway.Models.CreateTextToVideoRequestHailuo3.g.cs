
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoRequestHailuo3
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output resolution. Hailuo 3.0 supports 768P and 2K.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3ResolutionJsonConverter))]
        public global::Runway.CreateTextToVideoRequestHailuo3Resolution? Resolution { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The aspect ratio of the output video. Use adaptive only when image or video references are provided; text-only requests require a concrete ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3RatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestHailuo3Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 9). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3Reference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"hailuo3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "hailuo3";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHailuo3" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output.
        /// </param>
        /// <param name="resolution">
        /// The output resolution. Hailuo 3.0 supports 768P and 2K.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The aspect ratio of the output video. Use adaptive only when image or video references are provided; text-only requests require a concrete ratio.
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
        public CreateTextToVideoRequestHailuo3(
            string promptText,
            global::Runway.CreateTextToVideoRequestHailuo3Resolution? resolution,
            int? duration,
            global::Runway.CreateTextToVideoRequestHailuo3Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceAudioItem>? referenceAudio,
            string model = "hailuo3")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHailuo3" /> class.
        /// </summary>
        public CreateTextToVideoRequestHailuo3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestHailuo3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestHailuo3 FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestHailuo3
            {
                PromptText = promptText,
            };
        }

    }
}
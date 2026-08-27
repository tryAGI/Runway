
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestGrokImagine15
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output resolution. Requests with image references are capped at 720p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15ResolutionJsonConverter))]
        public global::Runway.CreateTextToVideoRequestGrokImagine15Resolution? Resolution { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The aspect ratio of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15RatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestGrokImagine15Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references. Referenced images can be addressed in the prompt as [Image 1], [Image 2], and so on. See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15Reference>? References { get; set; }

        /// <summary>
        /// An optional array of audio references. Audio references require at least one image reference, and each clip must be between 3 and 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15ReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"grok_imagine_1_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "grok_imagine_1_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGrokImagine15" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output.
        /// </param>
        /// <param name="resolution">
        /// The output resolution. Requests with image references are capped at 720p.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The aspect ratio of the output video.
        /// </param>
        /// <param name="references">
        /// An optional array of image references. Referenced images can be addressed in the prompt as [Image 1], [Image 2], and so on. See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. Audio references require at least one image reference, and each clip must be between 3 and 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestGrokImagine15(
            string promptText,
            global::Runway.CreateTextToVideoRequestGrokImagine15Resolution? resolution,
            int? duration,
            global::Runway.CreateTextToVideoRequestGrokImagine15Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15ReferenceAudioItem>? referenceAudio,
            string model = "grok_imagine_1_5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGrokImagine15" /> class.
        /// </summary>
        public CreateTextToVideoRequestGrokImagine15()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestGrokImagine15"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestGrokImagine15 FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestGrokImagine15
            {
                PromptText = promptText,
            };
        }

    }
}
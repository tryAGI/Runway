
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestSeedance2Fast
    {
        /// <summary>
        /// A non-empty text prompt up to 3500 characters describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

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
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Runway.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.0 Fast supports 480p and 720p only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestSeedance2FastRatio? Ratio { get; set; }

        /// <summary>
        /// An optional array of image references (up to 9). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReference>? References { get; set; }

        /// <summary>
        /// An optional array of video references. The combined duration across all video references must not exceed 15 seconds. See [our docs](/assets/inputs#videos) on video inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// An optional array of audio references. The total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedance2_fast"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedance2_fast";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance2Fast" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt up to 3500 characters describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="duration">
        /// Seconds of video to generate, or `auto` to let the model choose. `auto` is billed at the variant maximum up front; unused credits are refunded after the generation finishes.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.0 Fast supports 480p and 720p only.
        /// </param>
        /// <param name="references">
        /// An optional array of image references (up to 9). See [our docs](/assets/inputs#images) on image inputs for more information.
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
        public CreateTextToVideoRequestSeedance2Fast(
            string promptText,
            bool? audio,
            int? seed,
            global::Runway.AnyOf<int?, string>? duration,
            global::Runway.CreateTextToVideoRequestSeedance2FastRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem>? referenceAudio,
            string model = "seedance2_fast")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Audio = audio;
            this.Seed = seed;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance2Fast" /> class.
        /// </summary>
        public CreateTextToVideoRequestSeedance2Fast()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestSeedance2Fast"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2Fast FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestSeedance2Fast
            {
                PromptText = promptText,
            };
        }

    }
}
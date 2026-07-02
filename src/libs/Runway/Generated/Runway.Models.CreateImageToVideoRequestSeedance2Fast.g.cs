
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestSeedance2Fast
    {
        /// <summary>
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// An optional text prompt up to 3500 characters describing what should appear in the output.
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
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. Seedance 2.0 Fast supports 480p and 720p only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance2FastRatio? Ratio { get; set; }

        /// <summary>
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastReferenceAudioItem>? ReferenceAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance2Fast" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt up to 3500 characters describing what should appear in the output.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. Seedance 2.0 Fast supports 480p and 720p only.
        /// </param>
        /// <param name="referenceAudio">
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestSeedance2Fast(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>> promptImage,
            string? promptText,
            bool? audio,
            int? duration,
            global::Runway.CreateImageToVideoRequestSeedance2FastRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastReferenceAudioItem>? referenceAudio,
            string model = "seedance2_fast")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText;
            this.Audio = audio;
            this.Duration = duration;
            this.Ratio = ratio;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance2Fast" /> class.
        /// </summary>
        public CreateImageToVideoRequestSeedance2Fast()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestSeedance2
    {
        /// <summary>
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// An optional text prompt up to 3500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestSeedance2Ratio? Ratio { get; set; }

        /// <summary>
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2ReferenceAudioItem>? ReferenceAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance2" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image or array of images. Use position `first`/`last` for keyframe mode, or omit position for reference images. The two modes cannot be mixed.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt up to 3500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
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
        /// <param name="referenceAudio">
        /// An optional array of audio references. Audio references require a text prompt, and the total combined duration must not exceed 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestSeedance2(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>> promptImage,
            string? promptText,
            bool? audio,
            int? duration,
            global::Runway.CreateImageToVideoRequestSeedance2Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2ReferenceAudioItem>? referenceAudio,
            string model = "seedance2")
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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestSeedance2" /> class.
        /// </summary>
        public CreateImageToVideoRequestSeedance2()
        {
        }

    }
}
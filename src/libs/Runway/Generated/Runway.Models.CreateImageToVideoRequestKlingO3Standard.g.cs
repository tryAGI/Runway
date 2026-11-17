
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestKlingO3Standard
    {
        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Provider-specific settings for multishot video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSettings")]
        public global::Runway.CreateImageToVideoRequestKlingO3StandardProviderSettings? ProviderSettings { get; set; }

        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// You may specify an image to use as the first frame of the output video, or an array with a first frame and optionally a last frame. When both keyframes are provided, output aspect ratio follows the first frame. See [image inputs](/assets/inputs#images) for file size limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestKlingO3StandardRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestKlingO3StandardRatio? Ratio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// An optional array of reference images (up to 7). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardReferencesReferenceImage>>))]
        public global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardReferencesReferenceImage>>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"klingO3_standard"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "klingO3_standard";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKlingO3Standard" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// You may specify an image to use as the first frame of the output video, or an array with a first frame and optionally a last frame. When both keyframes are provided, output aspect ratio follows the first frame. See [image inputs](/assets/inputs#images) for file size limits.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="providerSettings">
        /// Provider-specific settings for multishot video generation.
        /// </param>
        /// <param name="promptText">
        /// A text prompt describing what should appear in the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="references">
        /// An optional array of reference images (up to 7). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestKlingO3Standard(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardPromptImagePromptImage>> promptImage,
            bool? audio,
            global::Runway.CreateImageToVideoRequestKlingO3StandardProviderSettings? providerSettings,
            string? promptText,
            global::Runway.CreateImageToVideoRequestKlingO3StandardRatio? ratio,
            int? duration,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKlingO3StandardReferencesReferenceImage>>? references,
            string model = "klingO3_standard")
        {
            this.Audio = audio;
            this.ProviderSettings = providerSettings;
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.Duration = duration;
            this.References = references;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKlingO3Standard" /> class.
        /// </summary>
        public CreateImageToVideoRequestKlingO3Standard()
        {
        }

    }
}
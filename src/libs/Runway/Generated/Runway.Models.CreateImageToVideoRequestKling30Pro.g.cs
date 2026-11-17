
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestKling30Pro
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
        public global::Runway.CreateImageToVideoRequestKling30ProProviderSettings? ProviderSettings { get; set; }

        /// <summary>
        /// Creativity/freedom scale for generation. 0 gives the model maximum creative freedom, 1 makes it follow the prompt most strictly. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfgScale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// You may specify an image to use as the first frame of the output video, or an array with a first frame and optionally a last frame. When both keyframes are provided, output aspect ratio follows the first frame. See [image inputs](/assets/inputs#images) for file size limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling30ProPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling30ProPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestKling30ProRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestKling30ProRatio? Ratio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"kling3.0_pro"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "kling3.0_pro";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling30Pro" /> class.
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
        /// <param name="cfgScale">
        /// Creativity/freedom scale for generation. 0 gives the model maximum creative freedom, 1 makes it follow the prompt most strictly. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
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
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestKling30Pro(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling30ProPromptImagePromptImage>> promptImage,
            bool? audio,
            global::Runway.CreateImageToVideoRequestKling30ProProviderSettings? providerSettings,
            double? cfgScale,
            string? promptText,
            global::Runway.CreateImageToVideoRequestKling30ProRatio? ratio,
            int? duration,
            string model = "kling3.0_pro")
        {
            this.Audio = audio;
            this.ProviderSettings = providerSettings;
            this.CfgScale = cfgScale;
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling30Pro" /> class.
        /// </summary>
        public CreateImageToVideoRequestKling30Pro()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKling30Pro
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
        public global::Runway.CreateTextToVideoRequestKling30ProProviderSettings? ProviderSettings { get; set; }

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
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKling30ProRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToVideoRequestKling30ProRatio Ratio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling30Pro" /> class.
        /// </summary>
        /// <param name="ratio">
        /// The resolution of the output video.
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
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestKling30Pro(
            global::Runway.CreateTextToVideoRequestKling30ProRatio ratio,
            bool? audio,
            global::Runway.CreateTextToVideoRequestKling30ProProviderSettings? providerSettings,
            double? cfgScale,
            string? promptText,
            int? duration,
            string model = "kling3.0_pro")
        {
            this.Audio = audio;
            this.ProviderSettings = providerSettings;
            this.CfgScale = cfgScale;
            this.PromptText = promptText;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling30Pro" /> class.
        /// </summary>
        public CreateTextToVideoRequestKling30Pro()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestKling30Pro"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestKling30Pro FromRatio(global::Runway.CreateTextToVideoRequestKling30ProRatio ratio)
        {
            return new CreateTextToVideoRequestKling30Pro
            {
                Ratio = ratio,
            };
        }

    }
}
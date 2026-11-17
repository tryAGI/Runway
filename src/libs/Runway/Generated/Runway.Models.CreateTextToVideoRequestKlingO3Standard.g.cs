
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKlingO3Standard
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
        public global::Runway.CreateTextToVideoRequestKlingO3StandardProviderSettings? ProviderSettings { get; set; }

        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKlingO3StandardRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToVideoRequestKlingO3StandardRatio Ratio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO3Standard" /> class.
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
        public CreateTextToVideoRequestKlingO3Standard(
            global::Runway.CreateTextToVideoRequestKlingO3StandardRatio ratio,
            bool? audio,
            global::Runway.CreateTextToVideoRequestKlingO3StandardProviderSettings? providerSettings,
            string? promptText,
            int? duration,
            string model = "klingO3_standard")
        {
            this.Audio = audio;
            this.ProviderSettings = providerSettings;
            this.PromptText = promptText;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO3Standard" /> class.
        /// </summary>
        public CreateTextToVideoRequestKlingO3Standard()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestKlingO3Standard"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestKlingO3Standard FromRatio(global::Runway.CreateTextToVideoRequestKlingO3StandardRatio ratio)
        {
            return new CreateTextToVideoRequestKlingO3Standard
            {
                Ratio = ratio,
            };
        }

    }
}
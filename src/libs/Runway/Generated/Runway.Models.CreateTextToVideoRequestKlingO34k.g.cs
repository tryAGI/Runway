
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKlingO34k
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
        public global::Runway.CreateTextToVideoRequestKlingO34kProviderSettings? ProviderSettings { get; set; }

        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKlingO34kRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToVideoRequestKlingO34kRatio Ratio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"klingO3_4k"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "klingO3_4k";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO34k" /> class.
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
        public CreateTextToVideoRequestKlingO34k(
            global::Runway.CreateTextToVideoRequestKlingO34kRatio ratio,
            bool? audio,
            global::Runway.CreateTextToVideoRequestKlingO34kProviderSettings? providerSettings,
            string? promptText,
            int? duration,
            string model = "klingO3_4k")
        {
            this.Audio = audio;
            this.ProviderSettings = providerSettings;
            this.PromptText = promptText;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO34k" /> class.
        /// </summary>
        public CreateTextToVideoRequestKlingO34k()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestKlingO34k"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestKlingO34k FromRatio(global::Runway.CreateTextToVideoRequestKlingO34kRatio ratio)
        {
            return new CreateTextToVideoRequestKlingO34k
            {
                Ratio = ratio,
            };
        }

    }
}
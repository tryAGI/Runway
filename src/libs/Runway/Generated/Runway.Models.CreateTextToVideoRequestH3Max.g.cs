
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestH3Max
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output resolution. MiniMax H3 Max supports 480p and 768p.<br/>
        /// Example: 768p
        /// </summary>
        /// <example>768p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestH3MaxResolutionJsonConverter))]
        public global::Runway.CreateTextToVideoRequestH3MaxResolution? Resolution { get; set; }

        /// <summary>
        /// How the model rewrites the prompt before generating. disabled keeps the prompt as written. balanced (the default) does a short rewrite. quality spends extra time rewriting for a stronger result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptExpansionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestH3MaxPromptExpansionModeJsonConverter))]
        public global::Runway.CreateTextToVideoRequestH3MaxPromptExpansionMode? PromptExpansionMode { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Identical results also need promptExpansionMode set to disabled; balanced and quality rewrite the prompt and will not repeat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"h3_max"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "h3_max";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestH3Max" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output.
        /// </param>
        /// <param name="resolution">
        /// The output resolution. MiniMax H3 Max supports 480p and 768p.<br/>
        /// Example: 768p
        /// </param>
        /// <param name="promptExpansionMode">
        /// How the model rewrites the prompt before generating. disabled keeps the prompt as written. balanced (the default) does a short rewrite. quality spends extra time rewriting for a stronger result.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Identical results also need promptExpansionMode set to disabled; balanced and quality rewrite the prompt and will not repeat.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestH3Max(
            string promptText,
            global::Runway.CreateTextToVideoRequestH3MaxResolution? resolution,
            global::Runway.CreateTextToVideoRequestH3MaxPromptExpansionMode? promptExpansionMode,
            int? seed,
            int? duration,
            string model = "h3_max")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.PromptExpansionMode = promptExpansionMode;
            this.Seed = seed;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestH3Max" /> class.
        /// </summary>
        public CreateTextToVideoRequestH3Max()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestH3Max"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestH3Max FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestH3Max
            {
                PromptText = promptText,
            };
        }

    }
}
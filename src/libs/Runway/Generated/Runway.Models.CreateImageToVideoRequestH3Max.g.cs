
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestH3Max
    {
        /// <summary>
        /// An image to use as the first frame, or an array with a first frame and optionally a last frame. A last frame requires a first frame. Each image must be at least 256 pixels on both sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestH3MaxPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestH3MaxPromptImagePromptImage>> PromptImage { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestH3MaxResolutionJsonConverter))]
        public global::Runway.CreateImageToVideoRequestH3MaxResolution? Resolution { get; set; }

        /// <summary>
        /// How the model rewrites the prompt before generating. disabled keeps the prompt as written. balanced (the default) does a short rewrite. quality spends extra time rewriting for a stronger result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptExpansionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestH3MaxPromptExpansionModeJsonConverter))]
        public global::Runway.CreateImageToVideoRequestH3MaxPromptExpansionMode? PromptExpansionMode { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestH3Max" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image to use as the first frame, or an array with a first frame and optionally a last frame. A last frame requires a first frame. Each image must be at least 256 pixels on both sides.
        /// </param>
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
        public CreateImageToVideoRequestH3Max(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestH3MaxPromptImagePromptImage>> promptImage,
            string promptText,
            global::Runway.CreateImageToVideoRequestH3MaxResolution? resolution,
            global::Runway.CreateImageToVideoRequestH3MaxPromptExpansionMode? promptExpansionMode,
            int? seed,
            int? duration,
            string model = "h3_max")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.PromptExpansionMode = promptExpansionMode;
            this.Seed = seed;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestH3Max" /> class.
        /// </summary>
        public CreateImageToVideoRequestH3Max()
        {
        }

    }
}
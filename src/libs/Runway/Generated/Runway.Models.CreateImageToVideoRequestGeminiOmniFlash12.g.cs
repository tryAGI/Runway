
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGeminiOmniFlash12
    {
        /// <summary>
        /// An image to use as the first frame, or an array containing a first frame and optional last frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// A non-empty text prompt describing how the video should evolve between the provided frames.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution and aspect ratio of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlash12RatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash12Ratio? Ratio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds. Use "auto" to let the model choose a duration. Numeric durations must be between 3 and 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, int?>))]
        public global::Runway.AnyOf<string, int?>? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gemini_omni_flash_1.2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_omni_flash_1.2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlash12" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image to use as the first frame, or an array containing a first frame and optional last frame.
        /// </param>
        /// <param name="promptText">
        /// A non-empty text prompt describing how the video should evolve between the provided frames.
        /// </param>
        /// <param name="ratio">
        /// The resolution and aspect ratio of the output video.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds. Use "auto" to let the model choose a duration. Numeric durations must be between 3 and 15 seconds.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestGeminiOmniFlash12(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12PromptImagePromptImage>> promptImage,
            string promptText,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash12Ratio? ratio,
            global::Runway.AnyOf<string, int?>? duration,
            string model = "gemini_omni_flash_1.2")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlash12" /> class.
        /// </summary>
        public CreateImageToVideoRequestGeminiOmniFlash12()
        {
        }

    }
}
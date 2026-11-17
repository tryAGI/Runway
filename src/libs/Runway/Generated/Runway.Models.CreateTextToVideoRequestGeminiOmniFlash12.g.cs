
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestGeminiOmniFlash12
    {
        /// <summary>
        /// A non-empty text prompt describing the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution and aspect ratio of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlash12RatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestGeminiOmniFlash12Ratio? Ratio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds. Use "auto" to let the model choose a duration. Numeric durations must be between 3 and 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, int?>))]
        public global::Runway.AnyOf<string, int?>? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12Reference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12ReferenceVideo>? ReferenceVideos { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGeminiOmniFlash12" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing the video to generate.
        /// </param>
        /// <param name="ratio">
        /// The resolution and aspect ratio of the output video.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds. Use "auto" to let the model choose a duration. Numeric durations must be between 3 and 15 seconds.
        /// </param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestGeminiOmniFlash12(
            string promptText,
            global::Runway.CreateTextToVideoRequestGeminiOmniFlash12Ratio? ratio,
            global::Runway.AnyOf<string, int?>? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12Reference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGeminiOmniFlash12ReferenceVideo>? referenceVideos,
            string model = "gemini_omni_flash_1.2")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Duration = duration;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGeminiOmniFlash12" /> class.
        /// </summary>
        public CreateTextToVideoRequestGeminiOmniFlash12()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestGeminiOmniFlash12"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestGeminiOmniFlash12 FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestGeminiOmniFlash12
            {
                PromptText = promptText,
            };
        }

    }
}
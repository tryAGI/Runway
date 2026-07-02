
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoRequestGeminiOmniFlash
    {
        /// <summary>
        /// A non-empty text prompt describing the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The aspect ratio of the output video: `1280:720` (landscape) or `720:1280` (portrait).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio? Ratio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds, as a whole number from 3 to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gemini_omni_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_omni_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing the video to generate.
        /// </param>
        /// <param name="ratio">
        /// The aspect ratio of the output video: `1280:720` (landscape) or `720:1280` (portrait).
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds, as a whole number from 3 to 10.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestGeminiOmniFlash(
            string promptText,
            global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio? ratio,
            int? duration,
            string model = "gemini_omni_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        public CreateTextToVideoRequestGeminiOmniFlash()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestGeminiOmniFlash"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestGeminiOmniFlash FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestGeminiOmniFlash
            {
                PromptText = promptText,
            };
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGeminiOmniFlash
    {
        /// <summary>
        /// An image to use as the first frame of the output video. Gemini Omni Flash only supports a first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// An optional text prompt describing how the video should evolve from the first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The aspect ratio of the output video: `1280:720` (landscape) or `720:1280` (portrait).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio? Ratio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// An image to use as the first frame of the output video. Gemini Omni Flash only supports a first frame.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt describing how the video should evolve from the first frame.
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
        public CreateImageToVideoRequestGeminiOmniFlash(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>> promptImage,
            string? promptText,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio? ratio,
            int? duration,
            string model = "gemini_omni_flash")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        public CreateImageToVideoRequestGeminiOmniFlash()
        {
        }

    }
}
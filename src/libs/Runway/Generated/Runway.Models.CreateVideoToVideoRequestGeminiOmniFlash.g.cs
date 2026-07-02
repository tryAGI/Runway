
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGeminiOmniFlash
    {
        /// <summary>
        /// The input video to edit. The output is 720p, with the orientation (landscape or portrait) matched to the input. The output duration matches the input, up to 10 seconds. The input must be at most 10 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// A non-empty instruction describing the edit to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// An optional array of image references to guide the edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestGeminiOmniFlashReference>? References { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The input video to edit. The output is 720p, with the orientation (landscape or portrait) matched to the input. The output duration matches the input, up to 10 seconds. The input must be at most 10 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A non-empty instruction describing the edit to apply.
        /// </param>
        /// <param name="references">
        /// An optional array of image references to guide the edit.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestGeminiOmniFlash(
            string videoUri,
            string promptText,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestGeminiOmniFlashReference>? references,
            string model = "gemini_omni_flash")
        {
            this.VideoUri = videoUri;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.References = references;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGeminiOmniFlash" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGeminiOmniFlash()
        {
        }

    }
}
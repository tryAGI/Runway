
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGeminiOmniFlash11
    {
        /// <summary>
        /// The input video to use as a reference, extend, or edit. Reference and edited videos may be up to 10 seconds and extended videos up to 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// A non-empty prompt describing the output or extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// How the input video is used. `reference` generates a new video guided by the input, `extend` continues it, and `edit` transforms it according to the prompt.<br/>
        /// Default Value: reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGeminiOmniFlash11ModeJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Mode? Mode { get; set; }

        /// <summary>
        /// The resolution and aspect ratio of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGeminiOmniFlash11RatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Ratio? Ratio { get; set; }

        /// <summary>
        /// The duration in seconds. In reference mode, this is the output video length. In extend mode, this is the amount of footage added to the input video. Use "auto" to let the model choose a duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, int?>))]
        public global::Runway.AnyOf<string, int?>? Duration { get; set; }

        /// <summary>
        /// An optional array of image references to guide the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Reference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gemini_omni_flash_1.1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_omni_flash_1.1";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGeminiOmniFlash11" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The input video to use as a reference, extend, or edit. Reference and edited videos may be up to 10 seconds and extended videos up to 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A non-empty prompt describing the output or extension.
        /// </param>
        /// <param name="mode">
        /// How the input video is used. `reference` generates a new video guided by the input, `extend` continues it, and `edit` transforms it according to the prompt.<br/>
        /// Default Value: reference
        /// </param>
        /// <param name="ratio">
        /// The resolution and aspect ratio of the output video.
        /// </param>
        /// <param name="duration">
        /// The duration in seconds. In reference mode, this is the output video length. In extend mode, this is the amount of footage added to the input video. Use "auto" to let the model choose a duration.
        /// </param>
        /// <param name="references">
        /// An optional array of image references to guide the output.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestGeminiOmniFlash11(
            string videoUri,
            string promptText,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Mode? mode,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Ratio? ratio,
            global::Runway.AnyOf<string, int?>? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11Reference>? references,
            string model = "gemini_omni_flash_1.1")
        {
            this.VideoUri = videoUri;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Mode = mode;
            this.Ratio = ratio;
            this.Duration = duration;
            this.References = references;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGeminiOmniFlash11" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGeminiOmniFlash11()
        {
        }

    }
}
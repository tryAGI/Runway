
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestKlingO3Standard
    {
        /// <summary>
        /// Provider-specific settings for multishot video generation and video editing.<br/>
        /// Default Value: {"keepOriginalSound":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSettings")]
        public global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettings? ProviderSettings { get; set; }

        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The input video to edit. Must be at most 10 seconds long, with width and height each between 720px and 3840px.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVideo { get; set; }

        /// <summary>
        /// An optional array of reference images (up to 4). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImage>>))]
        public global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImage>>? References { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3Standard" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text prompt describing what should appear in the output video.
        /// </param>
        /// <param name="promptVideo">
        /// The input video to edit. Must be at most 10 seconds long, with width and height each between 720px and 3840px.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="providerSettings">
        /// Provider-specific settings for multishot video generation and video editing.<br/>
        /// Default Value: {"keepOriginalSound":true}
        /// </param>
        /// <param name="references">
        /// An optional array of reference images (up to 4). See [our docs](/assets/inputs#images) on image inputs for more information.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestKlingO3Standard(
            string promptText,
            string promptVideo,
            global::Runway.CreateVideoToVideoRequestKlingO3StandardProviderSettings? providerSettings,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKlingO3StandardReferencesPromptImage>>? references,
            string model = "klingO3_standard")
        {
            this.ProviderSettings = providerSettings;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.PromptVideo = promptVideo;
            this.References = references;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3Standard" /> class.
        /// </summary>
        public CreateVideoToVideoRequestKlingO3Standard()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Provider-specific settings for multishot video generation and video editing.<br/>
    /// Default Value: {"keepOriginalSound":true}
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestKlingO3ProProviderSettings
    {
        /// <summary>
        /// An array of prompt segments for multishot video generation. Each segment has its own prompt and duration. Total duration across all segments must be between 3 and 15 seconds. `promptText` is still required when `shotType` is `"intelligence"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiPrompt")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKlingO3ProProviderSettingsMultiPromptItem>? MultiPrompt { get; set; }

        /// <summary>
        /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shotType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestKlingO3ProProviderSettingsShotTypeJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType? ShotType { get; set; }

        /// <summary>
        /// Whether to preserve the original audio when editing a video. Only applicable for video-to-video. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepOriginalSound")]
        public bool? KeepOriginalSound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3ProProviderSettings" /> class.
        /// </summary>
        /// <param name="multiPrompt">
        /// An array of prompt segments for multishot video generation. Each segment has its own prompt and duration. Total duration across all segments must be between 3 and 15 seconds. `promptText` is still required when `shotType` is `"intelligence"`.
        /// </param>
        /// <param name="shotType">
        /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
        /// </param>
        /// <param name="keepOriginalSound">
        /// Whether to preserve the original audio when editing a video. Only applicable for video-to-video. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestKlingO3ProProviderSettings(
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKlingO3ProProviderSettingsMultiPromptItem>? multiPrompt,
            global::Runway.CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType? shotType,
            bool? keepOriginalSound)
        {
            this.MultiPrompt = multiPrompt;
            this.ShotType = shotType;
            this.KeepOriginalSound = keepOriginalSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3ProProviderSettings" /> class.
        /// </summary>
        public CreateVideoToVideoRequestKlingO3ProProviderSettings()
        {
        }

    }
}
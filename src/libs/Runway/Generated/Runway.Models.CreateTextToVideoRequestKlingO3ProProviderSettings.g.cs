
#nullable enable

namespace Runway
{
    /// <summary>
    /// Provider-specific settings for multishot video generation.
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKlingO3ProProviderSettings
    {
        /// <summary>
        /// An array of prompt segments for multishot video generation. Each segment has its own prompt and duration. Total duration across all segments must be between 3 and 15 seconds. `promptText` is still required when `shotType` is `"intelligence"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiPrompt")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKlingO3ProProviderSettingsMultiPromptItem>? MultiPrompt { get; set; }

        /// <summary>
        /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shotType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKlingO3ProProviderSettingsShotTypeJsonConverter))]
        public global::Runway.CreateTextToVideoRequestKlingO3ProProviderSettingsShotType? ShotType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO3ProProviderSettings" /> class.
        /// </summary>
        /// <param name="multiPrompt">
        /// An array of prompt segments for multishot video generation. Each segment has its own prompt and duration. Total duration across all segments must be between 3 and 15 seconds. `promptText` is still required when `shotType` is `"intelligence"`.
        /// </param>
        /// <param name="shotType">
        /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestKlingO3ProProviderSettings(
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKlingO3ProProviderSettingsMultiPromptItem>? multiPrompt,
            global::Runway.CreateTextToVideoRequestKlingO3ProProviderSettingsShotType? shotType)
        {
            this.MultiPrompt = multiPrompt;
            this.ShotType = shotType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKlingO3ProProviderSettings" /> class.
        /// </summary>
        public CreateTextToVideoRequestKlingO3ProProviderSettings()
        {
        }

    }
}
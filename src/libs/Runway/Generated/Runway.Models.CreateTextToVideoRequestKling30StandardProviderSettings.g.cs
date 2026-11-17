
#nullable enable

namespace Runway
{
    /// <summary>
    /// Provider-specific settings for multishot video generation.
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKling30StandardProviderSettings
    {
        /// <summary>
        /// An array of prompt segments for multishot video generation. Each segment has its own prompt and duration. Total duration across all segments must be between 3 and 15 seconds. `promptText` is still required when `shotType` is `"intelligence"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiPrompt")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling30StandardProviderSettingsMultiPromptItem>? MultiPrompt { get; set; }

        /// <summary>
        /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shotType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKling30StandardProviderSettingsShotTypeJsonConverter))]
        public global::Runway.CreateTextToVideoRequestKling30StandardProviderSettingsShotType? ShotType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling30StandardProviderSettings" /> class.
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
        public CreateTextToVideoRequestKling30StandardProviderSettings(
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling30StandardProviderSettingsMultiPromptItem>? multiPrompt,
            global::Runway.CreateTextToVideoRequestKling30StandardProviderSettingsShotType? shotType)
        {
            this.MultiPrompt = multiPrompt;
            this.ShotType = shotType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling30StandardProviderSettings" /> class.
        /// </summary>
        public CreateTextToVideoRequestKling30StandardProviderSettings()
        {
        }

    }
}
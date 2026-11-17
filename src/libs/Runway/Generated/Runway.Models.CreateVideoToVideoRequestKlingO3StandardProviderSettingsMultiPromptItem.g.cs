
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestKlingO3StandardProviderSettingsMultiPromptItem
    {
        /// <summary>
        /// The text prompt for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Duration in seconds for this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3StandardProviderSettingsMultiPromptItem" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt for this segment.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds for this segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestKlingO3StandardProviderSettingsMultiPromptItem(
            string prompt,
            int duration)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKlingO3StandardProviderSettingsMultiPromptItem" /> class.
        /// </summary>
        public CreateVideoToVideoRequestKlingO3StandardProviderSettingsMultiPromptItem()
        {
        }

    }
}
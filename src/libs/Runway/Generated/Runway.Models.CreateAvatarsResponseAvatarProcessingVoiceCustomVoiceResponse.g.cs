
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom voice created via the Voices API.
    /// </summary>
    public sealed partial class CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// The unique identifier of the custom voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether the voice has been deleted. When true, name and description are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The display name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A brief description of the voice characteristics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the custom voice.
        /// </param>
        /// <param name="deleted">
        /// Whether the voice has been deleted. When true, name and description are omitted.
        /// </param>
        /// <param name="name">
        /// The display name of the voice.
        /// </param>
        /// <param name="description">
        /// A brief description of the voice characteristics.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse(
            global::System.Guid id,
            bool deleted,
            string? name,
            string? description,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
            this.Deleted = deleted;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse" /> class.
        /// </summary>
        public CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse()
        {
        }

    }
}
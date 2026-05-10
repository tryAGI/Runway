
#nullable enable

namespace Runway
{
    /// <summary>
    /// An avatar that is ready for use in sessions.
    /// </summary>
    public sealed partial class CreateAvatarsResponseAvatarReady
    {
        /// <summary>
        /// The unique identifier of the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The character name for the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// System prompt defining how the avatar should behave in conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Personality { get; set; }

        /// <summary>
        /// Opening message that the avatar will say when a session starts, or null if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startScript")]
        public string? StartScript { get; set; }

        /// <summary>
        /// The voice configured for this avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.Voice8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Voice8 Voice { get; set; }

        /// <summary>
        /// A URI pointing to a low-resolution preview of the avatar's reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImageUri")]
        public string? ReferenceImageUri { get; set; }

        /// <summary>
        /// A URI pointing to a low-resolution preview of the processed reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processedImageUri")]
        public string? ProcessedImageUri { get; set; }

        /// <summary>
        /// IDs of knowledge documents attached to this avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DocumentIds { get; set; }

        /// <summary>
        /// When the avatar was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the avatar was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"READY"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "READY";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsResponseAvatarReady" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the avatar.
        /// </param>
        /// <param name="name">
        /// The character name for the avatar.
        /// </param>
        /// <param name="personality">
        /// System prompt defining how the avatar should behave in conversations.
        /// </param>
        /// <param name="voice">
        /// The voice configured for this avatar.
        /// </param>
        /// <param name="documentIds">
        /// IDs of knowledge documents attached to this avatar.
        /// </param>
        /// <param name="createdAt">
        /// When the avatar was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the avatar was last updated.
        /// </param>
        /// <param name="startScript">
        /// Opening message that the avatar will say when a session starts, or null if not set.
        /// </param>
        /// <param name="referenceImageUri">
        /// A URI pointing to a low-resolution preview of the avatar's reference image.
        /// </param>
        /// <param name="processedImageUri">
        /// A URI pointing to a low-resolution preview of the processed reference image.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarsResponseAvatarReady(
            global::System.Guid id,
            string name,
            string personality,
            global::Runway.Voice8 voice,
            global::System.Collections.Generic.IList<global::System.Guid> documentIds,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? startScript,
            string? referenceImageUri,
            string? processedImageUri,
            string status = "READY")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Personality = personality ?? throw new global::System.ArgumentNullException(nameof(personality));
            this.StartScript = startScript;
            this.Voice = voice;
            this.ReferenceImageUri = referenceImageUri;
            this.ProcessedImageUri = processedImageUri;
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsResponseAvatarReady" /> class.
        /// </summary>
        public CreateAvatarsResponseAvatarReady()
        {
        }

    }
}
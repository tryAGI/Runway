
#nullable enable

namespace Runway
{
    /// <summary>
    /// Summary of a conversation for list responses.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseDataItem
    {
        /// <summary>
        /// Unique conversation identifier. This is the same value as the realtime session ID for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Conversation name (auto-generated or user-provided).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The status of the conversation. `in_progress` means the session is active, `ended` means it completed successfully, `failed` means it ended due to an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetAvatarConversationsResponseDataItemStatus Status { get; set; }

        /// <summary>
        /// The avatar used in this conversation, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public global::Runway.AvatarVariant1? Avatar { get; set; }

        /// <summary>
        /// When the conversation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Duration of the conversation in seconds, or null if not started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Whether tools were configured for this conversation session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasTools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique conversation identifier. This is the same value as the realtime session ID for the call.
        /// </param>
        /// <param name="name">
        /// Conversation name (auto-generated or user-provided).
        /// </param>
        /// <param name="status">
        /// The status of the conversation. `in_progress` means the session is active, `ended` means it completed successfully, `failed` means it ended due to an error.
        /// </param>
        /// <param name="createdAt">
        /// When the conversation was created.
        /// </param>
        /// <param name="hasTools">
        /// Whether tools were configured for this conversation session.
        /// </param>
        /// <param name="avatar">
        /// The avatar used in this conversation, or null if unavailable.
        /// </param>
        /// <param name="duration">
        /// Duration of the conversation in seconds, or null if not started.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseDataItem(
            global::System.Guid id,
            string name,
            global::Runway.GetAvatarConversationsResponseDataItemStatus status,
            global::System.DateTime createdAt,
            bool hasTools,
            global::Runway.AvatarVariant1? avatar,
            int? duration)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Avatar = avatar;
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.HasTools = hasTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItem" /> class.
        /// </summary>
        public GetAvatarConversationsResponseDataItem()
        {
        }

    }
}
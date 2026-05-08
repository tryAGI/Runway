
#nullable enable

namespace Runway
{
    /// <summary>
    /// A conversation that completed successfully.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant2
    {
        /// <summary>
        /// Unique conversation identifier. This is the same value as the realtime session ID for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Conversation name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The avatar used in this conversation, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public global::Runway.AvatarVariant13? Avatar { get; set; }

        /// <summary>
        /// When the conversation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Maximum allowed duration in seconds, or null if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// The conversation transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItem> Transcript { get; set; }

        /// <summary>
        /// A URL to download the conversation recording, or null if no recording is available. This URL will expire within 24-48 hours, fetch the conversation again to get a fresh download URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUrl")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// The tools that were configured for this conversation session. Empty if no tools were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2Tool> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"ended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "ended";

        /// <summary>
        /// When the conversation started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the conversation ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Duration of the conversation in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique conversation identifier. This is the same value as the realtime session ID for the call.
        /// </param>
        /// <param name="name">
        /// Conversation name.
        /// </param>
        /// <param name="createdAt">
        /// When the conversation was created.
        /// </param>
        /// <param name="transcript">
        /// The conversation transcript.
        /// </param>
        /// <param name="tools">
        /// The tools that were configured for this conversation session. Empty if no tools were used.
        /// </param>
        /// <param name="avatar">
        /// The avatar used in this conversation, or null if unavailable.
        /// </param>
        /// <param name="maxDuration">
        /// Maximum allowed duration in seconds, or null if not set.
        /// </param>
        /// <param name="recordingUrl">
        /// A URL to download the conversation recording, or null if no recording is available. This URL will expire within 24-48 hours, fetch the conversation again to get a fresh download URL.
        /// </param>
        /// <param name="startedAt">
        /// When the conversation started.
        /// </param>
        /// <param name="endedAt">
        /// When the conversation ended.
        /// </param>
        /// <param name="duration">
        /// Duration of the conversation in seconds.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant2(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItem> transcript,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2Tool> tools,
            global::Runway.AvatarVariant13? avatar,
            int? maxDuration,
            string? recordingUrl,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? duration,
            string status = "ended")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Avatar = avatar;
            this.CreatedAt = createdAt;
            this.MaxDuration = maxDuration;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.RecordingUrl = recordingUrl;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Status = status;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant2()
        {
        }
    }
}
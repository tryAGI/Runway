
#nullable enable

namespace Runway
{
    /// <summary>
    /// A conversation that is currently active.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant1
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
        public global::Runway.AvatarVariant12? Avatar { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItem> Transcript { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1Tool> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"in_progress"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "in_progress";

        /// <summary>
        /// When the conversation started, or null if not yet started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Elapsed duration in seconds, or null if not yet started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1" /> class.
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
        /// When the conversation started, or null if not yet started.
        /// </param>
        /// <param name="duration">
        /// Elapsed duration in seconds, or null if not yet started.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant1(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItem> transcript,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1Tool> tools,
            global::Runway.AvatarVariant12? avatar,
            int? maxDuration,
            string? recordingUrl,
            global::System.DateTime? startedAt,
            int? duration,
            string status = "in_progress")
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
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant1()
        {
        }
    }
}
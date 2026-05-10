
#nullable enable

namespace Runway
{
    /// <summary>
    /// A conversation that ended due to an error.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant3
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
        public global::Runway.AvatarVariant14? Avatar { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem> Transcript { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3Tool> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "failed";

        /// <summary>
        /// When the conversation started, or null if it failed before starting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the conversation ended, or null if it failed before starting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Duration in seconds, or null if the conversation failed before starting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Failure { get; set; }

        /// <summary>
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant3" /> class.
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
        /// <param name="failure">
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </param>
        /// <param name="failureCode">
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
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
        /// When the conversation started, or null if it failed before starting.
        /// </param>
        /// <param name="endedAt">
        /// When the conversation ended, or null if it failed before starting.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds, or null if the conversation failed before starting.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant3(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem> transcript,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3Tool> tools,
            string failure,
            string failureCode,
            global::Runway.AvatarVariant14? avatar,
            int? maxDuration,
            string? recordingUrl,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? duration,
            string status = "failed")
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
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
            this.FailureCode = failureCode ?? throw new global::System.ArgumentNullException(nameof(failureCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant3" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant3()
        {
        }

    }
}
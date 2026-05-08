
#nullable enable

namespace Runway
{
    /// <summary>
    /// A single entry in the conversation transcript.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant2TranscriptItem
    {
        /// <summary>
        /// Who produced this transcript entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole Role { get; set; }

        /// <summary>
        /// The spoken text, or null for tool-only turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// When this entry occurred, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Tool invocations made during this assistant turn. Only present on assistant entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Tool results received during this assistant turn. Only present on assistant entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolResults")]
        public global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolResult>? ToolResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2TranscriptItem" /> class.
        /// </summary>
        /// <param name="role">
        /// Who produced this transcript entry.
        /// </param>
        /// <param name="content">
        /// The spoken text, or null for tool-only turns.
        /// </param>
        /// <param name="timestamp">
        /// When this entry occurred, or null if unavailable.
        /// </param>
        /// <param name="toolCalls">
        /// Tool invocations made during this assistant turn. Only present on assistant entries.
        /// </param>
        /// <param name="toolResults">
        /// Tool results received during this assistant turn. Only present on assistant entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant2TranscriptItem(
            global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole role,
            string? content,
            global::System.DateTime? timestamp,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolResult>? toolResults)
        {
            this.Role = role;
            this.Content = content;
            this.Timestamp = timestamp;
            this.ToolCalls = toolCalls;
            this.ToolResults = toolResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2TranscriptItem" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant2TranscriptItem()
        {
        }
    }
}
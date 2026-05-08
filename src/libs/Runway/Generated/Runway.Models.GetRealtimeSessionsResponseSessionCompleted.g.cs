
#nullable enable

namespace Runway
{
    /// <summary>
    /// A session that ended normally.
    /// </summary>
    public sealed partial class GetRealtimeSessionsResponseSessionCompleted
    {
        /// <summary>
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// When the session was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"COMPLETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "COMPLETED";

        /// <summary>
        /// The session duration in seconds.
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
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionCompleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </param>
        /// <param name="createdAt">
        /// When the session was created.
        /// </param>
        /// <param name="duration">
        /// The session duration in seconds.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRealtimeSessionsResponseSessionCompleted(
            global::System.Guid id,
            global::System.DateTime createdAt,
            int duration,
            string status = "COMPLETED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionCompleted" /> class.
        /// </summary>
        public GetRealtimeSessionsResponseSessionCompleted()
        {
        }
    }
}
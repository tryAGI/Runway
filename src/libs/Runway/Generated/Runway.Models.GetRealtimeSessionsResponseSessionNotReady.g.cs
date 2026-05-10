
#nullable enable

namespace Runway
{
    /// <summary>
    /// A session that is being provisioned.
    /// </summary>
    public sealed partial class GetRealtimeSessionsResponseSessionNotReady
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
        /// <default>"NOT_READY"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "NOT_READY";

        /// <summary>
        /// When true, the session is waiting in a queue for available capacity. When false or absent, the session is actively being provisioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued")]
        public bool? Queued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionNotReady" /> class.
        /// </summary>
        /// <param name="id">
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </param>
        /// <param name="createdAt">
        /// When the session was created.
        /// </param>
        /// <param name="queued">
        /// When true, the session is waiting in a queue for available capacity. When false or absent, the session is actively being provisioned.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRealtimeSessionsResponseSessionNotReady(
            global::System.Guid id,
            global::System.DateTime createdAt,
            bool? queued,
            string status = "NOT_READY")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Queued = queued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionNotReady" /> class.
        /// </summary>
        public GetRealtimeSessionsResponseSessionNotReady()
        {
        }

    }
}
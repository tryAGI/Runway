
#nullable enable

namespace Runway
{
    /// <summary>
    /// A session that is ready to connect.
    /// </summary>
    public sealed partial class GetRealtimeSessionsResponseSessionReady
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
        /// <default>"READY"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "READY";

        /// <summary>
        /// When the session credentials expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Session key for authenticating the /consume endpoint. Use as Bearer token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionReady" /> class.
        /// </summary>
        /// <param name="id">
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </param>
        /// <param name="createdAt">
        /// When the session was created.
        /// </param>
        /// <param name="expiresAt">
        /// When the session credentials expire.
        /// </param>
        /// <param name="sessionKey">
        /// Session key for authenticating the /consume endpoint. Use as Bearer token.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRealtimeSessionsResponseSessionReady(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            string sessionKey,
            string status = "READY")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionReady" /> class.
        /// </summary>
        public GetRealtimeSessionsResponseSessionReady()
        {
        }

    }
}
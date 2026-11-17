
#nullable enable

namespace Runway
{
    /// <summary>
    /// Use integration with type "livekit" instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateRealtimeSessionsRequestGwm1AvatarsLivekit
    {
        /// <summary>
        /// WebSocket URL of the external LiveKit server the avatar worker should join. Must be a wss:// or https:// URL that resolves to a public host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Url { get; set; }

        /// <summary>
        /// LiveKit access token granting the avatar worker publish rights in the external room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Token { get; set; }

        /// <summary>
        /// Name of the external LiveKit room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string RoomName { get; set; }

        /// <summary>
        /// The participant identity of the customer agent already in the room. When provided, the avatar worker trusts audio published by this identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentIdentity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AgentIdentity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsLivekit" /> class.
        /// </summary>
        /// <param name="url">
        /// WebSocket URL of the external LiveKit server the avatar worker should join. Must be a wss:// or https:// URL that resolves to a public host.
        /// </param>
        /// <param name="token">
        /// LiveKit access token granting the avatar worker publish rights in the external room.
        /// </param>
        /// <param name="roomName">
        /// Name of the external LiveKit room.
        /// </param>
        /// <param name="agentIdentity">
        /// The participant identity of the customer agent already in the room. When provided, the avatar worker trusts audio published by this identity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestGwm1AvatarsLivekit(
            string url,
            string token,
            string roomName,
            string? agentIdentity)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.AgentIdentity = agentIdentity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsLivekit" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestGwm1AvatarsLivekit()
        {
        }

    }
}
#nullable enable

namespace Runway;

/// <summary>
/// WebRTC connection credentials returned by realtime session consume/connect endpoints.
/// </summary>
public sealed class RealtimeSessionConnectionCredentials
{
    /// <summary>
    /// WebRTC server URL.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("url")]
    [global::System.Text.Json.Serialization.JsonRequired]
    public required global::System.Uri Url { get; set; }

    /// <summary>
    /// Authentication token for the WebRTC room.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("token")]
    [global::System.Text.Json.Serialization.JsonRequired]
    public required string Token { get; set; }

    /// <summary>
    /// WebRTC room name for the realtime session.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("roomName")]
    [global::System.Text.Json.Serialization.JsonRequired]
    public required string RoomName { get; set; }
}

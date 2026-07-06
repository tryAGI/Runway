#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Runway
{
    public partial interface IRealtimeSessionsClient
    {
        /// <summary>
        /// Create realtime session<br/>
        /// Create a new realtime session with the specified model configuration. The returned ID is also the conversation ID used later to fetch transcripts and recordings from the avatar conversation endpoints.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const session = await client.realtimeSessions.create({<br/>
        ///   model: 'gwm1_avatars',<br/>
        ///   avatar: {<br/>
        ///     type: 'custom',<br/>
        ///     avatarId: '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(session.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRealtimeSessionsResponse> CreateRealtimeSessionsAsync(

            global::Runway.CreateRealtimeSessionsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create realtime session<br/>
        /// Create a new realtime session with the specified model configuration. The returned ID is also the conversation ID used later to fetch transcripts and recordings from the avatar conversation endpoints.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const session = await client.realtimeSessions.create({<br/>
        ///   model: 'gwm1_avatars',<br/>
        ///   avatar: {<br/>
        ///     type: 'custom',<br/>
        ///     avatarId: '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(session.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRealtimeSessionsResponse>> CreateRealtimeSessionsAsResponseAsync(

            global::Runway.CreateRealtimeSessionsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create realtime session<br/>
        /// Create a new realtime session with the specified model configuration. The returned ID is also the conversation ID used later to fetch transcripts and recordings from the avatar conversation endpoints.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="model">
        /// The realtime session model type.
        /// </param>
        /// <param name="avatar">
        /// The avatar configuration for the session.
        /// </param>
        /// <param name="maxDuration">
        /// Maximum session duration in seconds.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="personality">
        /// Override the avatar personality for this session. If not provided, uses the avatar default.
        /// </param>
        /// <param name="startScript">
        /// Override the avatar start script for this session. If not provided, uses the avatar default.
        /// </param>
        /// <param name="tools">
        /// Tools available to the avatar during the session.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="integration">
        /// External integration. Runway renders the avatar; the integration owns conversation or audio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRealtimeSessionsResponse> CreateRealtimeSessionsAsync(
            global::Runway.Avatar2 avatar,
            string xRunwayVersion = "2024-11-06",
            string model = "gwm1_avatars",
            int? maxDuration = default,
            string? personality = default,
            string? startScript = default,
            global::System.Collections.Generic.IList<global::Runway.ToolsItem>? tools = default,
            global::Runway.Integration? integration = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
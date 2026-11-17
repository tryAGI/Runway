#nullable enable

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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRealtimeSessionsResponse> CreateRealtimeSessionsAsync(
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
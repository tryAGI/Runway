#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// List conversations<br/>
        /// List realtime avatar conversations for the authenticated user with cursor-based pagination. Each conversation corresponds to a realtime session, and the conversation ID matches the realtime session ID. Pass `avatar` to restrict results to a single avatar.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// for await (const conversation of client.avatarConversations.list()) {<br/>
        ///   console.log(conversation.name, conversation.avatar?.name, conversation.status);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.GetAvatarConversationsResponse> GetAvatarConversationsAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? avatar = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List conversations<br/>
        /// List realtime avatar conversations for the authenticated user with cursor-based pagination. Each conversation corresponds to a realtime session, and the conversation ID matches the realtime session ID. Pass `avatar` to restrict results to a single avatar.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// for await (const conversation of client.avatarConversations.list()) {<br/>
        ///   console.log(conversation.name, conversation.avatar?.name, conversation.status);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetAvatarConversationsResponse>> GetAvatarConversationsAsResponseAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? avatar = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
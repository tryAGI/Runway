#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Get conversation<br/>
        /// Get detailed information about a specific conversation, including the transcript and recording download URL when available. The conversation ID is the same value returned when the realtime session was created.
        /// </summary>
        /// <param name="id"></param>
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
        /// const conversation = await client.avatarConversations.retrieve(<br/>
        ///   '660e8400-e29b-41d4-a716-446655440001'<br/>
        /// );<br/>
        /// console.log(conversation.status, conversation.transcript);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.GetAvatarConversationsResponse2> GetAvatarConversationsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get conversation<br/>
        /// Get detailed information about a specific conversation, including the transcript and recording download URL when available. The conversation ID is the same value returned when the realtime session was created.
        /// </summary>
        /// <param name="id"></param>
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
        /// const conversation = await client.avatarConversations.retrieve(<br/>
        ///   '660e8400-e29b-41d4-a716-446655440001'<br/>
        /// );<br/>
        /// console.log(conversation.status, conversation.transcript);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetAvatarConversationsResponse2>> GetAvatarConversationsByIdAsResponseAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
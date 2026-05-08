#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Get avatar<br/>
        /// Get details of a specific avatar.
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
        /// const avatar = await client.avatars.retrieve(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000'<br/>
        /// );<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.GetAvatarsResponse2> GetAvatarsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get avatar<br/>
        /// Get details of a specific avatar.
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
        /// const avatar = await client.avatars.retrieve(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000'<br/>
        /// );<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetAvatarsResponse2>> GetAvatarsByIdAsResponseAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
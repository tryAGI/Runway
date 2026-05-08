#nullable enable

namespace Runway
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update a voice<br/>
        /// Update the name and/or description of a custom voice.
        /// </summary>
        /// <param name="id"></param>
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
        /// const voice = await client.voices.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'My Updated Voice' },<br/>
        /// );<br/>
        /// console.log(voice.name);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.PatchVoicesResponse> EditVoicesByIdAsync(
            global::System.Guid id,

            global::Runway.PatchVoicesRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a voice<br/>
        /// Update the name and/or description of a custom voice.
        /// </summary>
        /// <param name="id"></param>
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
        /// const voice = await client.voices.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'My Updated Voice' },<br/>
        /// );<br/>
        /// console.log(voice.name);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.PatchVoicesResponse>> EditVoicesByIdAsResponseAsync(
            global::System.Guid id,

            global::Runway.PatchVoicesRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a voice<br/>
        /// Update the name and/or description of a custom voice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// A name for the voice.
        /// </param>
        /// <param name="description">
        /// An optional description of the voice.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.PatchVoicesResponse> EditVoicesByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            string? name = default,
            string? description = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
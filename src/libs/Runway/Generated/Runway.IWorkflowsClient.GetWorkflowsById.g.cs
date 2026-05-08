#nullable enable

namespace Runway
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow details<br/>
        /// Returns details about a specific published workflow, including its graph schema.
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
        /// const workflow = await client.workflows.retrieve(<br/>
        ///   'a1b2c3d4-e5f6-7890-abcd-ef1234567890'<br/>
        /// );<br/>
        /// console.log(workflow);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.GetWorkflowsResponse> GetWorkflowsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workflow details<br/>
        /// Returns details about a specific published workflow, including its graph schema.
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
        /// const workflow = await client.workflows.retrieve(<br/>
        ///   'a1b2c3d4-e5f6-7890-abcd-ef1234567890'<br/>
        /// );<br/>
        /// console.log(workflow);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetWorkflowsResponse>> GetWorkflowsByIdAsResponseAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
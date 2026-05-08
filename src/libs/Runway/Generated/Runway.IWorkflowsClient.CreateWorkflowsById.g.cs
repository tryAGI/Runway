#nullable enable

namespace Runway
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Run a published workflow<br/>
        /// Start a new task to execute a published workflow. You can optionally provide custom input values via `nodeOutputs` to override the defaults defined in the workflow graph.
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
        /// const { id } = await client.workflows.run('YOUR_WORKFLOW_ID', {<br/>
        ///   nodeOutputs: {<br/>
        ///     'node-uuid': {<br/>
        ///       // For text/number/boolean values, use type: 'primitive'<br/>
        ///       'prompt': { type: 'primitive', value: 'A beautiful sunset' },<br/>
        ///       // For media assets, use type: 'image', 'video', or 'audio'<br/>
        ///       'image': { type: 'image', uri: 'https://example.com/image.jpg' },<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// // Then poll for the workflow result<br/>
        /// const invocation = await client.workflowInvocations<br/>
        ///   .retrieve(id)<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(invocation);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateWorkflowsResponse> CreateWorkflowsByIdAsync(
            global::System.Guid id,

            global::Runway.CreateWorkflowsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a published workflow<br/>
        /// Start a new task to execute a published workflow. You can optionally provide custom input values via `nodeOutputs` to override the defaults defined in the workflow graph.
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
        /// const { id } = await client.workflows.run('YOUR_WORKFLOW_ID', {<br/>
        ///   nodeOutputs: {<br/>
        ///     'node-uuid': {<br/>
        ///       // For text/number/boolean values, use type: 'primitive'<br/>
        ///       'prompt': { type: 'primitive', value: 'A beautiful sunset' },<br/>
        ///       // For media assets, use type: 'image', 'video', or 'audio'<br/>
        ///       'image': { type: 'image', uri: 'https://example.com/image.jpg' },<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// // Then poll for the workflow result<br/>
        /// const invocation = await client.workflowInvocations<br/>
        ///   .retrieve(id)<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(invocation);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateWorkflowsResponse>> CreateWorkflowsByIdAsResponseAsync(
            global::System.Guid id,

            global::Runway.CreateWorkflowsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a published workflow<br/>
        /// Start a new task to execute a published workflow. You can optionally provide custom input values via `nodeOutputs` to override the defaults defined in the workflow graph.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="nodeOutputs">
        /// Optional node outputs to override default values. Keys are node IDs from the workflow graph, values are objects mapping output keys to typed values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateWorkflowsResponse> CreateWorkflowsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::System.Collections.Generic.Dictionary<string, object>? nodeOutputs = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
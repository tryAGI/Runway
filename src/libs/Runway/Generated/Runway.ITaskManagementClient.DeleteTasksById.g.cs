#nullable enable

namespace Runway
{
    public partial interface ITaskManagementClient
    {
        /// <summary>
        /// Cancel or delete a task<br/>
        /// Tasks that are running, pending, or throttled can be canceled by invoking this method. Invoking this method for other tasks will delete them.<br/>
        /// Refund eligibility is based on the task status observed by the server during cancellation. If that check observes RUNNING, cancellation does not refund credits. Task execution can advance concurrently with cancellation, so neither a refund nor successful cancellation guarantees that generation stops. A prior GET response reporting PENDING or THROTTLED does not guarantee a refund. Deleting a completed task does not refund its charge.<br/>
        /// The output data associated with a deleted task will be deleted from persistent storage in accordance with our data retention policy. Aborted and deleted tasks will not be able to be fetched again in the future.
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
        /// await client.tasks.delete('17f20503-6c24-4c16-946b-35dbbce2af2f');
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteTasksByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel or delete a task<br/>
        /// Tasks that are running, pending, or throttled can be canceled by invoking this method. Invoking this method for other tasks will delete them.<br/>
        /// Refund eligibility is based on the task status observed by the server during cancellation. If that check observes RUNNING, cancellation does not refund credits. Task execution can advance concurrently with cancellation, so neither a refund nor successful cancellation guarantees that generation stops. A prior GET response reporting PENDING or THROTTLED does not guarantee a refund. Deleting a completed task does not refund its charge.<br/>
        /// The output data associated with a deleted task will be deleted from persistent storage in accordance with our data retention policy. Aborted and deleted tasks will not be able to be fetched again in the future.
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
        /// await client.tasks.delete('17f20503-6c24-4c16-946b-35dbbce2af2f');
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse> DeleteTasksByIdAsResponseAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
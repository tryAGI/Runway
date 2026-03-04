#nullable enable

namespace Runway
{
    public partial interface ITaskManagementClient
    {
        /// <summary>
        /// Get task detail<br/>
        /// Return details about a task. Consumers of this API should not expect updates more frequent than once every five seconds for a given task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response> GetTasksByIdAsync(
            global::System.Guid id,
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
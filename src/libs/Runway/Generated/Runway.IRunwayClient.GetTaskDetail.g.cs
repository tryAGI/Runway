#nullable enable

namespace Runway
{
    public partial interface IRunwayClient
    {
        /// <summary>
        /// Get task detail.<br/>
        /// Return details about a task. Updates every 5 seconds.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetTaskDetailResponse> GetTaskDetailAsync(
            global::Runway.GetTaskDetailXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
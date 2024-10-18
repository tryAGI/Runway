#nullable enable

namespace Runway
{
    public partial interface IRunwayClient
    {
        /// <summary>
        /// Cancel or delete a task.<br/>
        /// Cancel a running task or delete a completed one.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CancelOrDeleteTaskAsync(
            global::Runway.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
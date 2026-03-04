#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Voice isolation<br/>
        /// This endpoint will start a new task to isolate the voice from the background audio. Audio duration must be greater than 4.6 seconds and less than 3600 seconds.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response21> CreateVoiceIsolationAsync(
            string xRunwayVersion,
            global::Runway.Request10 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Voice isolation<br/>
        /// This endpoint will start a new task to isolate the voice from the background audio. Audio duration must be greater than 4.6 seconds and less than 3600 seconds.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response21> CreateVoiceIsolationAsync(
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
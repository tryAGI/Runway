#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Video to video<br/>
        /// This endpoint will start a new task to generate a video from a video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response7> CreateVideoToVideoAsync(
            string xRunwayVersion,
            global::Runway.Request3 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Video to video<br/>
        /// This endpoint will start a new task to generate a video from a video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response7> CreateVideoToVideoAsync(
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
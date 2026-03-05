#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Image to video<br/>
        /// This endpoint will start a new task to generate a video from an image.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response3> CreateImageToVideoAsync(

            global::Runway.Request request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Image to video<br/>
        /// This endpoint will start a new task to generate a video from an image.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response3> CreateImageToVideoAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
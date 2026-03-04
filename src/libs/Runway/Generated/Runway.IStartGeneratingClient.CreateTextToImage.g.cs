#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Text/Image to Image<br/>
        /// This endpoint will start a new task to generate images from text and/or image(s)
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response9> CreateTextToImageAsync(
            string xRunwayVersion,
            global::Runway.Request4 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Text/Image to Image<br/>
        /// This endpoint will start a new task to generate images from text and/or image(s)
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response9> CreateTextToImageAsync(
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
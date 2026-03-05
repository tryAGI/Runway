#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Control a character<br/>
        /// This endpoint will start a new task to control a character's facial expressions and body movements using a reference video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response11> CreateCharacterPerformanceAsync(

            global::Runway.Request5 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Control a character<br/>
        /// This endpoint will start a new task to control a character's facial expressions and body movements using a reference video.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response11> CreateCharacterPerformanceAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
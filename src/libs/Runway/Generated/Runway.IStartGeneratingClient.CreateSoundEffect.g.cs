#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Generate sound effects<br/>
        /// This endpoint will start a new task to generate sound effects from a text description.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response13> CreateSoundEffectAsync(
            string xRunwayVersion,
            global::Runway.Request6 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate sound effects<br/>
        /// This endpoint will start a new task to generate sound effects from a text description.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response13> CreateSoundEffectAsync(
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
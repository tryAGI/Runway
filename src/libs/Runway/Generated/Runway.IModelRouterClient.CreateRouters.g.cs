#nullable enable

namespace Runway
{
    public partial interface IModelRouterClient
    {
        /// <summary>
        /// Create Model Router<br/>
        /// Create a Model Router configuration.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const router = await client.routers.create({<br/>
        ///   slug: 'preview-fast',<br/>
        ///   name: 'Preview (fast)',<br/>
        ///   settings: {<br/>
        ///     optimizeFor: 'cost',<br/>
        ///   },<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRoutersResponse> CreateRoutersAsync(

            global::Runway.CreateRoutersRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Router<br/>
        /// Create a Model Router configuration.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const router = await client.routers.create({<br/>
        ///   slug: 'preview-fast',<br/>
        ///   name: 'Preview (fast)',<br/>
        ///   settings: {<br/>
        ///     optimizeFor: 'cost',<br/>
        ///   },<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRoutersResponse>> CreateRoutersAsResponseAsync(

            global::Runway.CreateRoutersRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Router<br/>
        /// Create a Model Router configuration.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="slug">
        /// Immutable slug used to reference this Model Router in generation requests (for example, production-video). Unique within the API project. The UUID id remains the canonical management identifier.
        /// </param>
        /// <param name="name">
        /// Optional human-readable display name for this router. Defaults to the slug when omitted.
        /// </param>
        /// <param name="description">
        /// An optional Model Router description.
        /// </param>
        /// <param name="settings">
        /// Model Router routing preferences. Defaults to cost-optimized allow-all when omitted. Modality is implied by the generate endpoint used with this Model Router.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRoutersResponse> CreateRoutersAsync(
            string slug,
            string xRunwayVersion = "2024-11-06",
            string? name = default,
            string? description = default,
            global::Runway.CreateRoutersRequestSettings? settings = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create product campaign images<br/>
        /// Generate four fashion campaign images from a product image and style brief.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.recipes.productCampaignImage({<br/>
        ///   version: '2026-06',<br/>
        ///   image: { uri: 'https://example.com/product.jpg' },<br/>
        ///   prompt: 'High-key fashion editorial, gorpcore-meets-blokecore-meets-Y2K',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductCampaignImageResponse> CreateRecipesProductCampaignImageAsync(

            global::Runway.CreateRecipesProductCampaignImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create product campaign images<br/>
        /// Generate four fashion campaign images from a product image and style brief.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.recipes.productCampaignImage({<br/>
        ///   version: '2026-06',<br/>
        ///   image: { uri: 'https://example.com/product.jpg' },<br/>
        ///   prompt: 'High-key fashion editorial, gorpcore-meets-blokecore-meets-Y2K',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductCampaignImageResponse>> CreateRecipesProductCampaignImageAsResponseAsync(

            global::Runway.CreateRecipesProductCampaignImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create product campaign images<br/>
        /// Generate four fashion campaign images from a product image and style brief.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="image">
        /// Product image to preserve across the generated campaign. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="prompt">
        /// Style / creative brief for the fashion campaign, e.g. "High-key fashion editorial, gorpcore-meets-blokecore-meets-Y2K".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductCampaignImageResponse> CreateRecipesProductCampaignImageAsync(
            global::Runway.CreateRecipesProductCampaignImageRequestVersion version,
            global::Runway.CreateRecipesProductCampaignImageRequestImage image,
            string prompt,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
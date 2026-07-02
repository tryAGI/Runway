#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create a marketing stock image<br/>
        /// Generate a polished marketing stock image from a text brief and optional brand logo image.
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
        /// const task = await client.recipes.marketingStockImage({<br/>
        ///   version: '2026-06',<br/>
        ///   prompt: 'Premium lifestyle photo for a sustainable travel backpack campaign, urban morning commute, natural copy space on the left',<br/>
        ///   referenceImage: { uri: 'https://example.com/brand-logo.png' },<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesMarketingStockImageResponse> CreateRecipesMarketingStockImageAsync(

            global::Runway.CreateRecipesMarketingStockImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a marketing stock image<br/>
        /// Generate a polished marketing stock image from a text brief and optional brand logo image.
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
        /// const task = await client.recipes.marketingStockImage({<br/>
        ///   version: '2026-06',<br/>
        ///   prompt: 'Premium lifestyle photo for a sustainable travel backpack campaign, urban morning commute, natural copy space on the left',<br/>
        ///   referenceImage: { uri: 'https://example.com/brand-logo.png' },<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesMarketingStockImageResponse>> CreateRecipesMarketingStockImageAsResponseAsync(

            global::Runway.CreateRecipesMarketingStockImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a marketing stock image<br/>
        /// Generate a polished marketing stock image from a text brief and optional brand logo image.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="prompt">
        /// Marketing image brief. Describe the subject, audience, channel, desired mood, setting, and any constraints.
        /// </param>
        /// <param name="referenceImage">
        /// Optional brand logo image to guide the generated marketing stock image. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate (1–4). Defaults to 4. Increasing this number affects credits consumed.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="quality">
        /// GPT Image 2 rendering quality (`low`, `medium`, or `high`). Lower settings are faster and use fewer credits; `high` (default) is slowest and highest fidelity.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesMarketingStockImageResponse> CreateRecipesMarketingStockImageAsync(
            global::Runway.CreateRecipesMarketingStockImageRequestVersion version,
            string prompt,
            string xRunwayVersion = "2024-11-06",
            global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage? referenceImage = default,
            int? outputCount = default,
            global::Runway.CreateRecipesMarketingStockImageRequestQuality? quality = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
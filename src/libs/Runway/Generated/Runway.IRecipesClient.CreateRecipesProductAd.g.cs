#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create a product ad video<br/>
        /// Generate a cinematic product ad from product images, optional style references, product info, and creative direction.
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
        /// const task = await client.recipes.productAd({<br/>
        ///   version: '2026-06',<br/>
        ///   productImages: [<br/>
        ///     { uri: 'https://example.com/product-front.jpg' },<br/>
        ///     { uri: 'https://example.com/product-side.jpg' },<br/>
        ///   ],<br/>
        ///   productInfo: 'Organic cold-pressed juice, 12oz glass bottle',<br/>
        ///   userConcept: 'Bright, refreshing summer campaign with slow dolly moves',<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductAdResponse> CreateRecipesProductAdAsync(

            global::Runway.CreateRecipesProductAdRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a product ad video<br/>
        /// Generate a cinematic product ad from product images, optional style references, product info, and creative direction.
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
        /// const task = await client.recipes.productAd({<br/>
        ///   version: '2026-06',<br/>
        ///   productImages: [<br/>
        ///     { uri: 'https://example.com/product-front.jpg' },<br/>
        ///     { uri: 'https://example.com/product-side.jpg' },<br/>
        ///   ],<br/>
        ///   productInfo: 'Organic cold-pressed juice, 12oz glass bottle',<br/>
        ///   userConcept: 'Bright, refreshing summer campaign with slow dolly moves',<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductAdResponse>> CreateRecipesProductAdAsResponseAsync(

            global::Runway.CreateRecipesProductAdRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a product ad video<br/>
        /// Generate a cinematic product ad from product images, optional style references, product info, and creative direction.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="productImages">
        /// Product images (1–10). Multiple angles of the same product. All images inform product analysis and reference generation; only the first image is used as the primary product reference in the storyboard grid. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="styleImages">
        /// Optional style reference images (0–4). Defines the visual treatment (lighting, palette, mood). Treated as a moodboard when multiple are provided.
        /// </param>
        /// <param name="productInfo">
        /// Optional product description and specifications to inform creative direction and which product elements to highlight.
        /// </param>
        /// <param name="userConcept">
        /// Optional creative direction describing brand voice, product framing, scene specifics, lighting, camera motion, and narrative.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductAdResponse> CreateRecipesProductAdAsync(
            global::Runway.CreateRecipesProductAdRequestVersion version,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage> productImages,
            string xRunwayVersion = "2024-11-06",
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>? styleImages = default,
            string? productInfo = default,
            string? userConcept = default,
            global::Runway.CreateRecipesProductAdRequestRatio? ratio = default,
            int? duration = default,
            bool? audio = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
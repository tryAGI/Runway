#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
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
        /// const task = await client.recipes.productSwap({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceVideo: { uri: 'https://example.com/reference-ad.mp4' },<br/>
        ///   originalProductImage: { uri: 'https://example.com/original-product.jpg' },<br/>
        ///   newProductImages: [<br/>
        ///     { uri: 'https://example.com/new-product-front.jpg', view: 'front' },<br/>
        ///     { uri: 'https://example.com/new-product-side.jpg', view: 'side' },<br/>
        ///   ],<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductSwapResponse> CreateRecipesProductSwapAsync(

            global::Runway.CreateRecipesProductSwapRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
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
        /// const task = await client.recipes.productSwap({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceVideo: { uri: 'https://example.com/reference-ad.mp4' },<br/>
        ///   originalProductImage: { uri: 'https://example.com/original-product.jpg' },<br/>
        ///   newProductImages: [<br/>
        ///     { uri: 'https://example.com/new-product-front.jpg', view: 'front' },<br/>
        ///     { uri: 'https://example.com/new-product-side.jpg', view: 'side' },<br/>
        ///   ],<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductSwapResponse>> CreateRecipesProductSwapAsResponseAsync(

            global::Runway.CreateRecipesProductSwapRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="referenceVideo">
        /// Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.
        /// </param>
        /// <param name="originalProductImage">
        /// Image of the original product being swapped out. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="newProductImages">
        /// Reference images of the new product (1–10). Supply multiple angles when the reference video shows the product from different views — optionally label each with `view` ("front", "side", or "back"). A single pre-composed reference sheet is also supported (omit `view`). See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to 720p.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductSwapResponse> CreateRecipesProductSwapAsync(
            global::Runway.CreateRecipesProductSwapRequestVersion version,
            global::Runway.CreateRecipesProductSwapRequestReferenceVideo referenceVideo,
            global::Runway.CreateRecipesProductSwapRequestOriginalProductImage originalProductImage,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage> newProductImages,
            string xRunwayVersion = "2024-11-06",
            int? duration = default,
            global::Runway.CreateRecipesProductSwapRequestResolution? resolution = default,
            bool? audio = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
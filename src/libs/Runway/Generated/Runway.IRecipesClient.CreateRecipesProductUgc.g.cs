#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create a product UGC video<br/>
        /// Generate a vertical user-generated content ad from a character image, product image, product details, and optional creative direction.
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
        /// const task = await client.recipes.productUgc({<br/>
        ///   version: '2026-06',<br/>
        ///   characterImage: { uri: 'https://example.com/creator.jpg' },<br/>
        ///   productImage: { uri: 'https://example.com/product.jpg' },<br/>
        ///   productInfo: 'Wireless game controller with haptic feedback triggers',<br/>
        ///   userConcept: 'Enthusiastic creator tone, demonstrate the product in hand',<br/>
        ///   duration: 15,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductUgcResponse> CreateRecipesProductUgcAsync(

            global::Runway.CreateRecipesProductUgcRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a product UGC video<br/>
        /// Generate a vertical user-generated content ad from a character image, product image, product details, and optional creative direction.
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
        /// const task = await client.recipes.productUgc({<br/>
        ///   version: '2026-06',<br/>
        ///   characterImage: { uri: 'https://example.com/creator.jpg' },<br/>
        ///   productImage: { uri: 'https://example.com/product.jpg' },<br/>
        ///   productInfo: 'Wireless game controller with haptic feedback triggers',<br/>
        ///   userConcept: 'Enthusiastic creator tone, demonstrate the product in hand',<br/>
        ///   duration: 15,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductUgcResponse>> CreateRecipesProductUgcAsResponseAsync(

            global::Runway.CreateRecipesProductUgcRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a product UGC video<br/>
        /// Generate a vertical user-generated content ad from a character image, product image, product details, and optional creative direction.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="characterImage">
        /// Image of the character who will appear on camera in the UGC video. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </param>
        /// <param name="productImage">
        /// Image of the product being promoted. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </param>
        /// <param name="productInfo">
        /// Product details and creative brief — what the product is, key benefits, and any specifics the script should reference.
        /// </param>
        /// <param name="userConcept">
        /// Optional creative direction for the UGC video — tone, voice register, specific message, or an entire dialog script.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 15 seconds.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductUgcResponse> CreateRecipesProductUgcAsync(
            global::Runway.CreateRecipesProductUgcRequestVersion version,
            global::Runway.CreateRecipesProductUgcRequestCharacterImage characterImage,
            global::Runway.CreateRecipesProductUgcRequestProductImage productImage,
            string xRunwayVersion = "2024-11-06",
            string? productInfo = default,
            string? userConcept = default,
            int? duration = default,
            global::Runway.CreateRecipesProductUgcRequestRatio? ratio = default,
            bool? audio = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
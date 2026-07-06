#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Localize an ad image<br/>
        /// Localize an existing ad image for a target language, preserving visual creative while adapting on-screen messaging.
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
        /// const task = await client.recipes.adLocalization({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceImage: { uri: 'https://example.com/source-ad.jpg' },<br/>
        ///   targetLanguage: 'ja',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesAdLocalizationResponse> CreateRecipesAdLocalizationAsync(

            global::Runway.CreateRecipesAdLocalizationRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Localize an ad image<br/>
        /// Localize an existing ad image for a target language, preserving visual creative while adapting on-screen messaging.
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
        /// const task = await client.recipes.adLocalization({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceImage: { uri: 'https://example.com/source-ad.jpg' },<br/>
        ///   targetLanguage: 'ja',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesAdLocalizationResponse>> CreateRecipesAdLocalizationAsResponseAsync(

            global::Runway.CreateRecipesAdLocalizationRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Localize an ad image<br/>
        /// Localize an existing ad image for a target language, preserving visual creative while adapting on-screen messaging.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="referenceImage">
        /// Reference ad image to localize. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="targetLanguage">
        /// Target language for the localized ad. Use ISO-style codes (e.g. "ja" for Japanese, "es" for Spanish).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesAdLocalizationResponse> CreateRecipesAdLocalizationAsync(
            global::Runway.CreateRecipesAdLocalizationRequestVersion version,
            global::Runway.CreateRecipesAdLocalizationRequestReferenceImage referenceImage,
            global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage targetLanguage,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
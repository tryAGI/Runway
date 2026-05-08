#nullable enable

namespace Runway
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Update document<br/>
        /// Update a knowledge document. At least one of `name` or `content` must be provided.
        /// </summary>
        /// <param name="id"></param>
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// await client.documents.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'Updated Product FAQ' }<br/>
        /// );
        /// </remarks>
        global::System.Threading.Tasks.Task EditDocumentsByIdAsync(
            global::System.Guid id,

            global::Runway.PatchDocumentsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update document<br/>
        /// Update a knowledge document. At least one of `name` or `content` must be provided.
        /// </summary>
        /// <param name="id"></param>
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// await client.documents.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'Updated Product FAQ' }<br/>
        /// );
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse> EditDocumentsByIdAsResponseAsync(
            global::System.Guid id,

            global::Runway.PatchDocumentsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update document<br/>
        /// Update a knowledge document. At least one of `name` or `content` must be provided.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// A new name for the document.<br/>
        /// Example: Updated Product FAQ
        /// </param>
        /// <param name="content">
        /// New markdown or plain text content for the document.<br/>
        /// Example: # Updated FAQ<br/>
        /// ...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditDocumentsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            string? name = default,
            string? content = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
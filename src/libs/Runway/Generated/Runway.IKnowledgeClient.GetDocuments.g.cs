#nullable enable

namespace Runway
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// List documents<br/>
        /// List knowledge documents for the authenticated user with cursor-based pagination.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sort">
        /// Default Value: createdAt
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const documents = await client.documents.list();<br/>
        /// for await (const document of documents) {<br/>
        ///   console.log(document);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.GetDocumentsResponse> GetDocumentsAsync(
            int limit,
            string? cursor = default,
            global::Runway.GetDocumentsSort sort = global::Runway.GetDocumentsSort.CreatedAt,
            global::Runway.GetDocumentsOrder order = global::Runway.GetDocumentsOrder.Desc,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List documents<br/>
        /// List knowledge documents for the authenticated user with cursor-based pagination.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sort">
        /// Default Value: createdAt
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const documents = await client.documents.list();<br/>
        /// for await (const document of documents) {<br/>
        ///   console.log(document);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetDocumentsResponse>> GetDocumentsAsResponseAsync(
            int limit,
            string? cursor = default,
            global::Runway.GetDocumentsSort sort = global::Runway.GetDocumentsSort.CreatedAt,
            global::Runway.GetDocumentsOrder order = global::Runway.GetDocumentsOrder.Desc,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Runway
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create document<br/>
        /// Create a new knowledge document. Documents can be attached to avatars to provide additional context during conversations.
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const document = await client.documents.create({<br/>
        ///   name: 'Product FAQ',<br/>
        ///   content: '# Product FAQ\n\n## What is your return policy?\n...',<br/>
        /// });<br/>
        /// console.log(document);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateDocumentsResponse> CreateDocumentsAsync(

            global::Runway.CreateDocumentsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create document<br/>
        /// Create a new knowledge document. Documents can be attached to avatars to provide additional context during conversations.
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const document = await client.documents.create({<br/>
        ///   name: 'Product FAQ',<br/>
        ///   content: '# Product FAQ\n\n## What is your return policy?\n...',<br/>
        /// });<br/>
        /// console.log(document);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateDocumentsResponse>> CreateDocumentsAsResponseAsync(

            global::Runway.CreateDocumentsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create document<br/>
        /// Create a new knowledge document. Documents can be attached to avatars to provide additional context during conversations.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// A descriptive name for the document.<br/>
        /// Example: Product FAQ
        /// </param>
        /// <param name="content">
        /// The markdown or plain text content of the document.<br/>
        /// Example: # Product FAQ<br/>
        /// ## What is your return policy?<br/>
        /// We offer a 30-day return policy...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateDocumentsResponse> CreateDocumentsAsync(
            string name,
            string content,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
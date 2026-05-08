
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDocumentsRequest
    {
        /// <summary>
        /// A descriptive name for the document.<br/>
        /// Example: Product FAQ
        /// </summary>
        /// <example>Product FAQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The markdown or plain text content of the document.<br/>
        /// Example: # Product FAQ<br/>
        /// ## What is your return policy?<br/>
        /// We offer a 30-day return policy...
        /// </summary>
        /// <example>
        /// # Product FAQ<br/>
        /// ## What is your return policy?<br/>
        /// We offer a 30-day return policy...
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentsRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDocumentsRequest(
            string name,
            string content)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentsRequest" /> class.
        /// </summary>
        public CreateDocumentsRequest()
        {
        }
    }
}
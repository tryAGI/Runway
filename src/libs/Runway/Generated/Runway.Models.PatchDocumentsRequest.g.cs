
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchDocumentsRequest
    {
        /// <summary>
        /// A new name for the document.<br/>
        /// Example: Updated Product FAQ
        /// </summary>
        /// <example>Updated Product FAQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New markdown or plain text content for the document.<br/>
        /// Example: # Updated FAQ<br/>
        /// ...
        /// </summary>
        /// <example>
        /// # Updated FAQ<br/>
        /// ...
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDocumentsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the document.<br/>
        /// Example: Updated Product FAQ
        /// </param>
        /// <param name="content">
        /// New markdown or plain text content for the document.<br/>
        /// Example: # Updated FAQ<br/>
        /// ...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDocumentsRequest(
            string? name,
            string? content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDocumentsRequest" /> class.
        /// </summary>
        public PatchDocumentsRequest()
        {
        }
    }
}
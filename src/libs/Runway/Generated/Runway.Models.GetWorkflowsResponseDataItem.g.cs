
#nullable enable

namespace Runway
{
    /// <summary>
    /// A published workflow with all its available versions.
    /// </summary>
    public sealed partial class GetWorkflowsResponseDataItem
    {
        /// <summary>
        /// The name of the published workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The published versions of this workflow, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItemVersion> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseDataItem" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the published workflow.
        /// </param>
        /// <param name="versions">
        /// The published versions of this workflow, newest first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowsResponseDataItem(
            string name,
            global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItemVersion> versions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseDataItem" /> class.
        /// </summary>
        public GetWorkflowsResponseDataItem()
        {
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Omitted until every descendant task is terminal, so a later GET cannot return a larger value.
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationSucceededCost
    {
        /// <summary>
        /// Credits charged for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceededCost" /> class.
        /// </summary>
        /// <param name="credits">
        /// Credits charged for this task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceededCost(
            int credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceededCost" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceededCost()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResult> Results { get; set; }

        /// <summary>
        /// The list of models with usage during the queried time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="models">
        /// The list of models with usage during the queried time range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponse(
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResult> results,
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseModel> models)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponse" /> class.
        /// </summary>
        public CreateOrganizationUsageResponse()
        {
        }
    }
}
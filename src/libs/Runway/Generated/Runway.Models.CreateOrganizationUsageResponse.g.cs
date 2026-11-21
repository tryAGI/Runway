
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
        /// Reserved for future use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeys")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ApiKeys { get; set; }

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultsByApiKey")]
        public global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>? ResultsByApiKey { get; set; }

        /// <summary>
        /// Credit usage broken down by tag, present when `groupBy` is set. With `groupBy: "tag"`, a generation with several tags counts toward each of them, so the buckets can add up to more than the total. With `groupBy: "tag:&lt;key&gt;"`, each generation counts once, under its `&lt;key&gt;:&lt;value&gt;` tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultsByTag")]
        public global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByTagItem>? ResultsByTag { get; set; }

        /// <summary>
        /// The tags on usage in the queried time range, sorted alphabetically, present when `tags` or `groupBy` is set. Lists at most the 1,000 tags with the most credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

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
        /// <param name="apiKeys">
        /// Reserved for future use.
        /// </param>
        /// <param name="resultsByApiKey">
        /// Reserved for future use.
        /// </param>
        /// <param name="resultsByTag">
        /// Credit usage broken down by tag, present when `groupBy` is set. With `groupBy: "tag"`, a generation with several tags counts toward each of them, so the buckets can add up to more than the total. With `groupBy: "tag:&lt;key&gt;"`, each generation counts once, under its `&lt;key&gt;:&lt;value&gt;` tag.
        /// </param>
        /// <param name="tags">
        /// The tags on usage in the queried time range, sorted alphabetically, present when `tags` or `groupBy` is set. Lists at most the 1,000 tags with the most credits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponse(
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResult> results,
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseModel> models,
            global::System.Collections.Generic.IList<global::System.Guid>? apiKeys,
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>? resultsByApiKey,
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByTagItem>? resultsByTag,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.ApiKeys = apiKeys;
            this.ResultsByApiKey = resultsByApiKey;
            this.ResultsByTag = resultsByTag;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponse" /> class.
        /// </summary>
        public CreateOrganizationUsageResponse()
        {
        }

    }
}
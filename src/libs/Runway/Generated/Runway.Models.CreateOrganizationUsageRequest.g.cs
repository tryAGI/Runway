
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationUsageRequest
    {
        /// <summary>
        /// The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeDate")]
        public global::System.DateTime? BeforeDate { get; set; }

        /// <summary>
        /// Only count generations that were created with every one of these tags in the `X-Runway-Tags` header. Tags are case-insensitive. Up to 10 tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Also break usage down by tag in `resultsByTag`. `"tag"` gives one bucket per tag; a generation with several tags counts toward each of them. `"tag:&lt;key&gt;"` (for example `"tag:team"`) gives one bucket per value of that key, so each generation counts once. Generations without a matching tag fall under a `null` tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageRequest" /> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.
        /// </param>
        /// <param name="beforeDate">
        /// The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.
        /// </param>
        /// <param name="tags">
        /// Only count generations that were created with every one of these tags in the `X-Runway-Tags` header. Tags are case-insensitive. Up to 10 tags.
        /// </param>
        /// <param name="groupBy">
        /// Also break usage down by tag in `resultsByTag`. `"tag"` gives one bucket per tag; a generation with several tags counts toward each of them. `"tag:&lt;key&gt;"` (for example `"tag:team"`) gives one bucket per value of that key, so each generation counts once. Generations without a matching tag fall under a `null` tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageRequest(
            global::System.DateTime? startDate,
            global::System.DateTime? beforeDate,
            global::System.Collections.Generic.IList<string>? tags,
            string? groupBy)
        {
            this.StartDate = startDate;
            this.BeforeDate = beforeDate;
            this.Tags = tags;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageRequest" /> class.
        /// </summary>
        public CreateOrganizationUsageRequest()
        {
        }

    }
}
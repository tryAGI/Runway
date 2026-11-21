
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponseResultsByTagItemUsedCredit
    {
        /// <summary>
        /// The tag that credits were spent under, or null for usage without a matching tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// The net number of credits spent under the tag. May be negative if refunds exceeded charges on this day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByTagItemUsedCredit" /> class.
        /// </summary>
        /// <param name="amount">
        /// The net number of credits spent under the tag. May be negative if refunds exceeded charges on this day.
        /// </param>
        /// <param name="tag">
        /// The tag that credits were spent under, or null for usage without a matching tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponseResultsByTagItemUsedCredit(
            int amount,
            string? tag)
        {
            this.Tag = tag;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByTagItemUsedCredit" /> class.
        /// </summary>
        public CreateOrganizationUsageResponseResultsByTagItemUsedCredit()
        {
        }

    }
}
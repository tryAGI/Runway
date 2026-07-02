
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponseResultsByApiKeyItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit> UsedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByApiKeyItem" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="usedCredits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponseResultsByApiKeyItem(
            global::System.DateTime date,
            global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit> usedCredits)
        {
            this.Date = date;
            this.UsedCredits = usedCredits ?? throw new global::System.ArgumentNullException(nameof(usedCredits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByApiKeyItem" /> class.
        /// </summary>
        public CreateOrganizationUsageResponseResultsByApiKeyItem()
        {
        }

    }
}
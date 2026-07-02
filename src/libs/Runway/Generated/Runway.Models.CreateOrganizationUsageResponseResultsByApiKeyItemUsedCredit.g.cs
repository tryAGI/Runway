
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ApiKeyId { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit" /> class.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit(
            global::System.Guid apiKeyId,
            int amount)
        {
            this.ApiKeyId = apiKeyId;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit" /> class.
        /// </summary>
        public CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit()
        {
        }

    }
}
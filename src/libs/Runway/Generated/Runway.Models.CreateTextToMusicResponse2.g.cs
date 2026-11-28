
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToMusicResponse2
    {
        /// <summary>
        /// A message describing why the request was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Field-level validation issues when the request failed Zod body/query validation. Omitted for other 400s.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToMusicResponseIssue>? Issues { get; set; }

        /// <summary>
        /// A machine-readable rejection reason when one applies — e.g. DEPRECATED_MODEL when the requested model has reached its sunset date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// A link to the public API documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docUrl")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToMusicResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// A message describing why the request was rejected.
        /// </param>
        /// <param name="issues">
        /// Field-level validation issues when the request failed Zod body/query validation. Omitted for other 400s.
        /// </param>
        /// <param name="reason">
        /// A machine-readable rejection reason when one applies — e.g. DEPRECATED_MODEL when the requested model has reached its sunset date.
        /// </param>
        /// <param name="docUrl">
        /// A link to the public API documentation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToMusicResponse2(
            string error,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToMusicResponseIssue>? issues,
            string? reason,
            string? docUrl)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Issues = issues;
            this.Reason = reason;
            this.DocUrl = docUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToMusicResponse2" /> class.
        /// </summary>
        public CreateTextToMusicResponse2()
        {
        }

    }
}
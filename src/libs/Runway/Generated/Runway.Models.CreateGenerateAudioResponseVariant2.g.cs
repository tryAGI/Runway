
#nullable enable

namespace Runway
{
    /// <summary>
    /// The request was invalid — e.g. an input failed validation for the routed model.
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseVariant2
    {
        /// <summary>
        /// A message describing why the request was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Field-level validation issues, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<object>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant2" /> class.
        /// </summary>
        /// <param name="error">
        /// A message describing why the request was rejected.
        /// </param>
        /// <param name="issues">
        /// Field-level validation issues, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseVariant2(
            string error,
            global::System.Collections.Generic.IList<object>? issues)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant2" /> class.
        /// </summary>
        public CreateGenerateAudioResponseVariant2()
        {
        }

    }
}
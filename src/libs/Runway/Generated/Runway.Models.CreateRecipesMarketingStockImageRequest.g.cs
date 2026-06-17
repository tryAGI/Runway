
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesMarketingStockImageRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesMarketingStockImageRequestVersion Version { get; set; }

        /// <summary>
        /// Marketing image brief. Describe the subject, audience, channel, desired mood, setting, and any constraints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional brand logo image to guide the generated marketing stock image. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImage")]
        public global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage? ReferenceImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMarketingStockImageRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="prompt">
        /// Marketing image brief. Describe the subject, audience, channel, desired mood, setting, and any constraints.
        /// </param>
        /// <param name="referenceImage">
        /// Optional brand logo image to guide the generated marketing stock image. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesMarketingStockImageRequest(
            global::Runway.CreateRecipesMarketingStockImageRequestVersion version,
            string prompt,
            global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage? referenceImage)
        {
            this.Version = version;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImage = referenceImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMarketingStockImageRequest" /> class.
        /// </summary>
        public CreateRecipesMarketingStockImageRequest()
        {
        }

    }
}
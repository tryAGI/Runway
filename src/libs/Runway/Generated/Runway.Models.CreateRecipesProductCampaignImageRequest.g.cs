
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesProductCampaignImageRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductCampaignImageRequestVersion Version { get; set; }

        /// <summary>
        /// Product image to preserve across the generated campaign. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductCampaignImageRequestImage Image { get; set; }

        /// <summary>
        /// Style / creative brief for the fashion campaign, e.g. "High-key fashion editorial, gorpcore-meets-blokecore-meets-Y2K".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductCampaignImageRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="image">
        /// Product image to preserve across the generated campaign. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="prompt">
        /// Style / creative brief for the fashion campaign, e.g. "High-key fashion editorial, gorpcore-meets-blokecore-meets-Y2K".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductCampaignImageRequest(
            global::Runway.CreateRecipesProductCampaignImageRequestVersion version,
            global::Runway.CreateRecipesProductCampaignImageRequestImage image,
            string prompt)
        {
            this.Version = version;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductCampaignImageRequest" /> class.
        /// </summary>
        public CreateRecipesProductCampaignImageRequest()
        {
        }

    }
}
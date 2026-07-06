
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesAdLocalizationRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesAdLocalizationRequestVersion Version { get; set; }

        /// <summary>
        /// Reference ad image to localize. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesAdLocalizationRequestReferenceImage ReferenceImage { get; set; }

        /// <summary>
        /// Target language for the localized ad. Use ISO-style codes (e.g. "ja" for Japanese, "es" for Spanish).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage TargetLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesAdLocalizationRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="referenceImage">
        /// Reference ad image to localize. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="targetLanguage">
        /// Target language for the localized ad. Use ISO-style codes (e.g. "ja" for Japanese, "es" for Spanish).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesAdLocalizationRequest(
            global::Runway.CreateRecipesAdLocalizationRequestVersion version,
            global::Runway.CreateRecipesAdLocalizationRequestReferenceImage referenceImage,
            global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage targetLanguage)
        {
            this.Version = version;
            this.ReferenceImage = referenceImage ?? throw new global::System.ArgumentNullException(nameof(referenceImage));
            this.TargetLanguage = targetLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesAdLocalizationRequest" /> class.
        /// </summary>
        public CreateRecipesAdLocalizationRequest()
        {
        }

    }
}
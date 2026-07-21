
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolved config settings the router used for this request.
    /// </summary>
    public sealed partial class CreateGenerateVideoResponseRoutingResolvedSettings
    {
        /// <summary>
        /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizeFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeForJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor OptimizeFor { get; set; }

        /// <summary>
        /// The applied maximum credits per generation for this request’s modality, or null if the config sets no ceiling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCeiling")]
        public double? PriceCeiling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutingResolvedSettings" /> class.
        /// </summary>
        /// <param name="optimizeFor">
        /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
        /// </param>
        /// <param name="priceCeiling">
        /// The applied maximum credits per generation for this request’s modality, or null if the config sets no ceiling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponseRoutingResolvedSettings(
            global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor optimizeFor,
            double? priceCeiling)
        {
            this.OptimizeFor = optimizeFor;
            this.PriceCeiling = priceCeiling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutingResolvedSettings" /> class.
        /// </summary>
        public CreateGenerateVideoResponseRoutingResolvedSettings()
        {
        }

    }
}
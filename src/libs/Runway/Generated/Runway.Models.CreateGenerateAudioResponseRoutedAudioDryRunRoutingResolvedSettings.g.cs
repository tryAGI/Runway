
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolved config settings the router used for this request.
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettings
    {
        /// <summary>
        /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizeFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeForJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor OptimizeFor { get; set; }

        /// <summary>
        /// The applied maximum credits per generation for this request's modality, or null if the config sets no ceiling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCeiling")]
        public double? PriceCeiling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettings" /> class.
        /// </summary>
        /// <param name="optimizeFor">
        /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
        /// </param>
        /// <param name="priceCeiling">
        /// The applied maximum credits per generation for this request's modality, or null if the config sets no ceiling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettings(
            global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor optimizeFor,
            double? priceCeiling)
        {
            this.OptimizeFor = optimizeFor;
            this.PriceCeiling = priceCeiling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettings" /> class.
        /// </summary>
        public CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettings()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Nested merge: omitted settings fields keep their current values. When models is present, omitted models.mode or models.ids are preserved (sending only optimizeFor does not clear the model allowlist or credit ceiling).
    /// </summary>
    public sealed partial class PatchRoutersRequestSettings
    {
        /// <summary>
        /// Settings JSON schema version. Omit on write to use the current version; responses and stored snapshots always include it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaVersion")]
        public double? SchemaVersion { get; set; }

        /// <summary>
        /// When mode is allow_new_except, ids are excluded; when allowlist_only, ids are the only allowed values. Each id must be a known public video model name (unknown ids are rejected on create/update).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::Runway.PatchRoutersRequestSettingsModels? Models { get; set; }

        /// <summary>
        /// Optional per-modality hard caps on credits for one generation. Models whose estimated cost for that modality exceeds the cap are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCreditsPerGeneration")]
        public global::Runway.PatchRoutersRequestSettingsMaxCreditsPerGeneration? MaxCreditsPerGeneration { get; set; }

        /// <summary>
        /// Soft preference among eligible models: cost, latency, or quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizeFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.PatchRoutersRequestSettingsOptimizeForJsonConverter))]
        public global::Runway.PatchRoutersRequestSettingsOptimizeFor? OptimizeFor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequestSettings" /> class.
        /// </summary>
        /// <param name="schemaVersion">
        /// Settings JSON schema version. Omit on write to use the current version; responses and stored snapshots always include it.
        /// </param>
        /// <param name="models">
        /// When mode is allow_new_except, ids are excluded; when allowlist_only, ids are the only allowed values. Each id must be a known public video model name (unknown ids are rejected on create/update).
        /// </param>
        /// <param name="maxCreditsPerGeneration">
        /// Optional per-modality hard caps on credits for one generation. Models whose estimated cost for that modality exceeds the cap are excluded.
        /// </param>
        /// <param name="optimizeFor">
        /// Soft preference among eligible models: cost, latency, or quality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRoutersRequestSettings(
            double? schemaVersion,
            global::Runway.PatchRoutersRequestSettingsModels? models,
            global::Runway.PatchRoutersRequestSettingsMaxCreditsPerGeneration? maxCreditsPerGeneration,
            global::Runway.PatchRoutersRequestSettingsOptimizeFor? optimizeFor)
        {
            this.SchemaVersion = schemaVersion;
            this.Models = models;
            this.MaxCreditsPerGeneration = maxCreditsPerGeneration;
            this.OptimizeFor = optimizeFor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequestSettings" /> class.
        /// </summary>
        public PatchRoutersRequestSettings()
        {
        }

    }
}
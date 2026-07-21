
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutersResponseSettings
    {
        /// <summary>
        /// Settings JSON schema version used when this snapshot was written.
        /// </summary>
        /// <default>1</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaVersion")]
        public double SchemaVersion { get; set; } = 1;

        /// <summary>
        /// When mode is allow_new_except, ids are excluded; when allowlist_only, ids are the only allowed values. Each id must be a known public video model name (unknown ids are rejected on create/update).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::Runway.GetRoutersResponseSettingsModels? Models { get; set; }

        /// <summary>
        /// Optional per-modality hard caps on credits for one generation. Models whose estimated cost for that modality exceeds the cap are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCreditsPerGeneration")]
        public global::Runway.GetRoutersResponseSettingsMaxCreditsPerGeneration? MaxCreditsPerGeneration { get; set; }

        /// <summary>
        /// Soft preference among eligible models: cost, latency, or quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizeFor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetRoutersResponseSettingsOptimizeForJsonConverter))]
        public global::Runway.GetRoutersResponseSettingsOptimizeFor? OptimizeFor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseSettings" /> class.
        /// </summary>
        /// <param name="models">
        /// When mode is allow_new_except, ids are excluded; when allowlist_only, ids are the only allowed values. Each id must be a known public video model name (unknown ids are rejected on create/update).
        /// </param>
        /// <param name="maxCreditsPerGeneration">
        /// Optional per-modality hard caps on credits for one generation. Models whose estimated cost for that modality exceeds the cap are excluded.
        /// </param>
        /// <param name="optimizeFor">
        /// Soft preference among eligible models: cost, latency, or quality.
        /// </param>
        /// <param name="schemaVersion">
        /// Settings JSON schema version used when this snapshot was written.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersResponseSettings(
            global::Runway.GetRoutersResponseSettingsModels? models,
            global::Runway.GetRoutersResponseSettingsMaxCreditsPerGeneration? maxCreditsPerGeneration,
            global::Runway.GetRoutersResponseSettingsOptimizeFor? optimizeFor,
            double schemaVersion = 1)
        {
            this.SchemaVersion = schemaVersion;
            this.Models = models;
            this.MaxCreditsPerGeneration = maxCreditsPerGeneration;
            this.OptimizeFor = optimizeFor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseSettings" /> class.
        /// </summary>
        public GetRoutersResponseSettings()
        {
        }

    }
}
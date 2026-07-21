
#nullable enable

namespace Runway
{
    /// <summary>
    /// When mode is allow_new_except, ids are excluded; when allowlist_only, ids are the only allowed values. Each id must be a known public video model name (unknown ids are rejected on create/update).
    /// </summary>
    public sealed partial class PatchRoutersRequestSettingsModels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.PatchRoutersRequestSettingsModelsModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.PatchRoutersRequestSettingsModelsMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequestSettingsModels" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRoutersRequestSettingsModels(
            global::Runway.PatchRoutersRequestSettingsModelsMode mode,
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Mode = mode;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequestSettingsModels" /> class.
        /// </summary>
        public PatchRoutersRequestSettingsModels()
        {
        }

    }
}
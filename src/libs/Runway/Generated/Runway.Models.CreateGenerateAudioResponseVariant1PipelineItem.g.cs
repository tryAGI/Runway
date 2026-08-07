
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseVariant1PipelineItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"filter"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "filter";

        /// <summary>
        /// Hard-filter stage that ran: capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1PipelineItemFilterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter Filter { get; set; }

        /// <summary>
        /// Model IDs of the models that remained eligible after this filter stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant1PipelineItem" /> class.
        /// </summary>
        /// <param name="filter">
        /// Hard-filter stage that ran: capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </param>
        /// <param name="models">
        /// Model IDs of the models that remained eligible after this filter stage.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseVariant1PipelineItem(
            global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter filter,
            global::System.Collections.Generic.IList<string> models,
            string type = "filter")
        {
            this.Type = type;
            this.Filter = filter;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant1PipelineItem" /> class.
        /// </summary>
        public CreateGenerateAudioResponseVariant1PipelineItem()
        {
        }

    }
}
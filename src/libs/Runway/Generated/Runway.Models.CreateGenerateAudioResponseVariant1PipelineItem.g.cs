
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1PipelineItemFilterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter Filter { get; set; }

        /// <summary>
        /// How many models remained eligible after this filter ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Remaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant1PipelineItem" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="remaining">
        /// How many models remained eligible after this filter ran.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseVariant1PipelineItem(
            global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter filter,
            int remaining)
        {
            this.Filter = filter;
            this.Remaining = remaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseVariant1PipelineItem" /> class.
        /// </summary>
        public CreateGenerateAudioResponseVariant1PipelineItem()
        {
        }

    }
}
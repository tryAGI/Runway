
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"no_eligible_model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = "no_eligible_model";

        /// <summary>
        /// The hard-filter pipeline in execution order with survivor counts at each stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponsePipelineItem> Pipeline { get; set; }

        /// <summary>
        /// The filter(s) that reduced the eligible pool to zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptiedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponseEmptiedByItem> EmptiedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponse2" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="pipeline">
        /// The hard-filter pipeline in execution order with survivor counts at each stage.
        /// </param>
        /// <param name="emptiedBy">
        /// The filter(s) that reduced the eligible pool to zero.
        /// </param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponse2(
            string error,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponsePipelineItem> pipeline,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponseEmptiedByItem> emptiedBy,
            string code = "no_eligible_model")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Code = code;
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
            this.EmptiedBy = emptiedBy ?? throw new global::System.ArgumentNullException(nameof(emptiedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponse2" /> class.
        /// </summary>
        public CreateGenerateVideoResponse2()
        {
        }

    }
}
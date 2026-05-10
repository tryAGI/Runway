
#nullable enable

namespace Runway
{
    /// <summary>
    /// A primitive value (string, number, or boolean)
    /// </summary>
    public sealed partial class CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"primitive"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "primitive";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string, double?, bool?> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive(
            global::Runway.AnyOf<string, double?, bool?> value,
            string type = "primitive")
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive" /> class.
        /// </summary>
        public CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive()
        {
        }

    }
}
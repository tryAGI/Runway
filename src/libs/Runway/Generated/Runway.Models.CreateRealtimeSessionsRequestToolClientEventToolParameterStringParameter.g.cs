
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter
    {
        /// <summary>
        /// The parameter name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the parameter is required.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"string"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "string";

        /// <summary>
        /// Allowed values for the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The parameter name.
        /// </param>
        /// <param name="description">
        /// A description of the parameter.
        /// </param>
        /// <param name="required">
        /// Whether the parameter is required.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enum">
        /// Allowed values for the parameter.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter(
            string name,
            string description,
            bool? required,
            global::System.Collections.Generic.IList<string>? @enum,
            string type = "string")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Type = type;
            this.Enum = @enum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter()
        {
        }

    }
}
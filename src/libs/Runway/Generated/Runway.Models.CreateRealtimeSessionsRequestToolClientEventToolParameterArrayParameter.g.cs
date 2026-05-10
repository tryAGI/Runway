
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter
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
        /// <default>"array"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "array";

        /// <summary>
        /// Item schema for array elements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The parameter name.
        /// </param>
        /// <param name="description">
        /// A description of the parameter.
        /// </param>
        /// <param name="items">
        /// Item schema for array elements.
        /// </param>
        /// <param name="required">
        /// Whether the parameter is required.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter(
            string name,
            string description,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems items,
            bool? required,
            string type = "array")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter()
        {
        }

    }
}
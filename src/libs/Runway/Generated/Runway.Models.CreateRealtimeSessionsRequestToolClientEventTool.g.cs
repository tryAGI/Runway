
#nullable enable

namespace Runway
{
    /// <summary>
    /// A fire-and-forget tool that sends arguments to the frontend client of the realtime session.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestToolClientEventTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"client_event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "client_event";

        /// <summary>
        /// The tool name. Must start with a letter or underscore, followed by alphanumeric characters or underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of when and how the tool should be used. Be specific so the avatar understands the right context to invoke it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::Runway.ParametersItem>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The tool name. Must start with a letter or underscore, followed by alphanumeric characters or underscores.
        /// </param>
        /// <param name="description">
        /// A description of when and how the tool should be used. Be specific so the avatar understands the right context to invoke it.
        /// </param>
        /// <param name="parameters">
        /// Default Value: []
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestToolClientEventTool(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Runway.ParametersItem>? parameters,
            string type = "client_event")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventTool" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestToolClientEventTool()
        {
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// A tool that makes a round-trip RPC call to your backend server during the session.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestToolBackendRPCTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"backend_rpc"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "backend_rpc";

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
        public global::System.Collections.Generic.IList<global::Runway.ParametersItem2>? Parameters { get; set; }

        /// <summary>
        /// Maximum time to wait for the backend to respond.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolBackendRPCTool" /> class.
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
        /// <param name="timeoutSeconds">
        /// Maximum time to wait for the backend to respond.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestToolBackendRPCTool(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Runway.ParametersItem2>? parameters,
            double? timeoutSeconds,
            string type = "backend_rpc")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Parameters = parameters;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolBackendRPCTool" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestToolBackendRPCTool()
        {
        }

    }
}
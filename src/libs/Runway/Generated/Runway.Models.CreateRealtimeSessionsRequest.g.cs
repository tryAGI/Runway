
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequest
    {
        /// <summary>
        /// The realtime session model type.
        /// </summary>
        /// <default>"gwm1_avatars"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gwm1_avatars";

        /// <summary>
        /// The avatar configuration for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.Avatar2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Avatar2 Avatar { get; set; }

        /// <summary>
        /// Maximum session duration in seconds.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Override the avatar personality for this session. If not provided, uses the avatar default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public string? Personality { get; set; }

        /// <summary>
        /// Override the avatar start script for this session. If not provided, uses the avatar default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startScript")]
        public string? StartScript { get; set; }

        /// <summary>
        /// Tools available to the avatar during the session.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Runway.ToolsItem>? Tools { get; set; }

        /// <summary>
        /// External integration. Runway renders the avatar; the integration owns conversation or audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.IntegrationJsonConverter))]
        public global::Runway.Integration? Integration { get; set; }

        /// <summary>
        /// Use integration with type "livekit" instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Runway.CreateRealtimeSessionsRequestLivekit? Livekit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequest" /> class.
        /// </summary>
        /// <param name="avatar">
        /// The avatar configuration for the session.
        /// </param>
        /// <param name="maxDuration">
        /// Maximum session duration in seconds.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="personality">
        /// Override the avatar personality for this session. If not provided, uses the avatar default.
        /// </param>
        /// <param name="startScript">
        /// Override the avatar start script for this session. If not provided, uses the avatar default.
        /// </param>
        /// <param name="tools">
        /// Tools available to the avatar during the session.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="integration">
        /// External integration. Runway renders the avatar; the integration owns conversation or audio.
        /// </param>
        /// <param name="model">
        /// The realtime session model type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequest(
            global::Runway.Avatar2 avatar,
            int? maxDuration,
            string? personality,
            string? startScript,
            global::System.Collections.Generic.IList<global::Runway.ToolsItem>? tools,
            global::Runway.Integration? integration,
            string model = "gwm1_avatars")
        {
            this.Model = model;
            this.Avatar = avatar;
            this.MaxDuration = maxDuration;
            this.Personality = personality;
            this.StartScript = startScript;
            this.Tools = tools;
            this.Integration = integration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequest" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequest()
        {
        }

    }
}
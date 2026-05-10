
#nullable enable

namespace Runway
{
    /// <summary>
    /// Summary of a tool configured for the session.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant2Tool
    {
        /// <summary>
        /// The tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetAvatarConversationsResponseVariant2ToolType Type { get; set; }

        /// <summary>
        /// The tool name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of when and how the tool should be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2Tool" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool type.
        /// </param>
        /// <param name="name">
        /// The tool name.
        /// </param>
        /// <param name="description">
        /// A description of when and how the tool should be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant2Tool(
            global::Runway.GetAvatarConversationsResponseVariant2ToolType type,
            string name,
            string description)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2Tool" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant2Tool()
        {
        }

    }
}
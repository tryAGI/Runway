
#nullable enable

namespace Runway
{
    /// <summary>
    /// A tool invocation by the assistant.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant1TranscriptItemToolCall
    {
        /// <summary>
        /// Optional identifier linking this call to its result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The arguments passed to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1TranscriptItemToolCall" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool that was called.
        /// </param>
        /// <param name="arguments">
        /// The arguments passed to the tool.
        /// </param>
        /// <param name="id">
        /// Optional identifier linking this call to its result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant1TranscriptItemToolCall(
            string name,
            object arguments,
            string? id)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1TranscriptItemToolCall" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant1TranscriptItemToolCall()
        {
        }
    }
}
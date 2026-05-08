
#nullable enable

namespace Runway
{
    /// <summary>
    /// The result of a tool invocation.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant1TranscriptItemToolResult
    {
        /// <summary>
        /// Optional identifier linking this result to its call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the tool that returned a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The tool result (object, string, or null).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>))]
        public global::Runway.AnyOf<object, string, object>? Result { get; set; }

        /// <summary>
        /// Error message if the tool call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// How long the tool call took in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public double? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1TranscriptItemToolResult" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool that returned a result.
        /// </param>
        /// <param name="id">
        /// Optional identifier linking this result to its call.
        /// </param>
        /// <param name="result">
        /// The tool result (object, string, or null).
        /// </param>
        /// <param name="error">
        /// Error message if the tool call failed.
        /// </param>
        /// <param name="durationMs">
        /// How long the tool call took in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant1TranscriptItemToolResult(
            string name,
            string? id,
            global::Runway.AnyOf<object, string, object>? result,
            string? error,
            double? durationMs)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Result = result;
            this.Error = error;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1TranscriptItemToolResult" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant1TranscriptItemToolResult()
        {
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// An audio asset
    /// </summary>
    public sealed partial class CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio(
            string uri,
            string type = "audio")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio" /> class.
        /// </summary>
        public CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio FromUri(string uri)
        {
            return new CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio
            {
                Uri = uri,
            };
        }

    }
}
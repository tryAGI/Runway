
#nullable enable

namespace Runway
{
    /// <summary>
    /// ElevenLabs handles conversation; Runway renders the avatar video.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"elevenlabs"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "elevenlabs";

        /// <summary>
        /// ConvAI signed WebSocket URL (~15 min lifetime).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signedUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// ConvAI signed WebSocket URL (~15 min lifetime).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration(
            string signedUrl,
            string type = "elevenlabs")
        {
            this.Type = type;
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration FromSignedUrl(string signedUrl)
        {
            return new CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration
            {
                SignedUrl = signedUrl,
            };
        }

    }
}
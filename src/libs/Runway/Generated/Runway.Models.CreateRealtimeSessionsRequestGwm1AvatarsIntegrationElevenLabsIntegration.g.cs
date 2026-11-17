
#nullable enable

namespace Runway
{
    /// <summary>
    /// ElevenLabs handles conversation; Runway renders the avatar video.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"elevenlabs"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "elevenlabs";

        /// <summary>
        /// ConvAI signed WebSocket URL (~15 min lifetime). Must be a wss:// or https:// URL that resolves to a public host.
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
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// ConvAI signed WebSocket URL (~15 min lifetime). Must be a wss:// or https:// URL that resolves to a public host.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration(
            string signedUrl,
            string type = "elevenlabs")
        {
            this.Type = type;
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration FromSignedUrl(string signedUrl)
        {
            return new CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration
            {
                SignedUrl = signedUrl,
            };
        }

    }
}
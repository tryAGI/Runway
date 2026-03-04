
#nullable enable

namespace Runway
{
    /// <summary>
    /// A voice preset from the RunwayML API.
    /// </summary>
    public sealed partial class RequestVariant1VoiceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The preset voice ID to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestVariant1VoiceVariant1PresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.RequestVariant1VoiceVariant1PresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant1VoiceVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestVariant1VoiceVariant1(
            string type,
            global::Runway.RequestVariant1VoiceVariant1PresetId presetId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant1VoiceVariant1" /> class.
        /// </summary>
        public RequestVariant1VoiceVariant1()
        {
        }
    }
}
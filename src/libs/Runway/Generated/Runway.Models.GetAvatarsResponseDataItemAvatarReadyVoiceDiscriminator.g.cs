
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter))]
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator(
            global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator" /> class.
        /// </summary>
        public GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator()
        {
        }
    }
}
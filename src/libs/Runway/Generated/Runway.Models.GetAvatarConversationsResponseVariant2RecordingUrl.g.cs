
#nullable enable

namespace Runway
{
    /// <summary>
    /// A URL to download the conversation recording, or null if no recording is available. This URL will expire within 24-48 hours, fetch the conversation again to get a fresh download URL.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant2RecordingUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
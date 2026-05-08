
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional opening message that the avatar will say when a session starts. Set to null to clear.<br/>
    /// Example: Hello! How can I help you today?
    /// </summary>
    public sealed partial class PatchAvatarsRequestStartScript
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
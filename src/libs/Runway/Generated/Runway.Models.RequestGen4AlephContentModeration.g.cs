
#nullable enable

namespace Runway
{
    /// <summary>
    /// Settings that affect the behavior of the content moderation system.
    /// </summary>
    public sealed partial class RequestGen4AlephContentModeration
    {
        /// <summary>
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicFigureThreshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestGen4AlephContentModerationPublicFigureThresholdJsonConverter))]
        public global::Runway.RequestGen4AlephContentModerationPublicFigureThreshold? PublicFigureThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4AlephContentModeration" /> class.
        /// </summary>
        /// <param name="publicFigureThreshold">
        /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestGen4AlephContentModeration(
            global::Runway.RequestGen4AlephContentModerationPublicFigureThreshold? publicFigureThreshold)
        {
            this.PublicFigureThreshold = publicFigureThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4AlephContentModeration" /> class.
        /// </summary>
        public RequestGen4AlephContentModeration()
        {
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoicesPreviewResponse
    {
        /// <summary>
        /// A presigned URL to the audio preview. The URL expires after 24 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Duration of the audio preview in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationSecs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesPreviewResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// A presigned URL to the audio preview. The URL expires after 24 hours.
        /// </param>
        /// <param name="durationSecs">
        /// Duration of the audio preview in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoicesPreviewResponse(
            string url,
            double durationSecs)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesPreviewResponse" /> class.
        /// </summary>
        public CreateVoicesPreviewResponse()
        {
        }

    }
}
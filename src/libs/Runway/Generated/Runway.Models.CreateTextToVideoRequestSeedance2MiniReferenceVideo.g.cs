
#nullable enable

namespace Runway
{
    /// <summary>
    /// A video reference allows the model to use the video as additional context for the output.
    /// </summary>
    public sealed partial class CreateTextToVideoRequestSeedance2MiniReferenceVideo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"video"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance2MiniReferenceVideo" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestSeedance2MiniReferenceVideo(
            string uri,
            string type = "video")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestSeedance2MiniReferenceVideo" /> class.
        /// </summary>
        public CreateTextToVideoRequestSeedance2MiniReferenceVideo()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestSeedance2MiniReferenceVideo"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2MiniReferenceVideo FromUri(string uri)
        {
            return new CreateTextToVideoRequestSeedance2MiniReferenceVideo
            {
                Uri = uri,
            };
        }

    }
}
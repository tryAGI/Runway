
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoRequestInputReferenceVideo
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// How the video is used. `source` is the primary video-to-video input; `reference` is additional video context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateVideoRequestInputReferenceVideoRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputReferenceVideo" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="role">
        /// How the video is used. `source` is the primary video-to-video input; `reference` is additional video context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoRequestInputReferenceVideo(
            string uri,
            global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole role)
        {
            this.Uri = uri;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputReferenceVideo" /> class.
        /// </summary>
        public CreateGenerateVideoRequestInputReferenceVideo()
        {
        }

    }
}
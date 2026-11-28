
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestHailuo3LiteReferenceVideo
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"video"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// An MP4 or MOV reference video, 2–15 seconds long at 22–62 fps. Frame rates near the limits are normalized to 24–60 fps.<br/>
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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHailuo3LiteReferenceVideo" /> class.
        /// </summary>
        /// <param name="uri">
        /// An MP4 or MOV reference video, 2–15 seconds long at 22–62 fps. Frame rates near the limits are normalized to 24–60 fps.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestHailuo3LiteReferenceVideo(
            string uri,
            string type = "video")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHailuo3LiteReferenceVideo" /> class.
        /// </summary>
        public CreateImageToVideoRequestHailuo3LiteReferenceVideo()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateImageToVideoRequestHailuo3LiteReferenceVideo"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3LiteReferenceVideo FromUri(string uri)
        {
            return new CreateImageToVideoRequestHailuo3LiteReferenceVideo
            {
                Uri = uri,
            };
        }

    }
}
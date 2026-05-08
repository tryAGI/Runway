
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarConversationsResponse
    {
        /// <summary>
        /// Array of conversation summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseDataItem> Data { get; set; }

        /// <summary>
        /// Whether there are more conversations to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to use for fetching the next page, or null if no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of conversation summaries.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more conversations to fetch.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to use for fetching the next page, or null if no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponse(
            global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseDataItem> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponse" /> class.
        /// </summary>
        public GetAvatarConversationsResponse()
        {
        }
    }
}
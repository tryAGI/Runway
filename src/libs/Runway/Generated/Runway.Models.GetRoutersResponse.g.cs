
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutersResponse
    {
        /// <summary>
        /// The list of items for the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetRoutersResponseDataItem> Data { get; set; }

        /// <summary>
        /// Whether there are more items available after this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to use for fetching the next page, or null if there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of items for the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more items available after this page.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to use for fetching the next page, or null if there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersResponse(
            global::System.Collections.Generic.IList<global::Runway.GetRoutersResponseDataItem> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponse" /> class.
        /// </summary>
        public GetRoutersResponse()
        {
        }

    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarUsageResponse
    {
        /// <summary>
        /// Total seconds across conversations with a measured duration in the date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSeconds { get; set; }

        /// <summary>
        /// Number of conversations started in the date range. Includes unfinished and failed conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSessions { get; set; }

        /// <summary>
        /// Average duration in seconds across conversations with a measured duration, or 0 if none completed. May not equal `totalSeconds / totalSessions` because unfinished conversations contribute to the session count but not the duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgDurationSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AvgDurationSeconds { get; set; }

        /// <summary>
        /// Per-day usage across the date range. Days with no sessions are included with zeroes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byDay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetAvatarUsageResponseByDayItem> ByDay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarUsageResponse" /> class.
        /// </summary>
        /// <param name="totalSeconds">
        /// Total seconds across conversations with a measured duration in the date range.
        /// </param>
        /// <param name="totalSessions">
        /// Number of conversations started in the date range. Includes unfinished and failed conversations.
        /// </param>
        /// <param name="avgDurationSeconds">
        /// Average duration in seconds across conversations with a measured duration, or 0 if none completed. May not equal `totalSeconds / totalSessions` because unfinished conversations contribute to the session count but not the duration.
        /// </param>
        /// <param name="byDay">
        /// Per-day usage across the date range. Days with no sessions are included with zeroes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarUsageResponse(
            int totalSeconds,
            int totalSessions,
            int avgDurationSeconds,
            global::System.Collections.Generic.IList<global::Runway.GetAvatarUsageResponseByDayItem> byDay)
        {
            this.TotalSeconds = totalSeconds;
            this.TotalSessions = totalSessions;
            this.AvgDurationSeconds = avgDurationSeconds;
            this.ByDay = byDay ?? throw new global::System.ArgumentNullException(nameof(byDay));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarUsageResponse" /> class.
        /// </summary>
        public GetAvatarUsageResponse()
        {
        }
    }
}
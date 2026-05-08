
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarUsageResponseByDayItem
    {
        /// <summary>
        /// The UTC calendar date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Number of conversations started on this date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sessions { get; set; }

        /// <summary>
        /// Total seconds of measured conversation duration on this date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarUsageResponseByDayItem" /> class.
        /// </summary>
        /// <param name="date">
        /// The UTC calendar date (YYYY-MM-DD).
        /// </param>
        /// <param name="sessions">
        /// Number of conversations started on this date.
        /// </param>
        /// <param name="seconds">
        /// Total seconds of measured conversation duration on this date.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarUsageResponseByDayItem(
            global::System.DateTime date,
            int sessions,
            int seconds)
        {
            this.Date = date;
            this.Sessions = sessions;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarUsageResponseByDayItem" /> class.
        /// </summary>
        public GetAvatarUsageResponseByDayItem()
        {
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// A session that encountered an error.
    /// </summary>
    public sealed partial class GetRealtimeSessionsResponseSessionFailed
    {
        /// <summary>
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// When the session was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"FAILED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "FAILED";

        /// <summary>
        /// A human-readable error message. This value is not stable and should not be matched against programmatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Failure { get; set; }

        /// <summary>
        /// A stable, machine-readable error code. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionFailed" /> class.
        /// </summary>
        /// <param name="id">
        /// The realtime session ID. This same value is later used as the conversation ID in the avatar conversation endpoints.
        /// </param>
        /// <param name="createdAt">
        /// When the session was created.
        /// </param>
        /// <param name="failure">
        /// A human-readable error message. This value is not stable and should not be matched against programmatically.
        /// </param>
        /// <param name="failureCode">
        /// A stable, machine-readable error code. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRealtimeSessionsResponseSessionFailed(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string failure,
            string failureCode,
            string status = "FAILED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
            this.FailureCode = failureCode ?? throw new global::System.ArgumentNullException(nameof(failureCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRealtimeSessionsResponseSessionFailed" /> class.
        /// </summary>
        public GetRealtimeSessionsResponseSessionFailed()
        {
        }
    }
}
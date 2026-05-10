
#nullable enable

namespace Runway
{
    /// <summary>
    /// A voice that failed to finish processing.
    /// </summary>
    public sealed partial class GetVoicesResponseVoiceFailed
    {
        /// <summary>
        /// The unique identifier of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the voice, or null if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the voice was created.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseVoiceFailed" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="createdAt">
        /// When the voice was created.
        /// </param>
        /// <param name="failureReason">
        /// A human-readable error message. This value is not stable and should not be matched against programmatically.
        /// </param>
        /// <param name="description">
        /// A description of the voice, or null if not set.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesResponseVoiceFailed(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            string failureReason,
            string? description,
            string status = "FAILED")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.FailureReason = failureReason ?? throw new global::System.ArgumentNullException(nameof(failureReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseVoiceFailed" /> class.
        /// </summary>
        public GetVoicesResponseVoiceFailed()
        {
        }

    }
}
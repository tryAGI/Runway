
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoResponse
    {
        /// <summary>
        /// The ID of the created task. Poll GET /v1/tasks/:id for the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Metadata describing which model the router selected and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateVideoResponseRouting Routing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the created task. Poll GET /v1/tasks/:id for the result.
        /// </param>
        /// <param name="routing">
        /// Metadata describing which model the router selected and why.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponse(
            global::System.Guid id,
            global::Runway.CreateGenerateVideoResponseRouting routing)
        {
            this.Id = id;
            this.Routing = routing ?? throw new global::System.ArgumentNullException(nameof(routing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponse" /> class.
        /// </summary>
        public CreateGenerateVideoResponse()
        {
        }

    }
}
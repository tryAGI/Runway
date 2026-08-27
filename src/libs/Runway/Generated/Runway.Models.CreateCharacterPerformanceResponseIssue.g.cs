
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCharacterPerformanceResponseIssue
    {
        /// <summary>
        /// A machine-readable issue code from request validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The path to the invalid field in the request body or query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.AnyOf<string, double?>> Path { get; set; }

        /// <summary>
        /// A human-readable description of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceResponseIssue" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable issue code from request validation.
        /// </param>
        /// <param name="path">
        /// The path to the invalid field in the request body or query.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the issue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCharacterPerformanceResponseIssue(
            string code,
            global::System.Collections.Generic.IList<global::Runway.AnyOf<string, double?>> path,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceResponseIssue" /> class.
        /// </summary>
        public CreateCharacterPerformanceResponseIssue()
        {
        }

    }
}
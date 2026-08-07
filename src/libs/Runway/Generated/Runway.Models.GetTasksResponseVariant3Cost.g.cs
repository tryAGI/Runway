
#nullable enable

namespace Runway
{
    /// <summary>
    /// Final cost in credits for a terminal task. A refunded task reports 0.
    /// </summary>
    public sealed partial class GetTasksResponseVariant3Cost
    {
        /// <summary>
        /// Credits charged for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant3Cost" /> class.
        /// </summary>
        /// <param name="credits">
        /// Credits charged for this task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant3Cost(
            int credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant3Cost" /> class.
        /// </summary>
        public GetTasksResponseVariant3Cost()
        {
        }

    }
}
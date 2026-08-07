
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoResponseRoutedVideoDryRun
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool DryRun { get; set; } = true;

        /// <summary>
        /// Metadata describing which model the router selected and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateVideoResponseRoutedVideoDryRunRouting Routing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoDryRun" /> class.
        /// </summary>
        /// <param name="routing">
        /// Metadata describing which model the router selected and why.
        /// </param>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponseRoutedVideoDryRun(
            global::Runway.CreateGenerateVideoResponseRoutedVideoDryRunRouting routing,
            bool dryRun = true)
        {
            this.DryRun = dryRun;
            this.Routing = routing ?? throw new global::System.ArgumentNullException(nameof(routing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoDryRun" /> class.
        /// </summary>
        public CreateGenerateVideoResponseRoutedVideoDryRun()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateGenerateVideoResponseRoutedVideoDryRun"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateGenerateVideoResponseRoutedVideoDryRun FromRouting(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRunRouting routing)
        {
            return new CreateGenerateVideoResponseRoutedVideoDryRun
            {
                Routing = routing,
            };
        }

    }
}
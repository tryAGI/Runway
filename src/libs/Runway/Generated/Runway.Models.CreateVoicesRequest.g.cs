
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoicesRequest
    {
        /// <summary>
        /// A name for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.FromJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.From From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the voice.
        /// </param>
        /// <param name="from"></param>
        /// <param name="description">
        /// An optional description of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoicesRequest(
            string name,
            global::Runway.From from,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesRequest" /> class.
        /// </summary>
        public CreateVoicesRequest()
        {
        }

    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestGen3aTurbo
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.<br/>
        /// Example: A beautiful sunset over a calm ocean.
        /// </summary>
        /// <example>A beautiful sunset over a calm ocean.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Example: 1280:768
        /// </summary>
        /// <example>1280:768</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestGen3aTurboRatioJsonConverter))]
        public global::Runway.RequestGen3aTurboRatio? Ratio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </summary>
        /// <example>{"publicFigureThreshold":"auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.RequestGen3aTurboContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen3aTurbo" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.<br/>
        /// Example: A beautiful sunset over a calm ocean.
        /// </param>
        /// <param name="promptImage"></param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.<br/>
        /// Example: 1280:768
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestGen3aTurbo(
            string promptText,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>> promptImage,
            string model,
            int? seed,
            double? duration,
            global::Runway.RequestGen3aTurboRatio? ratio,
            global::Runway.RequestGen3aTurboContentModeration? contentModeration)
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.PromptImage = promptImage;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Seed = seed;
            this.Duration = duration;
            this.Ratio = ratio;
            this.ContentModeration = contentModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen3aTurbo" /> class.
        /// </summary>
        public RequestGen3aTurbo()
        {
        }
    }
}
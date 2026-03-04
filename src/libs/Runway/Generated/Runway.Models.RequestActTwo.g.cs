
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestActTwo
    {
        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CharacterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Character Character { get; set; }

        /// <summary>
        /// The reference video containing the performance to apply to the character.<br/>
        /// Example: {"type":"video","uri":"https://example.com/reference-performance.mp4"}
        /// </summary>
        /// <example>{"type":"video","uri":"https://example.com/reference-performance.mp4"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.RequestActTwoReferenceCharacterReferenceVideo Reference { get; set; }

        /// <summary>
        /// A boolean indicating whether to enable body control. When enabled, non-facial movements and gestures will be applied to the character in addition to facial expressions.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodyControl")]
        public bool? BodyControl { get; set; }

        /// <summary>
        /// An integer between 1 and 5 (inclusive). A larger value increases the intensity of the character's expression.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressionIntensity")]
        public int? ExpressionIntensity { get; set; }

        /// <summary>
        /// The resolution of the output video.<br/>
        /// Example: 1280:720
        /// </summary>
        /// <example>1280:720</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestActTwoRatioJsonConverter))]
        public global::Runway.RequestActTwoRatio? Ratio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </summary>
        /// <example>{"publicFigureThreshold":"auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.RequestActTwoContentModeration? ContentModeration { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestActTwo" /> class.
        /// </summary>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="character">
        /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
        /// </param>
        /// <param name="reference">
        /// The reference video containing the performance to apply to the character.<br/>
        /// Example: {"type":"video","uri":"https://example.com/reference-performance.mp4"}
        /// </param>
        /// <param name="bodyControl">
        /// A boolean indicating whether to enable body control. When enabled, non-facial movements and gestures will be applied to the character in addition to facial expressions.<br/>
        /// Example: true
        /// </param>
        /// <param name="expressionIntensity">
        /// An integer between 1 and 5 (inclusive). A larger value increases the intensity of the character's expression.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.<br/>
        /// Example: 1280:720
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.<br/>
        /// Example: {"publicFigureThreshold":"auto"}
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestActTwo(
            global::Runway.Character character,
            global::Runway.RequestActTwoReferenceCharacterReferenceVideo reference,
            string model,
            int? seed,
            bool? bodyControl,
            int? expressionIntensity,
            global::Runway.RequestActTwoRatio? ratio,
            global::Runway.RequestActTwoContentModeration? contentModeration)
        {
            this.Character = character;
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Seed = seed;
            this.BodyControl = bodyControl;
            this.ExpressionIntensity = expressionIntensity;
            this.Ratio = ratio;
            this.ContentModeration = contentModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwo" /> class.
        /// </summary>
        public RequestActTwo()
        {
        }
    }
}
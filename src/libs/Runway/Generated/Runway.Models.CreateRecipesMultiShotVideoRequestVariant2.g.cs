
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesMultiShotVideoRequestVariant2
    {
        /// <summary>
        /// Workflow mode. `custom` polishes a user-provided shot list of 3–5 shots.
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "custom";

        /// <summary>
        /// Shot list for custom mode (3–5 shots). Per-shot durations must sum to `duration`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot> Shots { get; set; }

        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version Version { get; set; }

        /// <summary>
        /// Optional image used as the first frame of the output video. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstFrame")]
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant2FirstFrame? FirstFrame { get; set; }

        /// <summary>
        /// Output dimensions as width:height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter))]
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio? Ratio { get; set; }

        /// <summary>
        /// Total duration of the output video in seconds. Defaults to 10 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestVariant2" /> class.
        /// </summary>
        /// <param name="shots">
        /// Shot list for custom mode (3–5 shots). Per-shot durations must sum to `duration`.
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="firstFrame">
        /// Optional image used as the first frame of the output video. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="ratio">
        /// Output dimensions as width:height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </param>
        /// <param name="duration">
        /// Total duration of the output video in seconds. Defaults to 10 seconds.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="mode">
        /// Workflow mode. `custom` polishes a user-provided shot list of 3–5 shots.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesMultiShotVideoRequestVariant2(
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot> shots,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version version,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2FirstFrame? firstFrame,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio? ratio,
            double? duration,
            bool? audio,
            string mode = "custom")
        {
            this.Mode = mode;
            this.Shots = shots ?? throw new global::System.ArgumentNullException(nameof(shots));
            this.Version = version;
            this.FirstFrame = firstFrame;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestVariant2" /> class.
        /// </summary>
        public CreateRecipesMultiShotVideoRequestVariant2()
        {
        }

    }
}
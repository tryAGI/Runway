
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided. `edit` modifies the input video in place, requires `promptText`, requires `duration: "auto"`, and does not accept `ratio`.<br/>
    /// Default Value: reference
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance25Mode
    {
        /// <summary>
        /// "auto"`, and does not accept `ratio`.
        /// </summary>
        Edit,
        /// <summary>
        /// "auto"`, and does not accept `ratio`.
        /// </summary>
        Extend,
        /// <summary>
        /// "auto"`, and does not accept `ratio`.
        /// </summary>
        Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestSeedance25ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance25Mode value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance25Mode.Edit => "edit",
                CreateVideoToVideoRequestSeedance25Mode.Extend => "extend",
                CreateVideoToVideoRequestSeedance25Mode.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance25Mode? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateVideoToVideoRequestSeedance25Mode.Edit,
                "extend" => CreateVideoToVideoRequestSeedance25Mode.Extend,
                "reference" => CreateVideoToVideoRequestSeedance25Mode.Reference,
                _ => null,
            };
        }
    }
}
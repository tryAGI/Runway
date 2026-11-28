
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the input video is used. `reference` (the default) generates a new video conditioned on the input video and accepts `duration` and `ratio`. `extend` continues the input video, requires `promptText`, and matches the input aspect ratio, so `ratio` may not be provided. `edit` modifies the input video in place, requires `promptText`, requires `duration: "auto"`, and does not accept `ratio`.<br/>
    /// Default Value: reference
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance25FlashMode
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
    public static class CreateVideoToVideoRequestSeedance25FlashModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance25FlashMode value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance25FlashMode.Edit => "edit",
                CreateVideoToVideoRequestSeedance25FlashMode.Extend => "extend",
                CreateVideoToVideoRequestSeedance25FlashMode.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance25FlashMode? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateVideoToVideoRequestSeedance25FlashMode.Edit,
                "extend" => CreateVideoToVideoRequestSeedance25FlashMode.Extend,
                "reference" => CreateVideoToVideoRequestSeedance25FlashMode.Reference,
                _ => null,
            };
        }
    }
}
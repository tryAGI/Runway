
#nullable enable

namespace Runway
{
    /// <summary>
    /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`. Draft mode only supports `mp4`.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance25OutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mov,
        /// <summary>
        ///
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestSeedance25OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance25OutputFormat value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance25OutputFormat.Mov => "mov",
                CreateTextToVideoRequestSeedance25OutputFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance25OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTextToVideoRequestSeedance25OutputFormat.Mov,
                "mp4" => CreateTextToVideoRequestSeedance25OutputFormat.Mp4,
                _ => null,
            };
        }
    }
}
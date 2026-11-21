
#nullable enable

namespace Runway
{
    /// <summary>
    /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance25FlashOutputFormat
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
    public static class CreateTextToVideoRequestSeedance25FlashOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance25FlashOutputFormat value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance25FlashOutputFormat.Mov => "mov",
                CreateTextToVideoRequestSeedance25FlashOutputFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance25FlashOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTextToVideoRequestSeedance25FlashOutputFormat.Mov,
                "mp4" => CreateTextToVideoRequestSeedance25FlashOutputFormat.Mp4,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// Container for the output video. `mov` keeps high colour precision for grading and compositing. Defaults to `mp4`.
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance25FlashOutputFormat
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
    public static class CreateVideoToVideoRequestSeedance25FlashOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance25FlashOutputFormat value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance25FlashOutputFormat.Mov => "mov",
                CreateVideoToVideoRequestSeedance25FlashOutputFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance25FlashOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateVideoToVideoRequestSeedance25FlashOutputFormat.Mov,
                "mp4" => CreateVideoToVideoRequestSeedance25FlashOutputFormat.Mp4,
                _ => null,
            };
        }
    }
}
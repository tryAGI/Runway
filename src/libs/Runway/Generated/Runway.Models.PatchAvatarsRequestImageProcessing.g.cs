
#nullable enable

namespace Runway
{
    /// <summary>
    /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
    /// Default Value: optimize
    /// </summary>
    public enum PatchAvatarsRequestImageProcessing
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Optimize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAvatarsRequestImageProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsRequestImageProcessing value)
        {
            return value switch
            {
                PatchAvatarsRequestImageProcessing.None => "none",
                PatchAvatarsRequestImageProcessing.Optimize => "optimize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsRequestImageProcessing? ToEnum(string value)
        {
            return value switch
            {
                "none" => PatchAvatarsRequestImageProcessing.None,
                "optimize" => PatchAvatarsRequestImageProcessing.Optimize,
                _ => null,
            };
        }
    }
}
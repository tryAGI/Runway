
#nullable enable

namespace Runway
{
    /// <summary>
    /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
    /// Default Value: optimize
    /// </summary>
    public enum CreateAvatarsRequestImageProcessing
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
    public static class CreateAvatarsRequestImageProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsRequestImageProcessing value)
        {
            return value switch
            {
                CreateAvatarsRequestImageProcessing.None => "none",
                CreateAvatarsRequestImageProcessing.Optimize => "optimize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsRequestImageProcessing? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateAvatarsRequestImageProcessing.None,
                "optimize" => CreateAvatarsRequestImageProcessing.Optimize,
                _ => null,
            };
        }
    }
}
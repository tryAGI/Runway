
#nullable enable

namespace Runway
{
    /// <summary>
    /// Desired megapixel tier. Models that do not support the requested tier are excluded.
    /// </summary>
    public enum CreateGenerateImageRequestInputResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateImageRequestInputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageRequestInputResolution value)
        {
            return value switch
            {
                CreateGenerateImageRequestInputResolution.x1k => "1k",
                CreateGenerateImageRequestInputResolution.x2k => "2k",
                CreateGenerateImageRequestInputResolution.x4k => "4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageRequestInputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => CreateGenerateImageRequestInputResolution.x1k,
                "2k" => CreateGenerateImageRequestInputResolution.x2k,
                "4k" => CreateGenerateImageRequestInputResolution.x4k,
                _ => null,
            };
        }
    }
}
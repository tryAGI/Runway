
#nullable enable

namespace Runway
{
    /// <summary>
    /// Desired aspect ratio. Models that do not support the requested aspect are excluded.
    /// </summary>
    public enum CreateGenerateImageRequestInputAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateImageRequestInputAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageRequestInputAspectRatio value)
        {
            return value switch
            {
                CreateGenerateImageRequestInputAspectRatio.x16_9 => "16:9",
                CreateGenerateImageRequestInputAspectRatio.x1_1 => "1:1",
                CreateGenerateImageRequestInputAspectRatio.x21_9 => "21:9",
                CreateGenerateImageRequestInputAspectRatio.x2_3 => "2:3",
                CreateGenerateImageRequestInputAspectRatio.x3_2 => "3:2",
                CreateGenerateImageRequestInputAspectRatio.x3_4 => "3:4",
                CreateGenerateImageRequestInputAspectRatio.x4_3 => "4:3",
                CreateGenerateImageRequestInputAspectRatio.x4_5 => "4:5",
                CreateGenerateImageRequestInputAspectRatio.x5_4 => "5:4",
                CreateGenerateImageRequestInputAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageRequestInputAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateGenerateImageRequestInputAspectRatio.x16_9,
                "1:1" => CreateGenerateImageRequestInputAspectRatio.x1_1,
                "21:9" => CreateGenerateImageRequestInputAspectRatio.x21_9,
                "2:3" => CreateGenerateImageRequestInputAspectRatio.x2_3,
                "3:2" => CreateGenerateImageRequestInputAspectRatio.x3_2,
                "3:4" => CreateGenerateImageRequestInputAspectRatio.x3_4,
                "4:3" => CreateGenerateImageRequestInputAspectRatio.x4_3,
                "4:5" => CreateGenerateImageRequestInputAspectRatio.x4_5,
                "5:4" => CreateGenerateImageRequestInputAspectRatio.x5_4,
                "9:16" => CreateGenerateImageRequestInputAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
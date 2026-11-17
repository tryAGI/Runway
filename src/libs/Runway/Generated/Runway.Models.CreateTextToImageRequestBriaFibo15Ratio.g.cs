
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 1MP sizes cost 5 credits per image and 4MP sizes 10.
    /// </summary>
    public enum CreateTextToImageRequestBriaFibo15Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        ///
        /// </summary>
        x1024_576,
        /// <summary>
        ///
        /// </summary>
        x1024_768,
        /// <summary>
        ///
        /// </summary>
        x1152_2048,
        /// <summary>
        ///
        /// </summary>
        x1152_768,
        /// <summary>
        ///
        /// </summary>
        x1536_1920,
        /// <summary>
        ///
        /// </summary>
        x1536_2048,
        /// <summary>
        ///
        /// </summary>
        x1536_2304,
        /// <summary>
        ///
        /// </summary>
        x1920_1536,
        /// <summary>
        ///
        /// </summary>
        x2048_1152,
        /// <summary>
        ///
        /// </summary>
        x2048_1536,
        /// <summary>
        ///
        /// </summary>
        x2048_2048,
        /// <summary>
        ///
        /// </summary>
        x2304_1536,
        /// <summary>
        ///
        /// </summary>
        x576_1024,
        /// <summary>
        ///
        /// </summary>
        x768_1024,
        /// <summary>
        ///
        /// </summary>
        x768_1152,
        /// <summary>
        ///
        /// </summary>
        x768_960,
        /// <summary>
        ///
        /// </summary>
        x960_768,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestBriaFibo15RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestBriaFibo15Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestBriaFibo15Ratio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestBriaFibo15Ratio.x1024_576 => "1024:576",
                CreateTextToImageRequestBriaFibo15Ratio.x1024_768 => "1024:768",
                CreateTextToImageRequestBriaFibo15Ratio.x1152_2048 => "1152:2048",
                CreateTextToImageRequestBriaFibo15Ratio.x1152_768 => "1152:768",
                CreateTextToImageRequestBriaFibo15Ratio.x1536_1920 => "1536:1920",
                CreateTextToImageRequestBriaFibo15Ratio.x1536_2048 => "1536:2048",
                CreateTextToImageRequestBriaFibo15Ratio.x1536_2304 => "1536:2304",
                CreateTextToImageRequestBriaFibo15Ratio.x1920_1536 => "1920:1536",
                CreateTextToImageRequestBriaFibo15Ratio.x2048_1152 => "2048:1152",
                CreateTextToImageRequestBriaFibo15Ratio.x2048_1536 => "2048:1536",
                CreateTextToImageRequestBriaFibo15Ratio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestBriaFibo15Ratio.x2304_1536 => "2304:1536",
                CreateTextToImageRequestBriaFibo15Ratio.x576_1024 => "576:1024",
                CreateTextToImageRequestBriaFibo15Ratio.x768_1024 => "768:1024",
                CreateTextToImageRequestBriaFibo15Ratio.x768_1152 => "768:1152",
                CreateTextToImageRequestBriaFibo15Ratio.x768_960 => "768:960",
                CreateTextToImageRequestBriaFibo15Ratio.x960_768 => "960:768",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestBriaFibo15Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestBriaFibo15Ratio.x1024_1024,
                "1024:576" => CreateTextToImageRequestBriaFibo15Ratio.x1024_576,
                "1024:768" => CreateTextToImageRequestBriaFibo15Ratio.x1024_768,
                "1152:2048" => CreateTextToImageRequestBriaFibo15Ratio.x1152_2048,
                "1152:768" => CreateTextToImageRequestBriaFibo15Ratio.x1152_768,
                "1536:1920" => CreateTextToImageRequestBriaFibo15Ratio.x1536_1920,
                "1536:2048" => CreateTextToImageRequestBriaFibo15Ratio.x1536_2048,
                "1536:2304" => CreateTextToImageRequestBriaFibo15Ratio.x1536_2304,
                "1920:1536" => CreateTextToImageRequestBriaFibo15Ratio.x1920_1536,
                "2048:1152" => CreateTextToImageRequestBriaFibo15Ratio.x2048_1152,
                "2048:1536" => CreateTextToImageRequestBriaFibo15Ratio.x2048_1536,
                "2048:2048" => CreateTextToImageRequestBriaFibo15Ratio.x2048_2048,
                "2304:1536" => CreateTextToImageRequestBriaFibo15Ratio.x2304_1536,
                "576:1024" => CreateTextToImageRequestBriaFibo15Ratio.x576_1024,
                "768:1024" => CreateTextToImageRequestBriaFibo15Ratio.x768_1024,
                "768:1152" => CreateTextToImageRequestBriaFibo15Ratio.x768_1152,
                "768:960" => CreateTextToImageRequestBriaFibo15Ratio.x768_960,
                "960:768" => CreateTextToImageRequestBriaFibo15Ratio.x960_768,
                _ => null,
            };
        }
    }
}
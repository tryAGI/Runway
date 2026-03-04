
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum RequestVariant3Ratio3
    {
        /// <summary>
        /// 
        /// </summary>
        x1344_768,
        /// <summary>
        /// 
        /// </summary>
        x768_1344,
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1184_864,
        /// <summary>
        /// 
        /// </summary>
        x864_1184,
        /// <summary>
        /// 
        /// </summary>
        x1536_672,
        /// <summary>
        /// 
        /// </summary>
        x832_1248,
        /// <summary>
        /// 
        /// </summary>
        x1248_832,
        /// <summary>
        /// 
        /// </summary>
        x896_1152,
        /// <summary>
        /// 
        /// </summary>
        x1152_896,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant3Ratio3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant3Ratio3 value)
        {
            return value switch
            {
                RequestVariant3Ratio3.x1344_768 => "1344:768",
                RequestVariant3Ratio3.x768_1344 => "768:1344",
                RequestVariant3Ratio3.x1024_1024 => "1024:1024",
                RequestVariant3Ratio3.x1184_864 => "1184:864",
                RequestVariant3Ratio3.x864_1184 => "864:1184",
                RequestVariant3Ratio3.x1536_672 => "1536:672",
                RequestVariant3Ratio3.x832_1248 => "832:1248",
                RequestVariant3Ratio3.x1248_832 => "1248:832",
                RequestVariant3Ratio3.x896_1152 => "896:1152",
                RequestVariant3Ratio3.x1152_896 => "1152:896",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant3Ratio3? ToEnum(string value)
        {
            return value switch
            {
                "1344:768" => RequestVariant3Ratio3.x1344_768,
                "768:1344" => RequestVariant3Ratio3.x768_1344,
                "1024:1024" => RequestVariant3Ratio3.x1024_1024,
                "1184:864" => RequestVariant3Ratio3.x1184_864,
                "864:1184" => RequestVariant3Ratio3.x864_1184,
                "1536:672" => RequestVariant3Ratio3.x1536_672,
                "832:1248" => RequestVariant3Ratio3.x832_1248,
                "1248:832" => RequestVariant3Ratio3.x1248_832,
                "896:1152" => RequestVariant3Ratio3.x896_1152,
                "1152:896" => RequestVariant3Ratio3.x1152_896,
                _ => null,
            };
        }
    }
}
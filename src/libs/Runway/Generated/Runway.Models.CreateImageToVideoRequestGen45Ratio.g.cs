
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateImageToVideoRequestGen45Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1104_832,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1584_672,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGen45RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen45Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen45Ratio.x1104_832 => "1104:832",
                CreateImageToVideoRequestGen45Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestGen45Ratio.x1584_672 => "1584:672",
                CreateImageToVideoRequestGen45Ratio.x720_1280 => "720:1280",
                CreateImageToVideoRequestGen45Ratio.x832_1104 => "832:1104",
                CreateImageToVideoRequestGen45Ratio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen45Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1104:832" => CreateImageToVideoRequestGen45Ratio.x1104_832,
                "1280:720" => CreateImageToVideoRequestGen45Ratio.x1280_720,
                "1584:672" => CreateImageToVideoRequestGen45Ratio.x1584_672,
                "720:1280" => CreateImageToVideoRequestGen45Ratio.x720_1280,
                "832:1104" => CreateImageToVideoRequestGen45Ratio.x832_1104,
                "960:960" => CreateImageToVideoRequestGen45Ratio.x960_960,
                _ => null,
            };
        }
    }
}
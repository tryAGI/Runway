
#nullable enable

namespace Runway
{
    /// <summary>
    /// The ProRes profile to use. Only valid when `outputFormat` is `prores`. Defaults to `4444`.
    /// </summary>
    public enum CreateVideoToVideoRequestVariant1ProresProfile
    {
        /// <summary>
        /// 
        /// </summary>
        x422,
        /// <summary>
        /// 
        /// </summary>
        x422Hq,
        /// <summary>
        /// 
        /// </summary>
        x422Lt,
        /// <summary>
        /// 
        /// </summary>
        x422Proxy,
        /// <summary>
        /// 
        /// </summary>
        x4444,
        /// <summary>
        /// 
        /// </summary>
        x4444Xq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestVariant1ProresProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestVariant1ProresProfile value)
        {
            return value switch
            {
                CreateVideoToVideoRequestVariant1ProresProfile.x422 => "422",
                CreateVideoToVideoRequestVariant1ProresProfile.x422Hq => "422 HQ",
                CreateVideoToVideoRequestVariant1ProresProfile.x422Lt => "422 LT",
                CreateVideoToVideoRequestVariant1ProresProfile.x422Proxy => "422 Proxy",
                CreateVideoToVideoRequestVariant1ProresProfile.x4444 => "4444",
                CreateVideoToVideoRequestVariant1ProresProfile.x4444Xq => "4444 XQ",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestVariant1ProresProfile? ToEnum(string value)
        {
            return value switch
            {
                "422" => CreateVideoToVideoRequestVariant1ProresProfile.x422,
                "422 HQ" => CreateVideoToVideoRequestVariant1ProresProfile.x422Hq,
                "422 LT" => CreateVideoToVideoRequestVariant1ProresProfile.x422Lt,
                "422 Proxy" => CreateVideoToVideoRequestVariant1ProresProfile.x422Proxy,
                "4444" => CreateVideoToVideoRequestVariant1ProresProfile.x4444,
                "4444 XQ" => CreateVideoToVideoRequestVariant1ProresProfile.x4444Xq,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The ProRes profile to use. Only valid when `outputFormat` is `prores` or `hdr_prores`. For `prores`, any profile is accepted and the default is `4444`. For `hdr_prores`, only `422`, `422 HQ` and `4444` are available and the default is `422 HQ` — `422 Proxy` and `422 LT` quantize too heavily to hold the HDR gradients, and 12-bit output is served by `hdr_pq_12bit_master` instead of `4444 XQ`.
    /// </summary>
    public enum CreateImageToVideoRequestGen45ProresProfile
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
    public static class CreateImageToVideoRequestGen45ProresProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen45ProresProfile value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen45ProresProfile.x422 => "422",
                CreateImageToVideoRequestGen45ProresProfile.x422Hq => "422 HQ",
                CreateImageToVideoRequestGen45ProresProfile.x422Lt => "422 LT",
                CreateImageToVideoRequestGen45ProresProfile.x422Proxy => "422 Proxy",
                CreateImageToVideoRequestGen45ProresProfile.x4444 => "4444",
                CreateImageToVideoRequestGen45ProresProfile.x4444Xq => "4444 XQ",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen45ProresProfile? ToEnum(string value)
        {
            return value switch
            {
                "422" => CreateImageToVideoRequestGen45ProresProfile.x422,
                "422 HQ" => CreateImageToVideoRequestGen45ProresProfile.x422Hq,
                "422 LT" => CreateImageToVideoRequestGen45ProresProfile.x422Lt,
                "422 Proxy" => CreateImageToVideoRequestGen45ProresProfile.x422Proxy,
                "4444" => CreateImageToVideoRequestGen45ProresProfile.x4444,
                "4444 XQ" => CreateImageToVideoRequestGen45ProresProfile.x4444Xq,
                _ => null,
            };
        }
    }
}
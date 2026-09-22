
#nullable enable

namespace Runway
{
    /// <summary>
    /// Target frames per second. NTSC rates use underscored values (23_98, 29_97, 59_94).
    /// </summary>
    public enum CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate
    {
        /// <summary>
        ///
        /// </summary>
        x120,
        /// <summary>
        ///
        /// </summary>
        x2398,
        /// <summary>
        ///
        /// </summary>
        x24,
        /// <summary>
        ///
        /// </summary>
        x25,
        /// <summary>
        ///
        /// </summary>
        x2997,
        /// <summary>
        ///
        /// </summary>
        x30,
        /// <summary>
        ///
        /// </summary>
        x48,
        /// <summary>
        ///
        /// </summary>
        x50,
        /// <summary>
        ///
        /// </summary>
        x5994,
        /// <summary>
        ///
        /// </summary>
        x60,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate value)
        {
            return value switch
            {
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x120 => "120",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2398 => "23_98",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x24 => "24",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x25 => "25",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2997 => "29_97",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x30 => "30",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x48 => "48",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x50 => "50",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x5994 => "59_94",
                CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x60 => "60",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate? ToEnum(string value)
        {
            return value switch
            {
                "120" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x120,
                "23_98" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2398,
                "24" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x24,
                "25" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x25,
                "29_97" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2997,
                "30" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x30,
                "48" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x48,
                "50" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x50,
                "59_94" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x5994,
                "60" => CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x60,
                _ => null,
            };
        }
    }
}
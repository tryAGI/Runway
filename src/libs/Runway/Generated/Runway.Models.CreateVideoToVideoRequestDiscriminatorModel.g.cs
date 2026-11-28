
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVideoToVideoRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        Aleph2,
        /// <summary>
        ///
        /// </summary>
        GeminiOmniFlash,
        /// <summary>
        ///
        /// </summary>
        GeminiOmniFlash11,
        /// <summary>
        ///
        /// </summary>
        GeminiOmniFlash12,
        /// <summary>
        ///
        /// </summary>
        Hailuo3,
        /// <summary>
        ///
        /// </summary>
        Hailuo3Highspeed,
        /// <summary>
        ///
        /// </summary>
        Hailuo3Lite,
        /// <summary>
        ///
        /// </summary>
        KlingO34k,
        /// <summary>
        ///
        /// </summary>
        KlingO3Pro,
        /// <summary>
        ///
        /// </summary>
        KlingO3Standard,
        /// <summary>
        ///
        /// </summary>
        Kling4,
        /// <summary>
        ///
        /// </summary>
        Kling4Flash,
        /// <summary>
        ///
        /// </summary>
        Seedance2,
        /// <summary>
        ///
        /// </summary>
        Seedance25,
        /// <summary>
        ///
        /// </summary>
        Seedance25Flash,
        /// <summary>
        ///
        /// </summary>
        Seedance2Fast,
        /// <summary>
        ///
        /// </summary>
        Seedance2Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVideoToVideoRequestDiscriminatorModel.Aleph2 => "aleph2",
                CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash => "gemini_omni_flash",
                CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash11 => "gemini_omni_flash_1.1",
                CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash12 => "gemini_omni_flash_1.2",
                CreateVideoToVideoRequestDiscriminatorModel.Hailuo3 => "hailuo3",
                CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Highspeed => "hailuo3_highspeed",
                CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Lite => "hailuo3_lite",
                CreateVideoToVideoRequestDiscriminatorModel.KlingO34k => "klingO3_4k",
                CreateVideoToVideoRequestDiscriminatorModel.KlingO3Pro => "klingO3_pro",
                CreateVideoToVideoRequestDiscriminatorModel.KlingO3Standard => "klingO3_standard",
                CreateVideoToVideoRequestDiscriminatorModel.Kling4 => "kling_4",
                CreateVideoToVideoRequestDiscriminatorModel.Kling4Flash => "kling_4_flash",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance25 => "seedance2_5",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance25Flash => "seedance2_5_flash",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance2Mini => "seedance2_mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "aleph2" => CreateVideoToVideoRequestDiscriminatorModel.Aleph2,
                "gemini_omni_flash" => CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash,
                "gemini_omni_flash_1.1" => CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash11,
                "gemini_omni_flash_1.2" => CreateVideoToVideoRequestDiscriminatorModel.GeminiOmniFlash12,
                "hailuo3" => CreateVideoToVideoRequestDiscriminatorModel.Hailuo3,
                "hailuo3_highspeed" => CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Highspeed,
                "hailuo3_lite" => CreateVideoToVideoRequestDiscriminatorModel.Hailuo3Lite,
                "klingO3_4k" => CreateVideoToVideoRequestDiscriminatorModel.KlingO34k,
                "klingO3_pro" => CreateVideoToVideoRequestDiscriminatorModel.KlingO3Pro,
                "klingO3_standard" => CreateVideoToVideoRequestDiscriminatorModel.KlingO3Standard,
                "kling_4" => CreateVideoToVideoRequestDiscriminatorModel.Kling4,
                "kling_4_flash" => CreateVideoToVideoRequestDiscriminatorModel.Kling4Flash,
                "seedance2" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_5" => CreateVideoToVideoRequestDiscriminatorModel.Seedance25,
                "seedance2_5_flash" => CreateVideoToVideoRequestDiscriminatorModel.Seedance25Flash,
                "seedance2_fast" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2Mini,
                _ => null,
            };
        }
    }
}
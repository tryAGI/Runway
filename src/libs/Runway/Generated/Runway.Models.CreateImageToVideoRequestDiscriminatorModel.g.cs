
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVideoRequestDiscriminatorModel
    {
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
        Gen45,
        /// <summary>
        ///
        /// </summary>
        Gen4Turbo,
        /// <summary>
        ///
        /// </summary>
        GrokImagine15,
        /// <summary>
        ///
        /// </summary>
        GrokImagine15Lite,
        /// <summary>
        ///
        /// </summary>
        H3Max,
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
        Happyhorse10,
        /// <summary>
        ///
        /// </summary>
        Kling25TurboPro,
        /// <summary>
        ///
        /// </summary>
        Kling304k,
        /// <summary>
        ///
        /// </summary>
        Kling30Pro,
        /// <summary>
        ///
        /// </summary>
        Kling30Standard,
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
        /// <summary>
        ///
        /// </summary>
        Veo31,
        /// <summary>
        ///
        /// </summary>
        Veo31Fast,
        /// <summary>
        ///
        /// </summary>
        Wan3,
        /// <summary>
        ///
        /// </summary>
        Wan3Prime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash => "gemini_omni_flash",
                CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash11 => "gemini_omni_flash_1.1",
                CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash12 => "gemini_omni_flash_1.2",
                CreateImageToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo => "gen4_turbo",
                CreateImageToVideoRequestDiscriminatorModel.GrokImagine15 => "grok_imagine_1_5",
                CreateImageToVideoRequestDiscriminatorModel.GrokImagine15Lite => "grok_imagine_1_5_lite",
                CreateImageToVideoRequestDiscriminatorModel.H3Max => "h3_max",
                CreateImageToVideoRequestDiscriminatorModel.Hailuo3 => "hailuo3",
                CreateImageToVideoRequestDiscriminatorModel.Hailuo3Highspeed => "hailuo3_highspeed",
                CreateImageToVideoRequestDiscriminatorModel.Hailuo3Lite => "hailuo3_lite",
                CreateImageToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateImageToVideoRequestDiscriminatorModel.Kling25TurboPro => "kling2.5_turbo_pro",
                CreateImageToVideoRequestDiscriminatorModel.Kling304k => "kling3.0_4k",
                CreateImageToVideoRequestDiscriminatorModel.Kling30Pro => "kling3.0_pro",
                CreateImageToVideoRequestDiscriminatorModel.Kling30Standard => "kling3.0_standard",
                CreateImageToVideoRequestDiscriminatorModel.KlingO34k => "klingO3_4k",
                CreateImageToVideoRequestDiscriminatorModel.KlingO3Pro => "klingO3_pro",
                CreateImageToVideoRequestDiscriminatorModel.KlingO3Standard => "klingO3_standard",
                CreateImageToVideoRequestDiscriminatorModel.Kling4 => "kling_4",
                CreateImageToVideoRequestDiscriminatorModel.Kling4Flash => "kling_4_flash",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateImageToVideoRequestDiscriminatorModel.Seedance25 => "seedance2_5",
                CreateImageToVideoRequestDiscriminatorModel.Seedance25Flash => "seedance2_5_flash",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2Mini => "seedance2_mini",
                CreateImageToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateImageToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
                CreateImageToVideoRequestDiscriminatorModel.Wan3 => "wan3",
                CreateImageToVideoRequestDiscriminatorModel.Wan3Prime => "wan3_prime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini_omni_flash" => CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash,
                "gemini_omni_flash_1.1" => CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash11,
                "gemini_omni_flash_1.2" => CreateImageToVideoRequestDiscriminatorModel.GeminiOmniFlash12,
                "gen4.5" => CreateImageToVideoRequestDiscriminatorModel.Gen45,
                "gen4_turbo" => CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo,
                "grok_imagine_1_5" => CreateImageToVideoRequestDiscriminatorModel.GrokImagine15,
                "grok_imagine_1_5_lite" => CreateImageToVideoRequestDiscriminatorModel.GrokImagine15Lite,
                "h3_max" => CreateImageToVideoRequestDiscriminatorModel.H3Max,
                "hailuo3" => CreateImageToVideoRequestDiscriminatorModel.Hailuo3,
                "hailuo3_highspeed" => CreateImageToVideoRequestDiscriminatorModel.Hailuo3Highspeed,
                "hailuo3_lite" => CreateImageToVideoRequestDiscriminatorModel.Hailuo3Lite,
                "happyhorse_1_0" => CreateImageToVideoRequestDiscriminatorModel.Happyhorse10,
                "kling2.5_turbo_pro" => CreateImageToVideoRequestDiscriminatorModel.Kling25TurboPro,
                "kling3.0_4k" => CreateImageToVideoRequestDiscriminatorModel.Kling304k,
                "kling3.0_pro" => CreateImageToVideoRequestDiscriminatorModel.Kling30Pro,
                "kling3.0_standard" => CreateImageToVideoRequestDiscriminatorModel.Kling30Standard,
                "klingO3_4k" => CreateImageToVideoRequestDiscriminatorModel.KlingO34k,
                "klingO3_pro" => CreateImageToVideoRequestDiscriminatorModel.KlingO3Pro,
                "klingO3_standard" => CreateImageToVideoRequestDiscriminatorModel.KlingO3Standard,
                "kling_4" => CreateImageToVideoRequestDiscriminatorModel.Kling4,
                "kling_4_flash" => CreateImageToVideoRequestDiscriminatorModel.Kling4Flash,
                "seedance2" => CreateImageToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_5" => CreateImageToVideoRequestDiscriminatorModel.Seedance25,
                "seedance2_5_flash" => CreateImageToVideoRequestDiscriminatorModel.Seedance25Flash,
                "seedance2_fast" => CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateImageToVideoRequestDiscriminatorModel.Seedance2Mini,
                "veo3.1" => CreateImageToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateImageToVideoRequestDiscriminatorModel.Veo31Fast,
                "wan3" => CreateImageToVideoRequestDiscriminatorModel.Wan3,
                "wan3_prime" => CreateImageToVideoRequestDiscriminatorModel.Wan3Prime,
                _ => null,
            };
        }
    }
}
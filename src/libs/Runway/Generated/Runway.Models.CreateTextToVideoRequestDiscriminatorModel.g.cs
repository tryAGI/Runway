
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTextToVideoRequestDiscriminatorModel
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
    public static class CreateTextToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash => "gemini_omni_flash",
                CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash11 => "gemini_omni_flash_1.1",
                CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash12 => "gemini_omni_flash_1.2",
                CreateTextToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateTextToVideoRequestDiscriminatorModel.GrokImagine15 => "grok_imagine_1_5",
                CreateTextToVideoRequestDiscriminatorModel.GrokImagine15Lite => "grok_imagine_1_5_lite",
                CreateTextToVideoRequestDiscriminatorModel.H3Max => "h3_max",
                CreateTextToVideoRequestDiscriminatorModel.Hailuo3 => "hailuo3",
                CreateTextToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateTextToVideoRequestDiscriminatorModel.Kling25TurboPro => "kling2.5_turbo_pro",
                CreateTextToVideoRequestDiscriminatorModel.Kling304k => "kling3.0_4k",
                CreateTextToVideoRequestDiscriminatorModel.Kling30Pro => "kling3.0_pro",
                CreateTextToVideoRequestDiscriminatorModel.Kling30Standard => "kling3.0_standard",
                CreateTextToVideoRequestDiscriminatorModel.KlingO34k => "klingO3_4k",
                CreateTextToVideoRequestDiscriminatorModel.KlingO3Pro => "klingO3_pro",
                CreateTextToVideoRequestDiscriminatorModel.KlingO3Standard => "klingO3_standard",
                CreateTextToVideoRequestDiscriminatorModel.Kling4 => "kling_4",
                CreateTextToVideoRequestDiscriminatorModel.Kling4Flash => "kling_4_flash",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateTextToVideoRequestDiscriminatorModel.Seedance25 => "seedance2_5",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2Mini => "seedance2_mini",
                CreateTextToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateTextToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
                CreateTextToVideoRequestDiscriminatorModel.Wan3 => "wan3",
                CreateTextToVideoRequestDiscriminatorModel.Wan3Prime => "wan3_prime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini_omni_flash" => CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash,
                "gemini_omni_flash_1.1" => CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash11,
                "gemini_omni_flash_1.2" => CreateTextToVideoRequestDiscriminatorModel.GeminiOmniFlash12,
                "gen4.5" => CreateTextToVideoRequestDiscriminatorModel.Gen45,
                "grok_imagine_1_5" => CreateTextToVideoRequestDiscriminatorModel.GrokImagine15,
                "grok_imagine_1_5_lite" => CreateTextToVideoRequestDiscriminatorModel.GrokImagine15Lite,
                "h3_max" => CreateTextToVideoRequestDiscriminatorModel.H3Max,
                "hailuo3" => CreateTextToVideoRequestDiscriminatorModel.Hailuo3,
                "happyhorse_1_0" => CreateTextToVideoRequestDiscriminatorModel.Happyhorse10,
                "kling2.5_turbo_pro" => CreateTextToVideoRequestDiscriminatorModel.Kling25TurboPro,
                "kling3.0_4k" => CreateTextToVideoRequestDiscriminatorModel.Kling304k,
                "kling3.0_pro" => CreateTextToVideoRequestDiscriminatorModel.Kling30Pro,
                "kling3.0_standard" => CreateTextToVideoRequestDiscriminatorModel.Kling30Standard,
                "klingO3_4k" => CreateTextToVideoRequestDiscriminatorModel.KlingO34k,
                "klingO3_pro" => CreateTextToVideoRequestDiscriminatorModel.KlingO3Pro,
                "klingO3_standard" => CreateTextToVideoRequestDiscriminatorModel.KlingO3Standard,
                "kling_4" => CreateTextToVideoRequestDiscriminatorModel.Kling4,
                "kling_4_flash" => CreateTextToVideoRequestDiscriminatorModel.Kling4Flash,
                "seedance2" => CreateTextToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_5" => CreateTextToVideoRequestDiscriminatorModel.Seedance25,
                "seedance2_fast" => CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateTextToVideoRequestDiscriminatorModel.Seedance2Mini,
                "veo3.1" => CreateTextToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateTextToVideoRequestDiscriminatorModel.Veo31Fast,
                "wan3" => CreateTextToVideoRequestDiscriminatorModel.Wan3,
                "wan3_prime" => CreateTextToVideoRequestDiscriminatorModel.Wan3Prime,
                _ => null,
            };
        }
    }
}

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
        Gen45,
        /// <summary>
        ///
        /// </summary>
        GrokImagine15,
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
                CreateTextToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateTextToVideoRequestDiscriminatorModel.GrokImagine15 => "grok_imagine_1_5",
                CreateTextToVideoRequestDiscriminatorModel.Hailuo3 => "hailuo3",
                CreateTextToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateTextToVideoRequestDiscriminatorModel.Seedance25 => "seedance2_5",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2Mini => "seedance2_mini",
                CreateTextToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateTextToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
                CreateTextToVideoRequestDiscriminatorModel.Wan3 => "wan3",
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
                "gen4.5" => CreateTextToVideoRequestDiscriminatorModel.Gen45,
                "grok_imagine_1_5" => CreateTextToVideoRequestDiscriminatorModel.GrokImagine15,
                "hailuo3" => CreateTextToVideoRequestDiscriminatorModel.Hailuo3,
                "happyhorse_1_0" => CreateTextToVideoRequestDiscriminatorModel.Happyhorse10,
                "seedance2" => CreateTextToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_5" => CreateTextToVideoRequestDiscriminatorModel.Seedance25,
                "seedance2_fast" => CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateTextToVideoRequestDiscriminatorModel.Seedance2Mini,
                "veo3.1" => CreateTextToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateTextToVideoRequestDiscriminatorModel.Veo31Fast,
                "wan3" => CreateTextToVideoRequestDiscriminatorModel.Wan3,
                _ => null,
            };
        }
    }
}
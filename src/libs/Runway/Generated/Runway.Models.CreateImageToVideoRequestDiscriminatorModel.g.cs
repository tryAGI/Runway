
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
                CreateImageToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo => "gen4_turbo",
                CreateImageToVideoRequestDiscriminatorModel.GrokImagine15 => "grok_imagine_1_5",
                CreateImageToVideoRequestDiscriminatorModel.Hailuo3 => "hailuo3",
                CreateImageToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateImageToVideoRequestDiscriminatorModel.Seedance25 => "seedance2_5",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2Mini => "seedance2_mini",
                CreateImageToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateImageToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
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
                "gen4.5" => CreateImageToVideoRequestDiscriminatorModel.Gen45,
                "gen4_turbo" => CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo,
                "grok_imagine_1_5" => CreateImageToVideoRequestDiscriminatorModel.GrokImagine15,
                "hailuo3" => CreateImageToVideoRequestDiscriminatorModel.Hailuo3,
                "happyhorse_1_0" => CreateImageToVideoRequestDiscriminatorModel.Happyhorse10,
                "seedance2" => CreateImageToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_5" => CreateImageToVideoRequestDiscriminatorModel.Seedance25,
                "seedance2_fast" => CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateImageToVideoRequestDiscriminatorModel.Seedance2Mini,
                "veo3.1" => CreateImageToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateImageToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}

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
        Seedance2,
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
                CreateVideoToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
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
                "seedance2" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_fast" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2Fast,
                "seedance2_mini" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2Mini,
                _ => null,
            };
        }
    }
}
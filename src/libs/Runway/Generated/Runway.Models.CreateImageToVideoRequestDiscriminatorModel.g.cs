
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
        Gen45,
        /// <summary>
        /// 
        /// </summary>
        Gen4Turbo,
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
        Seedance2Fast,
        /// <summary>
        /// 
        /// </summary>
        Veo3,
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
                CreateImageToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo => "gen4_turbo",
                CreateImageToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateImageToVideoRequestDiscriminatorModel.Veo3 => "veo3",
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
                "gen4.5" => CreateImageToVideoRequestDiscriminatorModel.Gen45,
                "gen4_turbo" => CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo,
                "happyhorse_1_0" => CreateImageToVideoRequestDiscriminatorModel.Happyhorse10,
                "seedance2" => CreateImageToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_fast" => CreateImageToVideoRequestDiscriminatorModel.Seedance2Fast,
                "veo3" => CreateImageToVideoRequestDiscriminatorModel.Veo3,
                "veo3.1" => CreateImageToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateImageToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}
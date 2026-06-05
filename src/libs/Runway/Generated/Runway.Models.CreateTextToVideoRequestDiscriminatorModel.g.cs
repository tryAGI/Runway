
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
        Gen45,
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
    public static class CreateTextToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToVideoRequestDiscriminatorModel.Gen45 => "gen4.5",
                CreateTextToVideoRequestDiscriminatorModel.Happyhorse10 => "happyhorse_1_0",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
                CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast => "seedance2_fast",
                CreateTextToVideoRequestDiscriminatorModel.Veo3 => "veo3",
                CreateTextToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateTextToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
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
                "gen4.5" => CreateTextToVideoRequestDiscriminatorModel.Gen45,
                "happyhorse_1_0" => CreateTextToVideoRequestDiscriminatorModel.Happyhorse10,
                "seedance2" => CreateTextToVideoRequestDiscriminatorModel.Seedance2,
                "seedance2_fast" => CreateTextToVideoRequestDiscriminatorModel.Seedance2Fast,
                "veo3" => CreateTextToVideoRequestDiscriminatorModel.Veo3,
                "veo3.1" => CreateTextToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateTextToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}
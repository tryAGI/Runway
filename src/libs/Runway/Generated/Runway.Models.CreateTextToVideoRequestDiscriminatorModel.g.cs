
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
                "veo3" => CreateTextToVideoRequestDiscriminatorModel.Veo3,
                "veo3.1" => CreateTextToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateTextToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}
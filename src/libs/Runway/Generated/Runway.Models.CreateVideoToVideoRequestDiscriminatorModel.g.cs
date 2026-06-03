
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
        Gen4Aleph,
        /// <summary>
        /// 
        /// </summary>
        Seedance2,
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
                CreateVideoToVideoRequestDiscriminatorModel.Gen4Aleph => "gen4_aleph",
                CreateVideoToVideoRequestDiscriminatorModel.Seedance2 => "seedance2",
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
                "gen4_aleph" => CreateVideoToVideoRequestDiscriminatorModel.Gen4Aleph,
                "seedance2" => CreateVideoToVideoRequestDiscriminatorModel.Seedance2,
                _ => null,
            };
        }
    }
}
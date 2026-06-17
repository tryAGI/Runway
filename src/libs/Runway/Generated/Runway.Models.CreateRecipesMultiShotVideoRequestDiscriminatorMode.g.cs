
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRecipesMultiShotVideoRequestDiscriminatorMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesMultiShotVideoRequestDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesMultiShotVideoRequestDiscriminatorMode value)
        {
            return value switch
            {
                CreateRecipesMultiShotVideoRequestDiscriminatorMode.Auto => "auto",
                CreateRecipesMultiShotVideoRequestDiscriminatorMode.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesMultiShotVideoRequestDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateRecipesMultiShotVideoRequestDiscriminatorMode.Auto,
                "custom" => CreateRecipesMultiShotVideoRequestDiscriminatorMode.Custom,
                _ => null,
            };
        }
    }
}
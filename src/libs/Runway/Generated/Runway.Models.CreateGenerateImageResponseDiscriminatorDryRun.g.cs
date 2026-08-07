
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateImageResponseDiscriminatorDryRun
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateImageResponseDiscriminatorDryRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageResponseDiscriminatorDryRun value)
        {
            return value switch
            {
                CreateGenerateImageResponseDiscriminatorDryRun.False => "False",
                CreateGenerateImageResponseDiscriminatorDryRun.True => "True",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageResponseDiscriminatorDryRun? ToEnum(string value)
        {
            return value switch
            {
                "False" => CreateGenerateImageResponseDiscriminatorDryRun.False,
                "True" => CreateGenerateImageResponseDiscriminatorDryRun.True,
                _ => null,
            };
        }
    }
}
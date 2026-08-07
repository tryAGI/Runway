
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateVideoResponseDiscriminatorDryRun
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
    public static class CreateGenerateVideoResponseDiscriminatorDryRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseDiscriminatorDryRun value)
        {
            return value switch
            {
                CreateGenerateVideoResponseDiscriminatorDryRun.False => "False",
                CreateGenerateVideoResponseDiscriminatorDryRun.True => "True",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseDiscriminatorDryRun? ToEnum(string value)
        {
            return value switch
            {
                "False" => CreateGenerateVideoResponseDiscriminatorDryRun.False,
                "True" => CreateGenerateVideoResponseDiscriminatorDryRun.True,
                _ => null,
            };
        }
    }
}
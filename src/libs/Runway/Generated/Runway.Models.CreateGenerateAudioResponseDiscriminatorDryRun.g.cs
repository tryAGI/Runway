
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateAudioResponseDiscriminatorDryRun
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
    public static class CreateGenerateAudioResponseDiscriminatorDryRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseDiscriminatorDryRun value)
        {
            return value switch
            {
                CreateGenerateAudioResponseDiscriminatorDryRun.False => "False",
                CreateGenerateAudioResponseDiscriminatorDryRun.True => "True",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseDiscriminatorDryRun? ToEnum(string value)
        {
            return value switch
            {
                "False" => CreateGenerateAudioResponseDiscriminatorDryRun.False,
                "True" => CreateGenerateAudioResponseDiscriminatorDryRun.True,
                _ => null,
            };
        }
    }
}
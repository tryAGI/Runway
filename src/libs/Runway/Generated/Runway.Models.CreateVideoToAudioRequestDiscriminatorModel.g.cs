
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVideoToAudioRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        MireloSfx20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToAudioRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToAudioRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVideoToAudioRequestDiscriminatorModel.MireloSfx20 => "mirelo_sfx_2_0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToAudioRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "mirelo_sfx_2_0" => CreateVideoToAudioRequestDiscriminatorModel.MireloSfx20,
                _ => null,
            };
        }
    }
}
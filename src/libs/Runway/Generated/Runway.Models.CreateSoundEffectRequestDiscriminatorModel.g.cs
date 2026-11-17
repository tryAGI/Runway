
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSoundEffectRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        ElevenTextToSoundV2,
        /// <summary>
        ///
        /// </summary>
        MireloSfx20,
        /// <summary>
        ///
        /// </summary>
        SeedAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSoundEffectRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSoundEffectRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateSoundEffectRequestDiscriminatorModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateSoundEffectRequestDiscriminatorModel.MireloSfx20 => "mirelo_sfx_2_0",
                CreateSoundEffectRequestDiscriminatorModel.SeedAudio => "seed_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSoundEffectRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_text_to_sound_v2" => CreateSoundEffectRequestDiscriminatorModel.ElevenTextToSoundV2,
                "mirelo_sfx_2_0" => CreateSoundEffectRequestDiscriminatorModel.MireloSfx20,
                "seed_audio" => CreateSoundEffectRequestDiscriminatorModel.SeedAudio,
                _ => null,
            };
        }
    }
}
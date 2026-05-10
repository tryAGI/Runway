
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTextToImageRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        GeminiImage3Pro,
        /// <summary>
        /// 
        /// </summary>
        Gen4Image,
        /// <summary>
        /// 
        /// </summary>
        Gen4ImageTurbo,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToImageRequestDiscriminatorModel.Gemini25Flash => "gemini_2.5_flash",
                CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro => "gemini_image3_pro",
                CreateTextToImageRequestDiscriminatorModel.Gen4Image => "gen4_image",
                CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateTextToImageRequestDiscriminatorModel.GptImage2 => "gpt_image_2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini_2.5_flash" => CreateTextToImageRequestDiscriminatorModel.Gemini25Flash,
                "gemini_image3_pro" => CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro,
                "gen4_image" => CreateTextToImageRequestDiscriminatorModel.Gen4Image,
                "gen4_image_turbo" => CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo,
                "gpt_image_2" => CreateTextToImageRequestDiscriminatorModel.GptImage2,
                _ => null,
            };
        }
    }
}
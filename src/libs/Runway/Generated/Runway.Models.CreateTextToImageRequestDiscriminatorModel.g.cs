
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
        BriaFibo15,
        /// <summary>
        ///
        /// </summary>
        BriaFiboEdit15,
        /// <summary>
        ///
        /// </summary>
        Gemini25Flash,
        /// <summary>
        ///
        /// </summary>
        GeminiImage31Flash,
        /// <summary>
        ///
        /// </summary>
        GeminiImage31FlashLite,
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
        /// <summary>
        ///
        /// </summary>
        GptImage25Flare,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst,
        /// <summary>
        ///
        /// </summary>
        GptImage26Flare,
        /// <summary>
        ///
        /// </summary>
        GptImage26Sunburst,
        /// <summary>
        ///
        /// </summary>
        GrokImagineImage2,
        /// <summary>
        ///
        /// </summary>
        Ideogram40,
        /// <summary>
        ///
        /// </summary>
        Ideogram45,
        /// <summary>
        ///
        /// </summary>
        IdeogramVector,
        /// <summary>
        ///
        /// </summary>
        MinimaxH3Image,
        /// <summary>
        ///
        /// </summary>
        MuseImage,
        /// <summary>
        ///
        /// </summary>
        NanoBanana21,
        /// <summary>
        ///
        /// </summary>
        RecraftV41Flash,
        /// <summary>
        ///
        /// </summary>
        RecraftV41Vector,
        /// <summary>
        ///
        /// </summary>
        Seedream55,
        /// <summary>
        ///
        /// </summary>
        Seedream55Layers,
        /// <summary>
        ///
        /// </summary>
        Seedream5Flash,
        /// <summary>
        ///
        /// </summary>
        Seedream5Lite,
        /// <summary>
        ///
        /// </summary>
        Seedream5Pro,
        /// <summary>
        ///
        /// </summary>
        Seedream5ProLayers,
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
                CreateTextToImageRequestDiscriminatorModel.BriaFibo15 => "bria_fibo_1_5",
                CreateTextToImageRequestDiscriminatorModel.BriaFiboEdit15 => "bria_fibo_edit_1_5",
                CreateTextToImageRequestDiscriminatorModel.Gemini25Flash => "gemini_2.5_flash",
                CreateTextToImageRequestDiscriminatorModel.GeminiImage31Flash => "gemini_image3.1_flash",
                CreateTextToImageRequestDiscriminatorModel.GeminiImage31FlashLite => "gemini_image3.1_flash_lite",
                CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro => "gemini_image3_pro",
                CreateTextToImageRequestDiscriminatorModel.Gen4Image => "gen4_image",
                CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateTextToImageRequestDiscriminatorModel.GptImage2 => "gpt_image_2",
                CreateTextToImageRequestDiscriminatorModel.GptImage25Flare => "gpt_image_2_5_flare",
                CreateTextToImageRequestDiscriminatorModel.GptImage25Sunburst => "gpt_image_2_5_sunburst",
                CreateTextToImageRequestDiscriminatorModel.GptImage26Flare => "gpt_image_2_6_flare",
                CreateTextToImageRequestDiscriminatorModel.GptImage26Sunburst => "gpt_image_2_6_sunburst",
                CreateTextToImageRequestDiscriminatorModel.GrokImagineImage2 => "grok_imagine_image_2",
                CreateTextToImageRequestDiscriminatorModel.Ideogram40 => "ideogram_4_0",
                CreateTextToImageRequestDiscriminatorModel.Ideogram45 => "ideogram_4_5",
                CreateTextToImageRequestDiscriminatorModel.IdeogramVector => "ideogram_vector",
                CreateTextToImageRequestDiscriminatorModel.MinimaxH3Image => "minimax_h3_image",
                CreateTextToImageRequestDiscriminatorModel.MuseImage => "muse_image",
                CreateTextToImageRequestDiscriminatorModel.NanoBanana21 => "nano_banana_2.1",
                CreateTextToImageRequestDiscriminatorModel.RecraftV41Flash => "recraft_v4_1_flash",
                CreateTextToImageRequestDiscriminatorModel.RecraftV41Vector => "recraft_v4_1_vector",
                CreateTextToImageRequestDiscriminatorModel.Seedream55 => "seedream5.5",
                CreateTextToImageRequestDiscriminatorModel.Seedream55Layers => "seedream5.5_layers",
                CreateTextToImageRequestDiscriminatorModel.Seedream5Flash => "seedream5_flash",
                CreateTextToImageRequestDiscriminatorModel.Seedream5Lite => "seedream5_lite",
                CreateTextToImageRequestDiscriminatorModel.Seedream5Pro => "seedream5_pro",
                CreateTextToImageRequestDiscriminatorModel.Seedream5ProLayers => "seedream5_pro_layers",
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
                "bria_fibo_1_5" => CreateTextToImageRequestDiscriminatorModel.BriaFibo15,
                "bria_fibo_edit_1_5" => CreateTextToImageRequestDiscriminatorModel.BriaFiboEdit15,
                "gemini_2.5_flash" => CreateTextToImageRequestDiscriminatorModel.Gemini25Flash,
                "gemini_image3.1_flash" => CreateTextToImageRequestDiscriminatorModel.GeminiImage31Flash,
                "gemini_image3.1_flash_lite" => CreateTextToImageRequestDiscriminatorModel.GeminiImage31FlashLite,
                "gemini_image3_pro" => CreateTextToImageRequestDiscriminatorModel.GeminiImage3Pro,
                "gen4_image" => CreateTextToImageRequestDiscriminatorModel.Gen4Image,
                "gen4_image_turbo" => CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo,
                "gpt_image_2" => CreateTextToImageRequestDiscriminatorModel.GptImage2,
                "gpt_image_2_5_flare" => CreateTextToImageRequestDiscriminatorModel.GptImage25Flare,
                "gpt_image_2_5_sunburst" => CreateTextToImageRequestDiscriminatorModel.GptImage25Sunburst,
                "gpt_image_2_6_flare" => CreateTextToImageRequestDiscriminatorModel.GptImage26Flare,
                "gpt_image_2_6_sunburst" => CreateTextToImageRequestDiscriminatorModel.GptImage26Sunburst,
                "grok_imagine_image_2" => CreateTextToImageRequestDiscriminatorModel.GrokImagineImage2,
                "ideogram_4_0" => CreateTextToImageRequestDiscriminatorModel.Ideogram40,
                "ideogram_4_5" => CreateTextToImageRequestDiscriminatorModel.Ideogram45,
                "ideogram_vector" => CreateTextToImageRequestDiscriminatorModel.IdeogramVector,
                "minimax_h3_image" => CreateTextToImageRequestDiscriminatorModel.MinimaxH3Image,
                "muse_image" => CreateTextToImageRequestDiscriminatorModel.MuseImage,
                "nano_banana_2.1" => CreateTextToImageRequestDiscriminatorModel.NanoBanana21,
                "recraft_v4_1_flash" => CreateTextToImageRequestDiscriminatorModel.RecraftV41Flash,
                "recraft_v4_1_vector" => CreateTextToImageRequestDiscriminatorModel.RecraftV41Vector,
                "seedream5.5" => CreateTextToImageRequestDiscriminatorModel.Seedream55,
                "seedream5.5_layers" => CreateTextToImageRequestDiscriminatorModel.Seedream55Layers,
                "seedream5_flash" => CreateTextToImageRequestDiscriminatorModel.Seedream5Flash,
                "seedream5_lite" => CreateTextToImageRequestDiscriminatorModel.Seedream5Lite,
                "seedream5_pro" => CreateTextToImageRequestDiscriminatorModel.Seedream5Pro,
                "seedream5_pro_layers" => CreateTextToImageRequestDiscriminatorModel.Seedream5ProLayers,
                _ => null,
            };
        }
    }
}
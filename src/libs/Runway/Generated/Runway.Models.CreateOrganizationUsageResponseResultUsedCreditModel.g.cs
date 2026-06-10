
#nullable enable

namespace Runway
{
    /// <summary>
    /// The model that credits were spent on.
    /// </summary>
    public enum CreateOrganizationUsageResponseResultUsedCreditModel
    {
        /// <summary>
        /// 
        /// </summary>
        ActTwo,
        /// <summary>
        /// 
        /// </summary>
        Aleph2,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualStsV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenScribeV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTextToSoundV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenV3,
        /// <summary>
        /// 
        /// </summary>
        ElevenVoiceDubbing,
        /// <summary>
        /// 
        /// </summary>
        ElevenVoiceIsolation,
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
        GeminiImage3Pro,
        /// <summary>
        /// 
        /// </summary>
        Gen3aTurbo,
        /// <summary>
        /// 
        /// </summary>
        Gen45,
        /// <summary>
        /// 
        /// </summary>
        Gen4Aleph,
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
        Gen4Turbo,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        Gwm1AvatarAsyncAudioToVideo,
        /// <summary>
        /// 
        /// </summary>
        Gwm1AvatarAsyncTextToVideo,
        /// <summary>
        /// 
        /// </summary>
        Gwm1Avatars,
        /// <summary>
        /// 
        /// </summary>
        Happyhorse10,
        /// <summary>
        /// 
        /// </summary>
        Kling25TurboPro,
        /// <summary>
        /// 
        /// </summary>
        Kling304k,
        /// <summary>
        /// 
        /// </summary>
        Kling30Pro,
        /// <summary>
        /// 
        /// </summary>
        Kling30Standard,
        /// <summary>
        /// 
        /// </summary>
        KlingO34k,
        /// <summary>
        /// 
        /// </summary>
        KlingO3Pro,
        /// <summary>
        /// 
        /// </summary>
        KlingO3Standard,
        /// <summary>
        /// 
        /// </summary>
        MagnificPrecisionUpscalerV2,
        /// <summary>
        /// 
        /// </summary>
        ProductSwap,
        /// <summary>
        /// 
        /// </summary>
        Seedance2,
        /// <summary>
        /// 
        /// </summary>
        Seedance2Fast,
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
        /// <summary>
        /// 
        /// </summary>
        VoiceProcessing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationUsageResponseResultUsedCreditModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationUsageResponseResultUsedCreditModel value)
        {
            return value switch
            {
                CreateOrganizationUsageResponseResultUsedCreditModel.ActTwo => "act_two",
                CreateOrganizationUsageResponseResultUsedCreditModel.Aleph2 => "aleph2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenScribeV2 => "eleven_scribe_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV3 => "eleven_v3",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash => "gemini_2.5_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31Flash => "gemini_image3.1_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage3Pro => "gemini_image3_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo => "gen3a_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen45 => "gen4.5",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph => "gen4_aleph",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image => "gen4_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo => "gen4_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.GptImage2 => "gpt_image_2",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncAudioToVideo => "gwm1_avatar_async_audio_to_video",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncTextToVideo => "gwm1_avatar_async_text_to_video",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1Avatars => "gwm1_avatars",
                CreateOrganizationUsageResponseResultUsedCreditModel.Happyhorse10 => "happyhorse_1_0",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling25TurboPro => "kling2.5_turbo_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling304k => "kling3.0_4k",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Pro => "kling3.0_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Standard => "kling3.0_standard",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO34k => "klingO3_4k",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Pro => "klingO3_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Standard => "klingO3_standard",
                CreateOrganizationUsageResponseResultUsedCreditModel.MagnificPrecisionUpscalerV2 => "magnific_precision_upscaler_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ProductSwap => "product_swap",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2 => "seedance2",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Fast => "seedance2_fast",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo3 => "veo3",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31 => "veo3.1",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast => "veo3.1_fast",
                CreateOrganizationUsageResponseResultUsedCreditModel.VoiceProcessing => "voice_processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationUsageResponseResultUsedCreditModel? ToEnum(string value)
        {
            return value switch
            {
                "act_two" => CreateOrganizationUsageResponseResultUsedCreditModel.ActTwo,
                "aleph2" => CreateOrganizationUsageResponseResultUsedCreditModel.Aleph2,
                "eleven_multilingual_sts_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2,
                "eleven_multilingual_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2,
                "eleven_scribe_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenScribeV2,
                "eleven_text_to_sound_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2,
                "eleven_v3" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV3,
                "eleven_voice_dubbing" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing,
                "eleven_voice_isolation" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation,
                "gemini_2.5_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash,
                "gemini_image3.1_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31Flash,
                "gemini_image3_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage3Pro,
                "gen3a_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo,
                "gen4.5" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen45,
                "gen4_aleph" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph,
                "gen4_image" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image,
                "gen4_image_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo,
                "gen4_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo,
                "gpt_image_2" => CreateOrganizationUsageResponseResultUsedCreditModel.GptImage2,
                "gwm1_avatar_async_audio_to_video" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncAudioToVideo,
                "gwm1_avatar_async_text_to_video" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncTextToVideo,
                "gwm1_avatars" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1Avatars,
                "happyhorse_1_0" => CreateOrganizationUsageResponseResultUsedCreditModel.Happyhorse10,
                "kling2.5_turbo_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling25TurboPro,
                "kling3.0_4k" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling304k,
                "kling3.0_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Pro,
                "kling3.0_standard" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Standard,
                "klingO3_4k" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO34k,
                "klingO3_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Pro,
                "klingO3_standard" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Standard,
                "magnific_precision_upscaler_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.MagnificPrecisionUpscalerV2,
                "product_swap" => CreateOrganizationUsageResponseResultUsedCreditModel.ProductSwap,
                "seedance2" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2,
                "seedance2_fast" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Fast,
                "veo3" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo3,
                "veo3.1" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31,
                "veo3.1_fast" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast,
                "voice_processing" => CreateOrganizationUsageResponseResultUsedCreditModel.VoiceProcessing,
                _ => null,
            };
        }
    }
}
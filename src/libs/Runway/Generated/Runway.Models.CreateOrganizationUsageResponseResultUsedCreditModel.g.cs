
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
        AdLocalization,
        /// <summary>
        ///
        /// </summary>
        Aleph2,
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
        ElevenV4,
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
        EnhanceFrameRate,
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
        GeminiOmniFlash,
        /// <summary>
        ///
        /// </summary>
        GeminiOmniFlash11,
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
        GptImage25Flare,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst,
        /// <summary>
        ///
        /// </summary>
        GrokImagine15,
        /// <summary>
        ///
        /// </summary>
        GrokImagine15Lite,
        /// <summary>
        ///
        /// </summary>
        GrokImagineImage2,
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
        H3Max,
        /// <summary>
        ///
        /// </summary>
        Hailuo3,
        /// <summary>
        ///
        /// </summary>
        Happyhorse10,
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
        Kling4,
        /// <summary>
        ///
        /// </summary>
        MagnificPrecisionUpscalerV2,
        /// <summary>
        ///
        /// </summary>
        MagnificVideoUpscalerCreative,
        /// <summary>
        ///
        /// </summary>
        MarketingStockImage,
        /// <summary>
        ///
        /// </summary>
        MireloSfx20,
        /// <summary>
        ///
        /// </summary>
        MultiShotVideo,
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
        ProductAd,
        /// <summary>
        ///
        /// </summary>
        ProductCampaignImage,
        /// <summary>
        ///
        /// </summary>
        ProductSwap,
        /// <summary>
        ///
        /// </summary>
        ProductUgc,
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
        Ruby,
        /// <summary>
        ///
        /// </summary>
        SeedAudio,
        /// <summary>
        ///
        /// </summary>
        Seedance2,
        /// <summary>
        ///
        /// </summary>
        Seedance25,
        /// <summary>
        ///
        /// </summary>
        Seedance2Fast,
        /// <summary>
        ///
        /// </summary>
        Seedance2Mini,
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
        /// <summary>
        ///
        /// </summary>
        Wan3,
        /// <summary>
        ///
        /// </summary>
        Wan3Prime,
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
                CreateOrganizationUsageResponseResultUsedCreditModel.AdLocalization => "ad_localization",
                CreateOrganizationUsageResponseResultUsedCreditModel.Aleph2 => "aleph2",
                CreateOrganizationUsageResponseResultUsedCreditModel.BriaFibo15 => "bria_fibo_1_5",
                CreateOrganizationUsageResponseResultUsedCreditModel.BriaFiboEdit15 => "bria_fibo_edit_1_5",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenScribeV2 => "eleven_scribe_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV3 => "eleven_v3",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV4 => "eleven_v4",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                CreateOrganizationUsageResponseResultUsedCreditModel.EnhanceFrameRate => "enhance_frame_rate",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash => "gemini_2.5_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31Flash => "gemini_image3.1_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31FlashLite => "gemini_image3.1_flash_lite",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage3Pro => "gemini_image3_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiOmniFlash => "gemini_omni_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.GeminiOmniFlash11 => "gemini_omni_flash_1.1",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo => "gen3a_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen45 => "gen4.5",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph => "gen4_aleph",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image => "gen4_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo => "gen4_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.GptImage2 => "gpt_image_2",
                CreateOrganizationUsageResponseResultUsedCreditModel.GptImage25Flare => "gpt_image_2_5_flare",
                CreateOrganizationUsageResponseResultUsedCreditModel.GptImage25Sunburst => "gpt_image_2_5_sunburst",
                CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagine15 => "grok_imagine_1_5",
                CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagine15Lite => "grok_imagine_1_5_lite",
                CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagineImage2 => "grok_imagine_image_2",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncAudioToVideo => "gwm1_avatar_async_audio_to_video",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncTextToVideo => "gwm1_avatar_async_text_to_video",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1Avatars => "gwm1_avatars",
                CreateOrganizationUsageResponseResultUsedCreditModel.H3Max => "h3_max",
                CreateOrganizationUsageResponseResultUsedCreditModel.Hailuo3 => "hailuo3",
                CreateOrganizationUsageResponseResultUsedCreditModel.Happyhorse10 => "happyhorse_1_0",
                CreateOrganizationUsageResponseResultUsedCreditModel.Ideogram40 => "ideogram_4_0",
                CreateOrganizationUsageResponseResultUsedCreditModel.Ideogram45 => "ideogram_4_5",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling25TurboPro => "kling2.5_turbo_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling304k => "kling3.0_4k",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Pro => "kling3.0_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Standard => "kling3.0_standard",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO34k => "klingO3_4k",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Pro => "klingO3_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Standard => "klingO3_standard",
                CreateOrganizationUsageResponseResultUsedCreditModel.Kling4 => "kling_4",
                CreateOrganizationUsageResponseResultUsedCreditModel.MagnificPrecisionUpscalerV2 => "magnific_precision_upscaler_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.MagnificVideoUpscalerCreative => "magnific_video_upscaler_creative",
                CreateOrganizationUsageResponseResultUsedCreditModel.MarketingStockImage => "marketing_stock_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.MireloSfx20 => "mirelo_sfx_2_0",
                CreateOrganizationUsageResponseResultUsedCreditModel.MultiShotVideo => "multi_shot_video",
                CreateOrganizationUsageResponseResultUsedCreditModel.MuseImage => "muse_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.NanoBanana21 => "nano_banana_2.1",
                CreateOrganizationUsageResponseResultUsedCreditModel.ProductAd => "product_ad",
                CreateOrganizationUsageResponseResultUsedCreditModel.ProductCampaignImage => "product_campaign_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.ProductSwap => "product_swap",
                CreateOrganizationUsageResponseResultUsedCreditModel.ProductUgc => "product_ugc",
                CreateOrganizationUsageResponseResultUsedCreditModel.RecraftV41Flash => "recraft_v4_1_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.RecraftV41Vector => "recraft_v4_1_vector",
                CreateOrganizationUsageResponseResultUsedCreditModel.Ruby => "ruby",
                CreateOrganizationUsageResponseResultUsedCreditModel.SeedAudio => "seed_audio",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2 => "seedance2",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance25 => "seedance2_5",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Fast => "seedance2_fast",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Mini => "seedance2_mini",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Flash => "seedream5_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Lite => "seedream5_lite",
                CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Pro => "seedream5_pro",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo3 => "veo3",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31 => "veo3.1",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast => "veo3.1_fast",
                CreateOrganizationUsageResponseResultUsedCreditModel.VoiceProcessing => "voice_processing",
                CreateOrganizationUsageResponseResultUsedCreditModel.Wan3 => "wan3",
                CreateOrganizationUsageResponseResultUsedCreditModel.Wan3Prime => "wan3_prime",
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
                "ad_localization" => CreateOrganizationUsageResponseResultUsedCreditModel.AdLocalization,
                "aleph2" => CreateOrganizationUsageResponseResultUsedCreditModel.Aleph2,
                "bria_fibo_1_5" => CreateOrganizationUsageResponseResultUsedCreditModel.BriaFibo15,
                "bria_fibo_edit_1_5" => CreateOrganizationUsageResponseResultUsedCreditModel.BriaFiboEdit15,
                "eleven_multilingual_sts_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2,
                "eleven_multilingual_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2,
                "eleven_scribe_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenScribeV2,
                "eleven_text_to_sound_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2,
                "eleven_v3" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV3,
                "eleven_v4" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenV4,
                "eleven_voice_dubbing" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing,
                "eleven_voice_isolation" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation,
                "enhance_frame_rate" => CreateOrganizationUsageResponseResultUsedCreditModel.EnhanceFrameRate,
                "gemini_2.5_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash,
                "gemini_image3.1_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31Flash,
                "gemini_image3.1_flash_lite" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage31FlashLite,
                "gemini_image3_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiImage3Pro,
                "gemini_omni_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiOmniFlash,
                "gemini_omni_flash_1.1" => CreateOrganizationUsageResponseResultUsedCreditModel.GeminiOmniFlash11,
                "gen3a_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo,
                "gen4.5" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen45,
                "gen4_aleph" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph,
                "gen4_image" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image,
                "gen4_image_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo,
                "gen4_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo,
                "gpt_image_2" => CreateOrganizationUsageResponseResultUsedCreditModel.GptImage2,
                "gpt_image_2_5_flare" => CreateOrganizationUsageResponseResultUsedCreditModel.GptImage25Flare,
                "gpt_image_2_5_sunburst" => CreateOrganizationUsageResponseResultUsedCreditModel.GptImage25Sunburst,
                "grok_imagine_1_5" => CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagine15,
                "grok_imagine_1_5_lite" => CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagine15Lite,
                "grok_imagine_image_2" => CreateOrganizationUsageResponseResultUsedCreditModel.GrokImagineImage2,
                "gwm1_avatar_async_audio_to_video" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncAudioToVideo,
                "gwm1_avatar_async_text_to_video" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1AvatarAsyncTextToVideo,
                "gwm1_avatars" => CreateOrganizationUsageResponseResultUsedCreditModel.Gwm1Avatars,
                "h3_max" => CreateOrganizationUsageResponseResultUsedCreditModel.H3Max,
                "hailuo3" => CreateOrganizationUsageResponseResultUsedCreditModel.Hailuo3,
                "happyhorse_1_0" => CreateOrganizationUsageResponseResultUsedCreditModel.Happyhorse10,
                "ideogram_4_0" => CreateOrganizationUsageResponseResultUsedCreditModel.Ideogram40,
                "ideogram_4_5" => CreateOrganizationUsageResponseResultUsedCreditModel.Ideogram45,
                "kling2.5_turbo_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling25TurboPro,
                "kling3.0_4k" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling304k,
                "kling3.0_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Pro,
                "kling3.0_standard" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling30Standard,
                "klingO3_4k" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO34k,
                "klingO3_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Pro,
                "klingO3_standard" => CreateOrganizationUsageResponseResultUsedCreditModel.KlingO3Standard,
                "kling_4" => CreateOrganizationUsageResponseResultUsedCreditModel.Kling4,
                "magnific_precision_upscaler_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.MagnificPrecisionUpscalerV2,
                "magnific_video_upscaler_creative" => CreateOrganizationUsageResponseResultUsedCreditModel.MagnificVideoUpscalerCreative,
                "marketing_stock_image" => CreateOrganizationUsageResponseResultUsedCreditModel.MarketingStockImage,
                "mirelo_sfx_2_0" => CreateOrganizationUsageResponseResultUsedCreditModel.MireloSfx20,
                "multi_shot_video" => CreateOrganizationUsageResponseResultUsedCreditModel.MultiShotVideo,
                "muse_image" => CreateOrganizationUsageResponseResultUsedCreditModel.MuseImage,
                "nano_banana_2.1" => CreateOrganizationUsageResponseResultUsedCreditModel.NanoBanana21,
                "product_ad" => CreateOrganizationUsageResponseResultUsedCreditModel.ProductAd,
                "product_campaign_image" => CreateOrganizationUsageResponseResultUsedCreditModel.ProductCampaignImage,
                "product_swap" => CreateOrganizationUsageResponseResultUsedCreditModel.ProductSwap,
                "product_ugc" => CreateOrganizationUsageResponseResultUsedCreditModel.ProductUgc,
                "recraft_v4_1_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.RecraftV41Flash,
                "recraft_v4_1_vector" => CreateOrganizationUsageResponseResultUsedCreditModel.RecraftV41Vector,
                "ruby" => CreateOrganizationUsageResponseResultUsedCreditModel.Ruby,
                "seed_audio" => CreateOrganizationUsageResponseResultUsedCreditModel.SeedAudio,
                "seedance2" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2,
                "seedance2_5" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance25,
                "seedance2_fast" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Fast,
                "seedance2_mini" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedance2Mini,
                "seedream5_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Flash,
                "seedream5_lite" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Lite,
                "seedream5_pro" => CreateOrganizationUsageResponseResultUsedCreditModel.Seedream5Pro,
                "veo3" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo3,
                "veo3.1" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31,
                "veo3.1_fast" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast,
                "voice_processing" => CreateOrganizationUsageResponseResultUsedCreditModel.VoiceProcessing,
                "wan3" => CreateOrganizationUsageResponseResultUsedCreditModel.Wan3,
                "wan3_prime" => CreateOrganizationUsageResponseResultUsedCreditModel.Wan3Prime,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// A model that was used during the queried time range.
    /// </summary>
    public enum CreateOrganizationUsageResponseModel
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
    public static class CreateOrganizationUsageResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationUsageResponseModel value)
        {
            return value switch
            {
                CreateOrganizationUsageResponseModel.ActTwo => "act_two",
                CreateOrganizationUsageResponseModel.AdLocalization => "ad_localization",
                CreateOrganizationUsageResponseModel.Aleph2 => "aleph2",
                CreateOrganizationUsageResponseModel.BriaFibo15 => "bria_fibo_1_5",
                CreateOrganizationUsageResponseModel.BriaFiboEdit15 => "bria_fibo_edit_1_5",
                CreateOrganizationUsageResponseModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                CreateOrganizationUsageResponseModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateOrganizationUsageResponseModel.ElevenScribeV2 => "eleven_scribe_v2",
                CreateOrganizationUsageResponseModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateOrganizationUsageResponseModel.ElevenV3 => "eleven_v3",
                CreateOrganizationUsageResponseModel.ElevenV4 => "eleven_v4",
                CreateOrganizationUsageResponseModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                CreateOrganizationUsageResponseModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                CreateOrganizationUsageResponseModel.EnhanceFrameRate => "enhance_frame_rate",
                CreateOrganizationUsageResponseModel.Gemini25Flash => "gemini_2.5_flash",
                CreateOrganizationUsageResponseModel.GeminiImage31Flash => "gemini_image3.1_flash",
                CreateOrganizationUsageResponseModel.GeminiImage31FlashLite => "gemini_image3.1_flash_lite",
                CreateOrganizationUsageResponseModel.GeminiImage3Pro => "gemini_image3_pro",
                CreateOrganizationUsageResponseModel.GeminiOmniFlash => "gemini_omni_flash",
                CreateOrganizationUsageResponseModel.GeminiOmniFlash11 => "gemini_omni_flash_1.1",
                CreateOrganizationUsageResponseModel.Gen3aTurbo => "gen3a_turbo",
                CreateOrganizationUsageResponseModel.Gen45 => "gen4.5",
                CreateOrganizationUsageResponseModel.Gen4Aleph => "gen4_aleph",
                CreateOrganizationUsageResponseModel.Gen4Image => "gen4_image",
                CreateOrganizationUsageResponseModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateOrganizationUsageResponseModel.Gen4Turbo => "gen4_turbo",
                CreateOrganizationUsageResponseModel.GptImage2 => "gpt_image_2",
                CreateOrganizationUsageResponseModel.GptImage25Flare => "gpt_image_2_5_flare",
                CreateOrganizationUsageResponseModel.GptImage25Sunburst => "gpt_image_2_5_sunburst",
                CreateOrganizationUsageResponseModel.GrokImagine15 => "grok_imagine_1_5",
                CreateOrganizationUsageResponseModel.GrokImagine15Lite => "grok_imagine_1_5_lite",
                CreateOrganizationUsageResponseModel.GrokImagineImage2 => "grok_imagine_image_2",
                CreateOrganizationUsageResponseModel.Gwm1AvatarAsyncAudioToVideo => "gwm1_avatar_async_audio_to_video",
                CreateOrganizationUsageResponseModel.Gwm1AvatarAsyncTextToVideo => "gwm1_avatar_async_text_to_video",
                CreateOrganizationUsageResponseModel.Gwm1Avatars => "gwm1_avatars",
                CreateOrganizationUsageResponseModel.H3Max => "h3_max",
                CreateOrganizationUsageResponseModel.Hailuo3 => "hailuo3",
                CreateOrganizationUsageResponseModel.Happyhorse10 => "happyhorse_1_0",
                CreateOrganizationUsageResponseModel.Ideogram40 => "ideogram_4_0",
                CreateOrganizationUsageResponseModel.Ideogram45 => "ideogram_4_5",
                CreateOrganizationUsageResponseModel.Kling25TurboPro => "kling2.5_turbo_pro",
                CreateOrganizationUsageResponseModel.Kling304k => "kling3.0_4k",
                CreateOrganizationUsageResponseModel.Kling30Pro => "kling3.0_pro",
                CreateOrganizationUsageResponseModel.Kling30Standard => "kling3.0_standard",
                CreateOrganizationUsageResponseModel.KlingO34k => "klingO3_4k",
                CreateOrganizationUsageResponseModel.KlingO3Pro => "klingO3_pro",
                CreateOrganizationUsageResponseModel.KlingO3Standard => "klingO3_standard",
                CreateOrganizationUsageResponseModel.Kling4 => "kling_4",
                CreateOrganizationUsageResponseModel.MagnificPrecisionUpscalerV2 => "magnific_precision_upscaler_v2",
                CreateOrganizationUsageResponseModel.MagnificVideoUpscalerCreative => "magnific_video_upscaler_creative",
                CreateOrganizationUsageResponseModel.MarketingStockImage => "marketing_stock_image",
                CreateOrganizationUsageResponseModel.MireloSfx20 => "mirelo_sfx_2_0",
                CreateOrganizationUsageResponseModel.MultiShotVideo => "multi_shot_video",
                CreateOrganizationUsageResponseModel.MuseImage => "muse_image",
                CreateOrganizationUsageResponseModel.NanoBanana21 => "nano_banana_2.1",
                CreateOrganizationUsageResponseModel.ProductAd => "product_ad",
                CreateOrganizationUsageResponseModel.ProductCampaignImage => "product_campaign_image",
                CreateOrganizationUsageResponseModel.ProductSwap => "product_swap",
                CreateOrganizationUsageResponseModel.ProductUgc => "product_ugc",
                CreateOrganizationUsageResponseModel.RecraftV41Flash => "recraft_v4_1_flash",
                CreateOrganizationUsageResponseModel.RecraftV41Vector => "recraft_v4_1_vector",
                CreateOrganizationUsageResponseModel.Ruby => "ruby",
                CreateOrganizationUsageResponseModel.SeedAudio => "seed_audio",
                CreateOrganizationUsageResponseModel.Seedance2 => "seedance2",
                CreateOrganizationUsageResponseModel.Seedance25 => "seedance2_5",
                CreateOrganizationUsageResponseModel.Seedance2Fast => "seedance2_fast",
                CreateOrganizationUsageResponseModel.Seedance2Mini => "seedance2_mini",
                CreateOrganizationUsageResponseModel.Seedream5Flash => "seedream5_flash",
                CreateOrganizationUsageResponseModel.Seedream5Lite => "seedream5_lite",
                CreateOrganizationUsageResponseModel.Seedream5Pro => "seedream5_pro",
                CreateOrganizationUsageResponseModel.Veo3 => "veo3",
                CreateOrganizationUsageResponseModel.Veo31 => "veo3.1",
                CreateOrganizationUsageResponseModel.Veo31Fast => "veo3.1_fast",
                CreateOrganizationUsageResponseModel.VoiceProcessing => "voice_processing",
                CreateOrganizationUsageResponseModel.Wan3 => "wan3",
                CreateOrganizationUsageResponseModel.Wan3Prime => "wan3_prime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationUsageResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "act_two" => CreateOrganizationUsageResponseModel.ActTwo,
                "ad_localization" => CreateOrganizationUsageResponseModel.AdLocalization,
                "aleph2" => CreateOrganizationUsageResponseModel.Aleph2,
                "bria_fibo_1_5" => CreateOrganizationUsageResponseModel.BriaFibo15,
                "bria_fibo_edit_1_5" => CreateOrganizationUsageResponseModel.BriaFiboEdit15,
                "eleven_multilingual_sts_v2" => CreateOrganizationUsageResponseModel.ElevenMultilingualStsV2,
                "eleven_multilingual_v2" => CreateOrganizationUsageResponseModel.ElevenMultilingualV2,
                "eleven_scribe_v2" => CreateOrganizationUsageResponseModel.ElevenScribeV2,
                "eleven_text_to_sound_v2" => CreateOrganizationUsageResponseModel.ElevenTextToSoundV2,
                "eleven_v3" => CreateOrganizationUsageResponseModel.ElevenV3,
                "eleven_v4" => CreateOrganizationUsageResponseModel.ElevenV4,
                "eleven_voice_dubbing" => CreateOrganizationUsageResponseModel.ElevenVoiceDubbing,
                "eleven_voice_isolation" => CreateOrganizationUsageResponseModel.ElevenVoiceIsolation,
                "enhance_frame_rate" => CreateOrganizationUsageResponseModel.EnhanceFrameRate,
                "gemini_2.5_flash" => CreateOrganizationUsageResponseModel.Gemini25Flash,
                "gemini_image3.1_flash" => CreateOrganizationUsageResponseModel.GeminiImage31Flash,
                "gemini_image3.1_flash_lite" => CreateOrganizationUsageResponseModel.GeminiImage31FlashLite,
                "gemini_image3_pro" => CreateOrganizationUsageResponseModel.GeminiImage3Pro,
                "gemini_omni_flash" => CreateOrganizationUsageResponseModel.GeminiOmniFlash,
                "gemini_omni_flash_1.1" => CreateOrganizationUsageResponseModel.GeminiOmniFlash11,
                "gen3a_turbo" => CreateOrganizationUsageResponseModel.Gen3aTurbo,
                "gen4.5" => CreateOrganizationUsageResponseModel.Gen45,
                "gen4_aleph" => CreateOrganizationUsageResponseModel.Gen4Aleph,
                "gen4_image" => CreateOrganizationUsageResponseModel.Gen4Image,
                "gen4_image_turbo" => CreateOrganizationUsageResponseModel.Gen4ImageTurbo,
                "gen4_turbo" => CreateOrganizationUsageResponseModel.Gen4Turbo,
                "gpt_image_2" => CreateOrganizationUsageResponseModel.GptImage2,
                "gpt_image_2_5_flare" => CreateOrganizationUsageResponseModel.GptImage25Flare,
                "gpt_image_2_5_sunburst" => CreateOrganizationUsageResponseModel.GptImage25Sunburst,
                "grok_imagine_1_5" => CreateOrganizationUsageResponseModel.GrokImagine15,
                "grok_imagine_1_5_lite" => CreateOrganizationUsageResponseModel.GrokImagine15Lite,
                "grok_imagine_image_2" => CreateOrganizationUsageResponseModel.GrokImagineImage2,
                "gwm1_avatar_async_audio_to_video" => CreateOrganizationUsageResponseModel.Gwm1AvatarAsyncAudioToVideo,
                "gwm1_avatar_async_text_to_video" => CreateOrganizationUsageResponseModel.Gwm1AvatarAsyncTextToVideo,
                "gwm1_avatars" => CreateOrganizationUsageResponseModel.Gwm1Avatars,
                "h3_max" => CreateOrganizationUsageResponseModel.H3Max,
                "hailuo3" => CreateOrganizationUsageResponseModel.Hailuo3,
                "happyhorse_1_0" => CreateOrganizationUsageResponseModel.Happyhorse10,
                "ideogram_4_0" => CreateOrganizationUsageResponseModel.Ideogram40,
                "ideogram_4_5" => CreateOrganizationUsageResponseModel.Ideogram45,
                "kling2.5_turbo_pro" => CreateOrganizationUsageResponseModel.Kling25TurboPro,
                "kling3.0_4k" => CreateOrganizationUsageResponseModel.Kling304k,
                "kling3.0_pro" => CreateOrganizationUsageResponseModel.Kling30Pro,
                "kling3.0_standard" => CreateOrganizationUsageResponseModel.Kling30Standard,
                "klingO3_4k" => CreateOrganizationUsageResponseModel.KlingO34k,
                "klingO3_pro" => CreateOrganizationUsageResponseModel.KlingO3Pro,
                "klingO3_standard" => CreateOrganizationUsageResponseModel.KlingO3Standard,
                "kling_4" => CreateOrganizationUsageResponseModel.Kling4,
                "magnific_precision_upscaler_v2" => CreateOrganizationUsageResponseModel.MagnificPrecisionUpscalerV2,
                "magnific_video_upscaler_creative" => CreateOrganizationUsageResponseModel.MagnificVideoUpscalerCreative,
                "marketing_stock_image" => CreateOrganizationUsageResponseModel.MarketingStockImage,
                "mirelo_sfx_2_0" => CreateOrganizationUsageResponseModel.MireloSfx20,
                "multi_shot_video" => CreateOrganizationUsageResponseModel.MultiShotVideo,
                "muse_image" => CreateOrganizationUsageResponseModel.MuseImage,
                "nano_banana_2.1" => CreateOrganizationUsageResponseModel.NanoBanana21,
                "product_ad" => CreateOrganizationUsageResponseModel.ProductAd,
                "product_campaign_image" => CreateOrganizationUsageResponseModel.ProductCampaignImage,
                "product_swap" => CreateOrganizationUsageResponseModel.ProductSwap,
                "product_ugc" => CreateOrganizationUsageResponseModel.ProductUgc,
                "recraft_v4_1_flash" => CreateOrganizationUsageResponseModel.RecraftV41Flash,
                "recraft_v4_1_vector" => CreateOrganizationUsageResponseModel.RecraftV41Vector,
                "ruby" => CreateOrganizationUsageResponseModel.Ruby,
                "seed_audio" => CreateOrganizationUsageResponseModel.SeedAudio,
                "seedance2" => CreateOrganizationUsageResponseModel.Seedance2,
                "seedance2_5" => CreateOrganizationUsageResponseModel.Seedance25,
                "seedance2_fast" => CreateOrganizationUsageResponseModel.Seedance2Fast,
                "seedance2_mini" => CreateOrganizationUsageResponseModel.Seedance2Mini,
                "seedream5_flash" => CreateOrganizationUsageResponseModel.Seedream5Flash,
                "seedream5_lite" => CreateOrganizationUsageResponseModel.Seedream5Lite,
                "seedream5_pro" => CreateOrganizationUsageResponseModel.Seedream5Pro,
                "veo3" => CreateOrganizationUsageResponseModel.Veo3,
                "veo3.1" => CreateOrganizationUsageResponseModel.Veo31,
                "veo3.1_fast" => CreateOrganizationUsageResponseModel.Veo31Fast,
                "voice_processing" => CreateOrganizationUsageResponseModel.VoiceProcessing,
                "wan3" => CreateOrganizationUsageResponseModel.Wan3,
                "wan3_prime" => CreateOrganizationUsageResponseModel.Wan3Prime,
                _ => null,
            };
        }
    }
}
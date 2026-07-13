
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.VoiceJsonConverter),

            typeof(global::Runway.JsonConverters.Voice2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarJsonConverter),

            typeof(global::Runway.JsonConverters.SpeechJsonConverter),

            typeof(global::Runway.JsonConverters.Voice3JsonConverter),

            typeof(global::Runway.JsonConverters.Avatar2JsonConverter),

            typeof(global::Runway.JsonConverters.ToolsItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItem2JsonConverter),

            typeof(global::Runway.JsonConverters.IntegrationJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CharacterJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.MediaJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.FromJsonConverter),

            typeof(global::Runway.JsonConverters.NodeOutputsJsonConverter),

            typeof(global::Runway.JsonConverters.DataItemJsonConverter),

            typeof(global::Runway.JsonConverters.Voice4JsonConverter),

            typeof(global::Runway.JsonConverters.Voice5JsonConverter),

            typeof(global::Runway.JsonConverters.Voice6JsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice7JsonConverter),

            typeof(global::Runway.JsonConverters.Voice8JsonConverter),

            typeof(global::Runway.JsonConverters.Voice9JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant1JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant12JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant13JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant14JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.Voice10JsonConverter),

            typeof(global::Runway.JsonConverters.Voice11JsonConverter),

            typeof(global::Runway.JsonConverters.Voice12JsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice13JsonConverter),

            typeof(global::Runway.JsonConverters.Voice14JsonConverter),

            typeof(global::Runway.JsonConverters.Voice15JsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseJsonConverter),

            typeof(global::Runway.JsonConverters.DataItem2JsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice), TypeInfoPropertyName = "Voice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId), TypeInfoPropertyName = "CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestImageProcessing), TypeInfoPropertyName = "CreateAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice2), TypeInfoPropertyName = "Voice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId), TypeInfoPropertyName = "PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestImageProcessing), TypeInfoPropertyName = "PatchAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar), TypeInfoPropertyName = "Avatar2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId), TypeInfoPropertyName = "CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Speech), TypeInfoPropertyName = "Speech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice3), TypeInfoPropertyName = "Voice32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType), TypeInfoPropertyName = "CreateAvatarVideosRequestSpeechDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar2), TypeInfoPropertyName = "Avatar22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId), TypeInfoPropertyName = "CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ToolsItem), TypeInfoPropertyName = "ToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem), TypeInfoPropertyName = "ParametersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ParametersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem2), TypeInfoPropertyName = "ParametersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Integration), TypeInfoPropertyName = "Integration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType), TypeInfoPropertyName = "CreateRealtimeSessionsRequestIntegrationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestLivekit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequest), TypeInfoPropertyName = "CreateImageToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGen45PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45ContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4Turbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGen4TurboPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio), TypeInfoPropertyName = "CreateImageToVideoRequestGen4TurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo31PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo31FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestHappyhorse10PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution), TypeInfoPropertyName = "CreateImageToVideoRequestHappyhorse10Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestSeedance2PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestSeedance2FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestSeedance2MiniPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio), TypeInfoPropertyName = "CreateImageToVideoRequestGeminiOmniFlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo3PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel), TypeInfoPropertyName = "CreateImageToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequest), TypeInfoPropertyName = "CreateTextToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestHappyhorse10Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio), TypeInfoPropertyName = "CreateTextToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio), TypeInfoPropertyName = "CreateTextToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2MiniReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio), TypeInfoPropertyName = "CreateTextToVideoRequestGeminiOmniFlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo3Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel), TypeInfoPropertyName = "CreateTextToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequest), TypeInfoPropertyName = "CreateVideoToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>), TypeInfoPropertyName = "AnyOfCreateVideoToVideoRequestVariant1KeyframeVariant1CreateVideoToVideoRequestVariant1KeyframeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio), TypeInfoPropertyName = "CreateVideoToVideoRequestVariant1TargetAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio), TypeInfoPropertyName = "CreateVideoToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio), TypeInfoPropertyName = "CreateVideoToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2FastReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio), TypeInfoPropertyName = "CreateVideoToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2MiniReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestGeminiOmniFlashReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlashReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVideoToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequest), TypeInfoPropertyName = "CreateTextToImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio), TypeInfoPropertyName = "CreateTextToImageRequestGen4ImageTurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio), TypeInfoPropertyName = "CreateTextToImageRequestGen4ImageRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio), TypeInfoPropertyName = "CreateTextToImageRequestGptImage2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Quality), TypeInfoPropertyName = "CreateTextToImageRequestGptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Background), TypeInfoPropertyName = "CreateTextToImageRequestGptImage2Background2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage2ReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2ReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio), TypeInfoPropertyName = "CreateTextToImageRequestGeminiImage3ProRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject), TypeInfoPropertyName = "CreateTextToImageRequestGeminiImage3ProReferenceImageSubject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio), TypeInfoPropertyName = "CreateTextToImageRequestGeminiImage31FlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject), TypeInfoPropertyName = "CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5Pro))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio), TypeInfoPropertyName = "CreateTextToImageRequestSeedream5ProRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat), TypeInfoPropertyName = "CreateTextToImageRequestSeedream5ProOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5Lite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio), TypeInfoPropertyName = "CreateTextToImageRequestSeedream5LiteRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat), TypeInfoPropertyName = "CreateTextToImageRequestSeedream5LiteOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5LiteReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25Flash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio), TypeInfoPropertyName = "CreateTextToImageRequestGemini25FlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel), TypeInfoPropertyName = "CreateTextToImageRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequest), TypeInfoPropertyName = "CreateImageUpscaleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor), TypeInfoPropertyName = "CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel), TypeInfoPropertyName = "CreateImageUpscaleRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequest), TypeInfoPropertyName = "CreateVideoUpscaleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution), TypeInfoPropertyName = "CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor), TypeInfoPropertyName = "CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVideoUpscaleRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequest), TypeInfoPropertyName = "CreateCharacterPerformanceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Character), TypeInfoPropertyName = "Character2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceCharacterReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel), TypeInfoPropertyName = "CreateCharacterPerformanceRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequest), TypeInfoPropertyName = "CreateSoundEffectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestSeedAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat), TypeInfoPropertyName = "CreateSoundEffectRequestSeedAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel), TypeInfoPropertyName = "CreateSoundEffectRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequest), TypeInfoPropertyName = "CreateSpeechToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Media), TypeInfoPropertyName = "Media2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType), TypeInfoPropertyName = "CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType), TypeInfoPropertyName = "CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel), TypeInfoPropertyName = "CreateSpeechToSpeechRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequest), TypeInfoPropertyName = "CreateTextToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType), TypeInfoPropertyName = "CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat), TypeInfoPropertyName = "CreateTextToSpeechRequestSeedAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel), TypeInfoPropertyName = "CreateTextToSpeechRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequest), TypeInfoPropertyName = "CreateVoiceDubbingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang), TypeInfoPropertyName = "CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVoiceDubbingRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequest), TypeInfoPropertyName = "CreateVoiceIsolationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVoiceIsolationRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsRequestType), TypeInfoPropertyName = "CreateUploadsRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion), TypeInfoPropertyName = "CreateRecipesAdLocalizationRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage), TypeInfoPropertyName = "CreateRecipesAdLocalizationRequestTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion), TypeInfoPropertyName = "CreateRecipesMarketingStockImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality), TypeInfoPropertyName = "CreateRecipesMarketingStockImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestVersion), TypeInfoPropertyName = "CreateRecipesProductAdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestStyleImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestRatio), TypeInfoPropertyName = "CreateRecipesProductAdRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion), TypeInfoPropertyName = "CreateRecipesProductCampaignImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestVersion), TypeInfoPropertyName = "CreateRecipesProductSwapRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestOriginalProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView), TypeInfoPropertyName = "CreateRecipesProductSwapRequestNewProductImageView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestResolution), TypeInfoPropertyName = "CreateRecipesProductSwapRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequest), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1FirstFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant1Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2FirstFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestVersion), TypeInfoPropertyName = "CreateRecipesProductUgcRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestCharacterImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestRatio), TypeInfoPropertyName = "CreateRecipesProductUgcRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.From), TypeInfoPropertyName = "From2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel), TypeInfoPropertyName = "CreateVoicesRequestFromVoiceFromTextModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType), TypeInfoPropertyName = "CreateVoicesRequestFromDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequestModel), TypeInfoPropertyName = "CreateVoicesPreviewRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.NodeOutputs), TypeInfoPropertyName = "NodeOutputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?, bool?>), TypeInfoPropertyName = "AnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType), TypeInfoPropertyName = "CreateWorkflowsRequestNodeOutputsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsSort), TypeInfoPropertyName = "GetDocumentsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsOrder), TypeInfoPropertyName = "GetDocumentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice4), TypeInfoPropertyName = "Voice42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice5), TypeInfoPropertyName = "Voice52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice6), TypeInfoPropertyName = "Voice62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus), TypeInfoPropertyName = "GetAvatarsResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponse), TypeInfoPropertyName = "CreateAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice7), TypeInfoPropertyName = "Voice72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice8), TypeInfoPropertyName = "Voice82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice9), TypeInfoPropertyName = "Voice92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus), TypeInfoPropertyName = "CreateAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus), TypeInfoPropertyName = "GetAvatarConversationsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AvatarVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType), TypeInfoPropertyName = "GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarUsageResponseByDayItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarUsageResponseByDayItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponse2), TypeInfoPropertyName = "GetAvatarConversationsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AvatarVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1CustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant1TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant1Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1Tool))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.VoiceJsonConverter),

            typeof(global::Runway.JsonConverters.Voice2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarJsonConverter),

            typeof(global::Runway.JsonConverters.SpeechJsonConverter),

            typeof(global::Runway.JsonConverters.Voice3JsonConverter),

            typeof(global::Runway.JsonConverters.Avatar2JsonConverter),

            typeof(global::Runway.JsonConverters.ToolsItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItem2JsonConverter),

            typeof(global::Runway.JsonConverters.IntegrationJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CharacterJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.MediaJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.FromJsonConverter),

            typeof(global::Runway.JsonConverters.NodeOutputsJsonConverter),

            typeof(global::Runway.JsonConverters.DataItemJsonConverter),

            typeof(global::Runway.JsonConverters.Voice4JsonConverter),

            typeof(global::Runway.JsonConverters.Voice5JsonConverter),

            typeof(global::Runway.JsonConverters.Voice6JsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice7JsonConverter),

            typeof(global::Runway.JsonConverters.Voice8JsonConverter),

            typeof(global::Runway.JsonConverters.Voice9JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant1JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant12JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant13JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant14JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.Voice10JsonConverter),

            typeof(global::Runway.JsonConverters.Voice11JsonConverter),

            typeof(global::Runway.JsonConverters.Voice12JsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice13JsonConverter),

            typeof(global::Runway.JsonConverters.Voice14JsonConverter),

            typeof(global::Runway.JsonConverters.Voice15JsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseJsonConverter),

            typeof(global::Runway.JsonConverters.DataItem2JsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant1ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AvatarVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1PresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant2TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant2Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant2ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AvatarVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1PresetAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1CustomAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant3TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetAvatarConversationsResponseVariant3Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType), TypeInfoPropertyName = "GetAvatarConversationsResponseVariant3ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetAvatarConversationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponse2), TypeInfoPropertyName = "GetAvatarsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice10), TypeInfoPropertyName = "Voice102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice11), TypeInfoPropertyName = "Voice112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice12), TypeInfoPropertyName = "Voice122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponse), TypeInfoPropertyName = "PatchAvatarsResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice13), TypeInfoPropertyName = "Voice132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice14), TypeInfoPropertyName = "Voice142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice15), TypeInfoPropertyName = "Voice152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus), TypeInfoPropertyName = "PatchAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseType), TypeInfoPropertyName = "CreateDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemType), TypeInfoPropertyName = "GetDocumentsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseDataItemUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseType), TypeInfoPropertyName = "GetDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseUsedByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponse), TypeInfoPropertyName = "GetRealtimeSessionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetRealtimeSessionsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse), TypeInfoPropertyName = "GetTasksResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminatorStatus), TypeInfoPropertyName = "GetTasksResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetOrganizationResponseTierModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseTierModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetOrganizationResponseUsageModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationResponseUsageModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel), TypeInfoPropertyName = "CreateOrganizationUsageResponseResultUsedCreditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseModel), TypeInfoPropertyName = "CreateOrganizationUsageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus), TypeInfoPropertyName = "GetVoicesResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse2), TypeInfoPropertyName = "GetVoicesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminatorStatus), TypeInfoPropertyName = "GetVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponse), TypeInfoPropertyName = "PatchVoicesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseVoiceFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus), TypeInfoPropertyName = "PatchVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseDataItemVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse), TypeInfoPropertyName = "GetWorkflowInvocationsResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailedNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailedNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetWorkflowInvocationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice?), TypeInfoPropertyName = "NullableVoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestImageProcessing?), TypeInfoPropertyName = "NullableCreateAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice2?), TypeInfoPropertyName = "NullableVoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestImageProcessing?), TypeInfoPropertyName = "NullablePatchAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar?), TypeInfoPropertyName = "NullableAvatar2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Speech?), TypeInfoPropertyName = "NullableSpeech2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice3?), TypeInfoPropertyName = "NullableVoice32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarVideosRequestSpeechDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Avatar2?), TypeInfoPropertyName = "NullableAvatar22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestAvatarDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem?), TypeInfoPropertyName = "NullableParametersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ParametersItem2?), TypeInfoPropertyName = "NullableParametersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Integration?), TypeInfoPropertyName = "NullableIntegration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?), TypeInfoPropertyName = "NullableCreateRealtimeSessionsRequestIntegrationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequest?), TypeInfoPropertyName = "NullableCreateImageToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestGen45PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestGen4TurboPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen4TurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestVeo31PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestVeo31FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestHappyhorse10PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestHappyhorse10Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestSeedance2PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestSeedance2FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestSeedance2MiniPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGeminiOmniFlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestVeo3PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequest?), TypeInfoPropertyName = "NullableCreateTextToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestHappyhorse10Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGeminiOmniFlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo3Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequest?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateVideoToVideoRequestVariant1KeyframeVariant1CreateVideoToVideoRequestVariant1KeyframeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1TargetAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequest?), TypeInfoPropertyName = "NullableCreateTextToImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGen4ImageTurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGen4ImageRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGptImage2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Quality?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGptImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGptImage2Background?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGptImage2Background2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGeminiImage3ProRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGeminiImage3ProReferenceImageSubject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGeminiImage31FlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGeminiImage31FlashReferenceImageSubject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5ProRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5ProOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5LiteRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5LiteOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGemini25FlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateTextToImageRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequest?), TypeInfoPropertyName = "NullableCreateImageUpscaleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor?), TypeInfoPropertyName = "NullableCreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateImageUpscaleRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequest?), TypeInfoPropertyName = "NullableCreateVideoUpscaleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution?), TypeInfoPropertyName = "NullableCreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor?), TypeInfoPropertyName = "NullableCreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVideoUpscaleRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequest?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Character?), TypeInfoPropertyName = "NullableCharacter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequestActTwoRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateCharacterPerformanceRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequest?), TypeInfoPropertyName = "NullableCreateSoundEffectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat?), TypeInfoPropertyName = "NullableCreateSoundEffectRequestSeedAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateSoundEffectRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequest?), TypeInfoPropertyName = "NullableCreateSpeechToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Media?), TypeInfoPropertyName = "NullableMedia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType?), TypeInfoPropertyName = "NullableCreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateSpeechToSpeechRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequest?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestSeedAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequest?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequestElevenVoiceDubbingTargetLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequest?), TypeInfoPropertyName = "NullableCreateVoiceIsolationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVoiceIsolationRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsRequestType?), TypeInfoPropertyName = "NullableCreateUploadsRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesAdLocalizationRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?), TypeInfoPropertyName = "NullableCreateRecipesAdLocalizationRequestTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesMarketingStockImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?), TypeInfoPropertyName = "NullableCreateRecipesMarketingStockImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductAdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestRatio?), TypeInfoPropertyName = "NullableCreateRecipesProductAdRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductCampaignImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestNewProductImageView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestResolution?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequest?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant1Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductUgcRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestRatio?), TypeInfoPropertyName = "NullableCreateRecipesProductUgcRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.From?), TypeInfoPropertyName = "NullableFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?), TypeInfoPropertyName = "NullableCreateVoicesRequestFromVoiceFromTextModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?), TypeInfoPropertyName = "NullableCreateVoicesRequestFromDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoicesPreviewRequestModel?), TypeInfoPropertyName = "NullableCreateVoicesPreviewRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.NodeOutputs?), TypeInfoPropertyName = "NullableNodeOutputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?), TypeInfoPropertyName = "NullableCreateWorkflowsRequestNodeOutputsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsSort?), TypeInfoPropertyName = "NullableGetDocumentsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsOrder?), TypeInfoPropertyName = "NullableGetDocumentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem?), TypeInfoPropertyName = "NullableDataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice4?), TypeInfoPropertyName = "NullableVoice42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice5?), TypeInfoPropertyName = "NullableVoice52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice6?), TypeInfoPropertyName = "NullableVoice62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponse?), TypeInfoPropertyName = "NullableCreateAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice7?), TypeInfoPropertyName = "NullableVoice72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice8?), TypeInfoPropertyName = "NullableVoice82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice9?), TypeInfoPropertyName = "NullableVoice92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableCreateAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponse2?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant1TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<object, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant1ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant2TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant2ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant3TranscriptItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseVariant3ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetAvatarConversationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponse2?), TypeInfoPropertyName = "NullableGetAvatarsResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice10?), TypeInfoPropertyName = "NullableVoice102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice11?), TypeInfoPropertyName = "NullableVoice112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice12?), TypeInfoPropertyName = "NullableVoice122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponse?), TypeInfoPropertyName = "NullablePatchAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice13?), TypeInfoPropertyName = "NullableVoice132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice14?), TypeInfoPropertyName = "NullableVoice142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice15?), TypeInfoPropertyName = "NullableVoice152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullablePatchAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateDocumentsResponseType?), TypeInfoPropertyName = "NullableCreateDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseDataItemType?), TypeInfoPropertyName = "NullableGetDocumentsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetDocumentsResponseType?), TypeInfoPropertyName = "NullableGetDocumentsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponse?), TypeInfoPropertyName = "NullableGetRealtimeSessionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetRealtimeSessionsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse?), TypeInfoPropertyName = "NullableGetTasksResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetTasksResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseResultUsedCreditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetVoicesResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponse2?), TypeInfoPropertyName = "NullableGetVoicesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponse?), TypeInfoPropertyName = "NullablePatchVoicesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullablePatchVoicesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse?), TypeInfoPropertyName = "NullableGetWorkflowInvocationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetWorkflowInvocationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ParametersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter),

            typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Runway.JsonConverters.VoiceJsonConverter),

            typeof(global::Runway.JsonConverters.Voice2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarJsonConverter),

            typeof(global::Runway.JsonConverters.SpeechJsonConverter),

            typeof(global::Runway.JsonConverters.Voice3JsonConverter),

            typeof(global::Runway.JsonConverters.Avatar2JsonConverter),

            typeof(global::Runway.JsonConverters.ToolsItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItemJsonConverter),

            typeof(global::Runway.JsonConverters.ParametersItem2JsonConverter),

            typeof(global::Runway.JsonConverters.IntegrationJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CharacterJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.MediaJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.FromJsonConverter),

            typeof(global::Runway.JsonConverters.NodeOutputsJsonConverter),

            typeof(global::Runway.JsonConverters.DataItemJsonConverter),

            typeof(global::Runway.JsonConverters.Voice4JsonConverter),

            typeof(global::Runway.JsonConverters.Voice5JsonConverter),

            typeof(global::Runway.JsonConverters.Voice6JsonConverter),

            typeof(global::Runway.JsonConverters.CreateAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice7JsonConverter),

            typeof(global::Runway.JsonConverters.Voice8JsonConverter),

            typeof(global::Runway.JsonConverters.Voice9JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant1JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarConversationsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant12JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant13JsonConverter),

            typeof(global::Runway.JsonConverters.AvatarVariant14JsonConverter),

            typeof(global::Runway.JsonConverters.GetAvatarsResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.Voice10JsonConverter),

            typeof(global::Runway.JsonConverters.Voice11JsonConverter),

            typeof(global::Runway.JsonConverters.Voice12JsonConverter),

            typeof(global::Runway.JsonConverters.PatchAvatarsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.Voice13JsonConverter),

            typeof(global::Runway.JsonConverters.Voice14JsonConverter),

            typeof(global::Runway.JsonConverters.Voice15JsonConverter),

            typeof(global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseJsonConverter),

            typeof(global::Runway.JsonConverters.DataItem2JsonConverter),

            typeof(global::Runway.JsonConverters.GetVoicesResponse2JsonConverter),

            typeof(global::Runway.JsonConverters.PatchVoicesResponseJsonConverter),

            typeof(global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2FastReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2MiniReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestGeminiOmniFlashReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGptImage2ReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestSeedream5LiteReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdRequestProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdRequestStyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductSwapRequestNewProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarUsageResponseByDayItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant1Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant2Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItemUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsSortJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsOrderJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.VoiceJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.SpeechJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice3JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Avatar2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ParametersItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.ParametersItem2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.IntegrationJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageToVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToImageRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateImageUpscaleRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoUpscaleRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateCharacterPerformanceRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CharacterJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSoundEffectRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateSpeechToSpeechRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.MediaJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateTextToSpeechRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceDubbingRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateVoiceIsolationRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.FromJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.NodeOutputsJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice4JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice5JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice6JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice7JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice8JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice9JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant1JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant12JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant13JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant14JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice10JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice11JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice12JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice13JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice14JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice15JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetTasksResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchVoicesResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}
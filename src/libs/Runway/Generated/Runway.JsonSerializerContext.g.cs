
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
            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter),

            typeof(global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter),

            typeof(global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.CreateImageToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestJsonConverter),

            typeof(global::Runway.JsonConverters.ReferencesItemJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToImageRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateCharacterPerformanceRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CharacterJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSoundEffectRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateSpeechToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.MediaJsonConverter),

            typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceDubbingRequestJsonConverter),

            typeof(global::Runway.JsonConverters.CreateVoiceIsolationRequestJsonConverter),

            typeof(global::Runway.JsonConverters.GetTasksResponseJsonConverter),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequest), TypeInfoPropertyName = "CreateImageToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4Turbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGen4TurboPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio), TypeInfoPropertyName = "CreateImageToVideoRequestGen4TurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo31PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGen3aTurboPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurboRatio), TypeInfoPropertyName = "CreateImageToVideoRequestGen3aTurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo31FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestVeo3PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo3Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequest), TypeInfoPropertyName = "CreateTextToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo3Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequest), TypeInfoPropertyName = "CreateVideoToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4Aleph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4AlephRatio), TypeInfoPropertyName = "CreateVideoToVideoRequestGen4AlephRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ReferencesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ReferencesItem), TypeInfoPropertyName = "ReferencesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4AlephReferenceImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4AlephReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4AlephContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25Flash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio), TypeInfoPropertyName = "CreateTextToImageRequestGemini25FlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequest), TypeInfoPropertyName = "CreateCharacterPerformanceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Character), TypeInfoPropertyName = "Character2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceCharacterReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequest), TypeInfoPropertyName = "CreateSoundEffectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequest), TypeInfoPropertyName = "CreateSpeechToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Media), TypeInfoPropertyName = "Media2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequest), TypeInfoPropertyName = "CreateTextToSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequest), TypeInfoPropertyName = "CreateVoiceDubbingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang), TypeInfoPropertyName = "CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequest), TypeInfoPropertyName = "CreateVoiceIsolationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsRequestType), TypeInfoPropertyName = "CreateUploadsRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse), TypeInfoPropertyName = "GetTasksResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ReferencesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
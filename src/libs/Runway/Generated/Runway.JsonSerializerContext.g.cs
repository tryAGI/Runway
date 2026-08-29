
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat), TypeInfoPropertyName = "CreateImageToVideoRequestGen45OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile), TypeInfoPropertyName = "CreateImageToVideoRequestGen45ProresProfile2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfStringIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution), TypeInfoPropertyName = "CreateImageToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestHailuo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3ReferenceAudioItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestSeedance25PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>), TypeInfoPropertyName = "AnyOfStringIListCreateImageToVideoRequestGrokImagine15PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution), TypeInfoPropertyName = "CreateImageToVideoRequestGrokImagine15Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestWan3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestWan3Ratio), TypeInfoPropertyName = "CreateImageToVideoRequestWan3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestWan3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestWan3ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestWan3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestWan3ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel), TypeInfoPropertyName = "CreateImageToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequest), TypeInfoPropertyName = "CreateTextToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat), TypeInfoPropertyName = "CreateTextToVideoRequestGen45OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile), TypeInfoPropertyName = "CreateTextToVideoRequestGen45ProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio), TypeInfoPropertyName = "CreateTextToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution), TypeInfoPropertyName = "CreateTextToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestHailuo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3ReferenceAudioItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution), TypeInfoPropertyName = "CreateTextToVideoRequestGrokImagine15Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestGrokImagine15Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestGrokImagine15ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3Ratio), TypeInfoPropertyName = "CreateTextToVideoRequestWan3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestWan3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3ReferenceAudioItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat), TypeInfoPropertyName = "CreateVideoToVideoRequestVariant1OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile), TypeInfoPropertyName = "CreateVideoToVideoRequestVariant1ProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution), TypeInfoPropertyName = "CreateVideoToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio), TypeInfoPropertyName = "CreateVideoToVideoRequestHailuo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3ReferenceAudioItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode), TypeInfoPropertyName = "CreateVideoToVideoRequestSeedance25Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio), TypeInfoPropertyName = "CreateVideoToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25ReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVideoToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequest), TypeInfoPropertyName = "CreateVideoToHdrRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestRuby))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat), TypeInfoPropertyName = "CreateVideoToHdrRequestRubyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile), TypeInfoPropertyName = "CreateVideoToHdrRequestRubyProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel), TypeInfoPropertyName = "CreateVideoToHdrRequestDiscriminatorModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestMuseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestMuseImageRatio), TypeInfoPropertyName = "CreateTextToImageRequestMuseImageRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestMuseImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestMuseImageReferenceImage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio), TypeInfoPropertyName = "CreateTextToImageRequestGrokImagineImage2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality), TypeInfoPropertyName = "CreateTextToImageRequestGrokImagineImage2Quality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGrokImagineImage2ReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2ReferenceImage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization), TypeInfoPropertyName = "CreateTextToSpeechRequestElevenV3ApplyTextNormalization2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole), TypeInfoPropertyName = "CreateGenerateVideoRequestInputReferenceImageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole), TypeInfoPropertyName = "CreateGenerateVideoRequestInputReferenceVideoRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>), TypeInfoPropertyName = "AnyOfCreateGenerateVideoRequestInputKeyframeVariant1CreateGenerateVideoRequestInputKeyframeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio), TypeInfoPropertyName = "CreateGenerateVideoRequestInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputResolution), TypeInfoPropertyName = "CreateGenerateVideoRequestInputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateImageRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio), TypeInfoPropertyName = "CreateGenerateImageRequestInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputResolution), TypeInfoPropertyName = "CreateGenerateImageRequestInputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold), TypeInfoPropertyName = "CreateGenerateImageRequestInputContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputType), TypeInfoPropertyName = "CreateGenerateAudioRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice4), TypeInfoPropertyName = "Voice42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId), TypeInfoPropertyName = "CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType), TypeInfoPropertyName = "CreateGenerateAudioRequestInputVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateAudioRequestInputReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputReferenceAudio))]
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
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsModelsMode), TypeInfoPropertyName = "CreateRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor), TypeInfoPropertyName = "CreateRoutersRequestSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsModelsMode), TypeInfoPropertyName = "PatchRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor), TypeInfoPropertyName = "PatchRoutersRequestSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsFallback))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice5), TypeInfoPropertyName = "Voice52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice6), TypeInfoPropertyName = "Voice62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice7), TypeInfoPropertyName = "Voice72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus), TypeInfoPropertyName = "GetAvatarsResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponse), TypeInfoPropertyName = "CreateAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice8), TypeInfoPropertyName = "Voice82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice9), TypeInfoPropertyName = "Voice92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice10), TypeInfoPropertyName = "Voice102")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice11), TypeInfoPropertyName = "Voice112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice12), TypeInfoPropertyName = "Voice122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice13), TypeInfoPropertyName = "Voice132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType), TypeInfoPropertyName = "GetAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponse), TypeInfoPropertyName = "PatchAvatarsResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice14), TypeInfoPropertyName = "Voice142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice15), TypeInfoPropertyName = "Voice152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId), TypeInfoPropertyName = "PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType), TypeInfoPropertyName = "PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice16), TypeInfoPropertyName = "Voice162")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant1EstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant2EstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant3Cost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant4EstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant5Cost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseVariant6Cost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponseDiscriminatorStatus), TypeInfoPropertyName = "GetTasksResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetTasksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoToHdrResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateImageUpscaleResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageUpscaleResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVideoUpscaleResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoUpscaleResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateCharacterPerformanceResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateCharacterPerformanceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateSoundEffectResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSoundEffectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateSpeechToSpeechResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateSpeechToSpeechResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateTextToSpeechResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVoiceDubbingResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateVoiceIsolationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRouting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor), TypeInfoPropertyName = "CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingCapacityFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateVideoResponseVariant1, global::Runway.CreateGenerateVideoResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateGenerateVideoResponseVariant1CreateGenerateVideoResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter), TypeInfoPropertyName = "CreateGenerateVideoResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem), TypeInfoPropertyName = "CreateGenerateVideoResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRouting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor), TypeInfoPropertyName = "CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingCapacityFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateImageResponseVariant1, global::Runway.CreateGenerateImageResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateGenerateImageResponseVariant1CreateGenerateImageResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateImageResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter), TypeInfoPropertyName = "CreateGenerateImageResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem), TypeInfoPropertyName = "CreateGenerateImageResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRouting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor), TypeInfoPropertyName = "CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType), TypeInfoPropertyName = "CreateGenerateAudioResponseRoutingResolvedInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice), TypeInfoPropertyName = "CreateGenerateAudioResponseRoutingResolvedInputVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingCapacityFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateAudioResponseVariant1, global::Runway.CreateGenerateAudioResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateGenerateAudioResponseVariant1CreateGenerateAudioResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateAudioResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter), TypeInfoPropertyName = "CreateGenerateAudioResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem), TypeInfoPropertyName = "CreateGenerateAudioResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetOrganizationWebappUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType), TypeInfoPropertyName = "GetOrganizationWebappUsageResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetOrganizationWebappAuditLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction), TypeInfoPropertyName = "GetOrganizationWebappAuditLogsResponseDataItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction), TypeInfoPropertyName = "GetOrganizationWebappAuditLogsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateUploadsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesAdLocalizationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMarketingStockImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductCampaignImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductUgcResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetRoutersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode), TypeInfoPropertyName = "GetRoutersResponseDataItemSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor), TypeInfoPropertyName = "GetRoutersResponseDataItemSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsModelsMode), TypeInfoPropertyName = "CreateRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor), TypeInfoPropertyName = "CreateRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettings))]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsModelsMode), TypeInfoPropertyName = "GetRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor), TypeInfoPropertyName = "GetRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsModelsMode), TypeInfoPropertyName = "PatchRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsMaxCreditsPerGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor), TypeInfoPropertyName = "PatchRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetRoutersRequestsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemReasonCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PipelineItem), TypeInfoPropertyName = "PipelineItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemEmptiedByItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen45OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen45ProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestGen4TurboPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen4TurboRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestVeo31PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestVeo31FastPromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableAnyOfStringIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestHailuo3Ratio2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestSeedance25PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance25PromptImagePromptImagePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>?), TypeInfoPropertyName = "NullableAnyOfStringIListCreateImageToVideoRequestGrokImagine15PromptImagePromptImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestGrokImagine15Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestWan3Ratio?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestWan3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateImageToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequest?), TypeInfoPropertyName = "NullableCreateTextToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGen45ProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestVeo31Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestVeo31FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestHailuo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestHappyhorse10Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGeminiOmniFlashRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGrokImagine15Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestGrokImagine15Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestWan3Ratio?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestWan3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateTextToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequest?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateVideoToVideoRequestVariant1KeyframeVariant1CreateVideoToVideoRequestVariant1KeyframeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1TargetAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestVariant1ProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestHailuo3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestHailuo3Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2FastRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance2MiniRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance25Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestSeedance25Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVideoToVideoRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequest?), TypeInfoPropertyName = "NullableCreateVideoToHdrRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat?), TypeInfoPropertyName = "NullableCreateVideoToHdrRequestRubyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile?), TypeInfoPropertyName = "NullableCreateVideoToHdrRequestRubyProresProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVideoToHdrRequestDiscriminatorModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestMuseImageRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestMuseImageRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5ProRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5ProOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5LiteRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat?), TypeInfoPropertyName = "NullableCreateTextToImageRequestSeedream5LiteOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGrokImagineImage2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality?), TypeInfoPropertyName = "NullableCreateTextToImageRequestGrokImagineImage2Quality2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestElevenV3VoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestElevenV3ApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateTextToSpeechRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequest?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequestElevenVoiceDubbingTargetLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVoiceDubbingRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequest?), TypeInfoPropertyName = "NullableCreateVoiceIsolationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel?), TypeInfoPropertyName = "NullableCreateVoiceIsolationRequestDiscriminatorModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole?), TypeInfoPropertyName = "NullableCreateGenerateVideoRequestInputReferenceImageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole?), TypeInfoPropertyName = "NullableCreateGenerateVideoRequestInputReferenceVideoRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateGenerateVideoRequestInputKeyframeVariant1CreateGenerateVideoRequestInputKeyframeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio?), TypeInfoPropertyName = "NullableCreateGenerateVideoRequestInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputResolution?), TypeInfoPropertyName = "NullableCreateGenerateVideoRequestInputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateGenerateVideoRequestInputContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio?), TypeInfoPropertyName = "NullableCreateGenerateImageRequestInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputResolution?), TypeInfoPropertyName = "NullableCreateGenerateImageRequestInputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold?), TypeInfoPropertyName = "NullableCreateGenerateImageRequestInputContentModerationPublicFigureThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputType?), TypeInfoPropertyName = "NullableCreateGenerateAudioRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice4?), TypeInfoPropertyName = "NullableVoice42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateGenerateAudioRequestInputVoiceDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsModelsMode?), TypeInfoPropertyName = "NullableCreateRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateRoutersRequestSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsModelsMode?), TypeInfoPropertyName = "NullablePatchRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor?), TypeInfoPropertyName = "NullablePatchRoutersRequestSettingsOptimizeFor2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice5?), TypeInfoPropertyName = "NullableVoice52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice6?), TypeInfoPropertyName = "NullableVoice62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice7?), TypeInfoPropertyName = "NullableVoice72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetAvatarsResponseDataItemDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponse?), TypeInfoPropertyName = "NullableCreateAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice8?), TypeInfoPropertyName = "NullableVoice82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice9?), TypeInfoPropertyName = "NullableVoice92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice10?), TypeInfoPropertyName = "NullableVoice102")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice11?), TypeInfoPropertyName = "NullableVoice112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice12?), TypeInfoPropertyName = "NullableVoice122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice13?), TypeInfoPropertyName = "NullableVoice132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableGetAvatarsResponseAvatarFailedVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetAvatarsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponse?), TypeInfoPropertyName = "NullablePatchAvatarsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice14?), TypeInfoPropertyName = "NullableVoice142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice15?), TypeInfoPropertyName = "NullableVoice152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsResponseAvatarReadyVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice16?), TypeInfoPropertyName = "NullableVoice162")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateVideoResponseVariant1, global::Runway.CreateGenerateVideoResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateGenerateVideoResponseVariant1CreateGenerateVideoResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter?), TypeInfoPropertyName = "NullableCreateGenerateVideoResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem?), TypeInfoPropertyName = "NullableCreateGenerateVideoResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateImageResponseVariant1, global::Runway.CreateGenerateImageResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateGenerateImageResponseVariant1CreateGenerateImageResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter?), TypeInfoPropertyName = "NullableCreateGenerateImageResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem?), TypeInfoPropertyName = "NullableCreateGenerateImageResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType?), TypeInfoPropertyName = "NullableCreateGenerateAudioResponseRoutingResolvedInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice?), TypeInfoPropertyName = "NullableCreateGenerateAudioResponseRoutingResolvedInputVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<global::Runway.CreateGenerateAudioResponseVariant1, global::Runway.CreateGenerateAudioResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateGenerateAudioResponseVariant1CreateGenerateAudioResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter?), TypeInfoPropertyName = "NullableCreateGenerateAudioResponseVariant1PipelineItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem?), TypeInfoPropertyName = "NullableCreateGenerateAudioResponseVariant1EmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?), TypeInfoPropertyName = "NullableGetOrganizationWebappUsageResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?), TypeInfoPropertyName = "NullableGetOrganizationWebappAuditLogsResponseDataItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?), TypeInfoPropertyName = "NullableGetOrganizationWebappAuditLogsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseResultUsedCreditModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateOrganizationUsageResponseModel?), TypeInfoPropertyName = "NullableCreateOrganizationUsageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode?), TypeInfoPropertyName = "NullableGetRoutersResponseDataItemSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor?), TypeInfoPropertyName = "NullableGetRoutersResponseDataItemSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullableCreateRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullableGetRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullableGetRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullablePatchRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullablePatchRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemReasonCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PipelineItem?), TypeInfoPropertyName = "NullablePipelineItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemVariant1Filter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemEmptiedByItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ParametersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestHailuo3ReferenceAudioItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestWan3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoRequestWan3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestHailuo3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestHailuo3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestHailuo3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2FastReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance2MiniReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance25Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance25ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestGrokImagine15Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestGrokImagine15ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestWan3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestWan3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoRequestWan3ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestHailuo3Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestHailuo3ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestHailuo3ReferenceAudioItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance25Reference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoRequestSeedance25ReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGptImage2ReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestMuseImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestSeedream5LiteReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGrokImagineImage2ReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageRequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioRequestInputReferenceAudio>))]
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
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetAvatarConversationsResponseVariant3Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseDataItemUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetDocumentsResponseUsedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoToHdrResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateImageUpscaleResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVideoUpscaleResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateCharacterPerformanceResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateSoundEffectResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateSpeechToSpeechResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateTextToSpeechResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVoiceDubbingResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateVoiceIsolationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetOrganizationWebappUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetOrganizationWebappAuditLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateOrganizationUsageResponseResultsByApiKeyItemUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesAdLocalizationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMarketingStockImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductCampaignImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductSwapResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMultiShotVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductUgcResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersRequestsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Runway.JsonConverters.CreateVideoToHdrRequestJsonConverter());
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
            options.Converters.Add(new global::Runway.JsonConverters.Voice4JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.FromJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.NodeOutputsJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice5JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice6JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice7JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.CreateAvatarsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice8JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice9JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice10JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant1JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarConversationsResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant12JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant13JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AvatarVariant14JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetAvatarsResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice11JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice12JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice13JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchAvatarsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice14JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice15JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice16JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetRealtimeSessionsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetTasksResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PipelineItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetVoicesResponse2JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PatchVoicesResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateGenerateVideoResponseVariant1, global::Runway.CreateGenerateVideoResponseVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateGenerateImageResponseVariant1, global::Runway.CreateGenerateImageResponseVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<global::Runway.CreateGenerateAudioResponseVariant1, global::Runway.CreateGenerateAudioResponseVariant2>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsRequestImageProcessing)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsRequestImageProcessing?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestImageProcessing)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsRequestImageProcessing?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestWan3Ratio)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestWan3Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestWan3Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestWan3Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile?)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Quality)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Quality?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Background)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Background?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestMuseImageRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestMuseImageRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio?)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor)

                    || typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor?)

                    || typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution?)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor?)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio?)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization?)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang)

                    || typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang?)

                    || typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel)

                    || typeToConvert == typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputResolution)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputResolution?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputResolution)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputResolution?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputType)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputType?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateUploadsRequestType)

                    || typeToConvert == typeof(global::Runway.CreateUploadsRequestType?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio?)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel)

                    || typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel?)

                    || typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsSort)

                    || typeToConvert == typeof(global::Runway.GetDocumentsSort?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsOrder)

                    || typeToConvert == typeof(global::Runway.GetDocumentsOrder?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.CreateDocumentsResponseType)

                    || typeToConvert == typeof(global::Runway.CreateDocumentsResponseType?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType?)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseType)

                    || typeToConvert == typeof(global::Runway.GetDocumentsResponseType?)

                    || typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetTasksResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetTasksResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem)

                    || typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem)

                    || typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter?)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem)

                    || typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem?)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction)

                    || typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel)

                    || typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel?)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestImageProcessing))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsRequestImageProcessing?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestImageProcessing))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsRequestImageProcessing?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestAvatarDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarVideosRequestSpeechDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestAvatarDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45OutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45OutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45OutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ProresProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen45ProresProfile?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen45ProresProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboRatio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestVeo31FastRatio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHailuo3Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestHappyhorse10Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastPromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2FastRatio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2FastRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance2MiniRatio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance2MiniRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlashRatio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGeminiOmniFlashRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25PromptImagePromptImagePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25PromptImagePromptImagePosition?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25PromptImagePromptImagePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestSeedance25Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestSeedance25RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGrokImagine15ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestGrokImagine15ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestWan3Ratio))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestWan3RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestWan3Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestWan3RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageToVideoRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45OutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45OutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45OutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ProresProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGen45ProresProfile?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGen45ProresProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestVeo31FastRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHailuo3Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestHappyhorse10Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2FastRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2FastRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance2MiniRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance2MiniRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlashRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGeminiOmniFlashRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance25RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestSeedance25Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestSeedance25RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestGrokImagine15Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestWan3Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestWan3RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestWan3Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestWan3RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToVideoRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1OutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1OutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1OutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ProresProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestVariant1ProresProfile?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1ProresProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Resolution?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestHailuo3Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2FastRatio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2FastRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance2MiniRatio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance2MiniRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Mode?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestSeedance25Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestSeedance25RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToVideoRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestRubyOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyOutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestRubyOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestRubyProresProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestRubyProresProfile?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestRubyProresProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoToHdrRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateVideoToHdrRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Quality))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Quality?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Background))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGptImage2Background?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImageSubject?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestMuseImageRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestMuseImageRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestMuseImageRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestMuseImageRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestSeedream5LiteOutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestSeedream5LiteOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2QualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2Quality?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2QualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestGemini25FlashRatio?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToImageRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor))
                {
                    return new global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor?))
                {
                    return new global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateImageUpscaleRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateImageUpscaleRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution?))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor?))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVideoUpscaleRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateVideoUpscaleRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoRatio?))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateCharacterPerformanceRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSoundEffectRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateSpeechToSpeechRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3ApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3ApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateTextToSpeechRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang))
                {
                    return new global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang?))
                {
                    return new global::Runway.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceDubbingRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel))
                {
                    return new global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoiceIsolationRequestDiscriminatorModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputReferenceImageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputReferenceImageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputReferenceVideoRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceVideoRole?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputReferenceVideoRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputAspectRatio?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputResolution))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputResolution?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoRequestInputContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputAspectRatio?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputResolution))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputResolution?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputContentModerationPublicFigureThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageRequestInputContentModerationPublicFigureThreshold?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageRequestInputContentModerationPublicFigureThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputType))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputType?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioRequestInputVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateUploadsRequestType))
                {
                    return new global::Runway.JsonConverters.CreateUploadsRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateUploadsRequestType?))
                {
                    return new global::Runway.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.CreateRoutersRequestSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.CreateRoutersRequestSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.CreateRoutersRequestSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.CreateRoutersRequestSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.PatchRoutersRequestSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.PatchRoutersRequestSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.PatchRoutersRequestSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.PatchRoutersRequestSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromVoiceFromTextModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromVoiceFromTextModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesRequestFromDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesRequestFromDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel))
                {
                    return new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateVoicesPreviewRequestModel?))
                {
                    return new global::Runway.JsonConverters.CreateVoicesPreviewRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsSort))
                {
                    return new global::Runway.JsonConverters.GetDocumentsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsSort?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsOrder))
                {
                    return new global::Runway.JsonConverters.GetDocumentsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsOrder?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDataItemDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateAvatarsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.CreateAvatarsResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemStatus?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1AvatarVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1TranscriptItemRole?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1TranscriptItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant1ToolType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant1ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2TranscriptItemRole?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2TranscriptItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant2ToolType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant2ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3AvatarVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3TranscriptItemRole?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3TranscriptItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseVariant3ToolType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseVariant3ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarConversationsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetAvatarConversationsResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseAvatarFailedVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetAvatarsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetAvatarsResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.PatchAvatarsResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateDocumentsResponseType))
                {
                    return new global::Runway.JsonConverters.CreateDocumentsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateDocumentsResponseType?))
                {
                    return new global::Runway.JsonConverters.CreateDocumentsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseDataItemType?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseType))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetDocumentsResponseType?))
                {
                    return new global::Runway.JsonConverters.GetDocumentsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetRealtimeSessionsResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetTasksResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetTasksResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseVariant1PipelineItemFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1PipelineItemFilter?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseVariant1PipelineItemFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseVariant1EmptiedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateVideoResponseVariant1EmptiedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseRoutingResolvedSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseVariant1PipelineItemFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1PipelineItemFilter?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseVariant1PipelineItemFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseVariant1EmptiedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateImageResponseVariant1EmptiedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputVoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputVoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1PipelineItemFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1PipelineItemFilter?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1PipelineItemFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1EmptiedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem?))
                {
                    return new global::Runway.JsonConverters.CreateGenerateAudioResponseVariant1EmptiedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappUsageResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappUsageResponseDataItemType?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappUsageResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseDataItemActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseDataItemActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetOrganizationWebappAuditLogsResponseAction?))
                {
                    return new global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseResultUsedCreditModel?))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateOrganizationUsageResponseModel?))
                {
                    return new global::Runway.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseDataItemSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseDataItemSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseDataItemSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseDataItemSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.CreateRoutersResponseSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.CreateRoutersResponseSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.CreateRoutersResponseSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.CreateRoutersResponseSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.GetRoutersResponseSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsModelsMode))
                {
                    return new global::Runway.JsonConverters.PatchRoutersResponseSettingsModelsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsModelsMode?))
                {
                    return new global::Runway.JsonConverters.PatchRoutersResponseSettingsModelsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor))
                {
                    return new global::Runway.JsonConverters.PatchRoutersResponseSettingsOptimizeForJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor?))
                {
                    return new global::Runway.JsonConverters.PatchRoutersResponseSettingsOptimizeForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemReasonCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode2?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemReasonCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemVariant1FilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemVariant1FilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemVariant3OutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemVariant3OutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemEmptiedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemEmptiedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDataItemDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDataItemDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetVoicesResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetVoicesResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.PatchVoicesResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.PatchVoicesResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[4];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
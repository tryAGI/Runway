
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode), TypeInfoPropertyName = "GetRoutersRequestsResponseDataItemReasonCode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsModelsMode?), TypeInfoPropertyName = "NullableCreateRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateRoutersRequestSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsModelsMode?), TypeInfoPropertyName = "NullablePatchRoutersRequestSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor?), TypeInfoPropertyName = "NullablePatchRoutersRequestSettingsOptimizeFor2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsModelsMode?), TypeInfoPropertyName = "NullableGetRoutersResponseDataItemSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseDataItemSettingsOptimizeFor?), TypeInfoPropertyName = "NullableGetRoutersResponseDataItemSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullableCreateRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullableCreateRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullableGetRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullableGetRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsModelsMode?), TypeInfoPropertyName = "NullablePatchRoutersResponseSettingsModelsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchRoutersResponseSettingsOptimizeFor?), TypeInfoPropertyName = "NullablePatchRoutersResponseSettingsOptimizeFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemStatus?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PipelineItem?), TypeInfoPropertyName = "NullablePipelineItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemVariant1Filter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?), TypeInfoPropertyName = "NullableGetRoutersRequestsResponseDataItemEmptiedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceVideo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageRequestInputReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioRequestInputReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateVideoResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateImageResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioResponseVariant1PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateGenerateAudioResponseVariant1EmptiedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersRequestsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.PipelineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem>))]
    internal sealed partial class ModelRouterSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelRouterSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelRouterSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelRouterSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Runway.JsonConverters.Voice4JsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.PipelineItemJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
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
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Runway.CreateGenerateVideoRequestInputReferenceImageRole)

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

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.CreateRoutersRequestSettingsOptimizeFor?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsModelsMode?)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor)

                    || typeToConvert == typeof(global::Runway.PatchRoutersRequestSettingsOptimizeFor?)

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

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem)

                    || typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemReasonCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetRoutersRequestsResponseDataItemReasonCode?))
                {
                    return new global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemReasonCodeNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new ModelRouterSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
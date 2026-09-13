
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetAvatarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem), TypeInfoPropertyName = "DataItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice?), TypeInfoPropertyName = "NullableVoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId?), TypeInfoPropertyName = "NullableCreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestVoiceDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateAvatarsRequestImageProcessing?), TypeInfoPropertyName = "NullableCreateAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Voice2?), TypeInfoPropertyName = "NullableVoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId?), TypeInfoPropertyName = "NullablePatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestVoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAvatarsRequestVoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.PatchAvatarsRequestImageProcessing?), TypeInfoPropertyName = "NullablePatchAvatarsRequestImageProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.DataItem?), TypeInfoPropertyName = "NullableDataItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
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
    internal sealed partial class AvatarsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AvatarsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AvatarsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AvatarsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Runway.JsonConverters.VoiceJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.Voice2JsonConverter());
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
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
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

                    || typeToConvert == typeof(global::Runway.PatchAvatarsResponseDiscriminatorStatus?);
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
                    0 => new AvatarsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
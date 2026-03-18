
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
            typeof(global::Runway.JsonConverters.RequestGen4TurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4TurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4TurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31PromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31PromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31RatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen3aTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastPromptImagePromptImagePositionJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo3RatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo3RatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31Ratio2JsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31Ratio2NullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastRatio2JsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo31FastRatio2NullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo3Ratio2JsonConverter),

            typeof(global::Runway.JsonConverters.RequestVeo3Ratio2NullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4AlephRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4AlephRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4AlephContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4AlephContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageTurboRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageTurboRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGemini25FlashRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestGemini25FlashRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestActTwoRatioJsonConverter),

            typeof(global::Runway.JsonConverters.RequestActTwoRatioNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestActTwoContentModerationPublicFigureThresholdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenVoiceDubbingTargetLangJsonConverter),

            typeof(global::Runway.JsonConverters.RequestElevenVoiceDubbingTargetLangNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestTypeJsonConverter),

            typeof(global::Runway.JsonConverters.RequestTypeNullableJsonConverter),

            typeof(global::Runway.JsonConverters.ResponseResultUsedCreditModelJsonConverter),

            typeof(global::Runway.JsonConverters.ResponseResultUsedCreditModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.ResponseModelJsonConverter),

            typeof(global::Runway.JsonConverters.ResponseModelNullableJsonConverter),

            typeof(global::Runway.JsonConverters.RequestJsonConverter),

            typeof(global::Runway.JsonConverters.Request2JsonConverter),

            typeof(global::Runway.JsonConverters.Request3JsonConverter),

            typeof(global::Runway.JsonConverters.ReferencesItemJsonConverter),

            typeof(global::Runway.JsonConverters.Request4JsonConverter),

            typeof(global::Runway.JsonConverters.Request5JsonConverter),

            typeof(global::Runway.JsonConverters.CharacterJsonConverter),

            typeof(global::Runway.JsonConverters.Request6JsonConverter),

            typeof(global::Runway.JsonConverters.Request7JsonConverter),

            typeof(global::Runway.JsonConverters.MediaJsonConverter),

            typeof(global::Runway.JsonConverters.Request8JsonConverter),

            typeof(global::Runway.JsonConverters.Request9JsonConverter),

            typeof(global::Runway.JsonConverters.Request10JsonConverter),

            typeof(global::Runway.JsonConverters.ResponseJsonConverter),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen4TurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo31PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo31FastPromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo3PromptImagePromptImage>>),

            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4Turbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen4TurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4TurboPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4TurboRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4TurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4TurboContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo31PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31PromptImagePromptImagePosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31Ratio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestGen3aTurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurboPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurboPromptImagePromptImagePosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurboRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen3aTurboContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31Fast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo31FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31FastPromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31FastPromptImagePromptImagePosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31FastRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.RequestVeo3PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo3PromptImagePromptImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo3Ratio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo312))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31Ratio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31Fast2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo31FastRatio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestVeo3Ratio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4Aleph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4AlephRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ReferencesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ReferencesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4AlephReferenceImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4AlephReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4AlephContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4AlephContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageTurbo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageTurboRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageTurboReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageTurboContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageTurboContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGen4ImageContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGemini25Flash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGemini25FlashRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.RequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestGemini25FlashReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Character))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoCharacterCharacterImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoCharacterCharacterVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoCharacterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoReferenceCharacterReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoContentModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestActTwoContentModerationPublicFigureThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenTextToSoundV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Media))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2MediaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualStsV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualV2VoiceRunwayPresetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenMultilingualV2VoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenVoiceDubbing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenVoiceDubbingTargetLang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestElevenVoiceIsolation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestDiscriminator10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Request12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.RequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.ResponseTierModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseTierModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.ResponseUsageModels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseUsageModels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseResultUsedCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseResultUsedCreditModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.ResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.ResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.Response25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.RequestGen4TurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestGen4TurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.RequestVeo31PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestVeo31PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.RequestGen3aTurboPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestGen3aTurboPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.RequestVeo31FastPromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestVeo31FastPromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string?, global::System.Collections.Generic.List<global::Runway.RequestVeo3PromptImagePromptImage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestVeo3PromptImagePromptImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ReferencesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestGen4ImageTurboReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestGen4ImageReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.RequestGemini25FlashReferenceImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ResponseResultUsedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.ResponseModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
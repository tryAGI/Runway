
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
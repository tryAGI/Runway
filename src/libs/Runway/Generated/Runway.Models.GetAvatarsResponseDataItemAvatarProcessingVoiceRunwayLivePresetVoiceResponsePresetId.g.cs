
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId
    {
        /// <summary>
        /// 
        /// </summary>
        Adam,
        /// <summary>
        /// 
        /// </summary>
        Adrian,
        /// <summary>
        /// 
        /// </summary>
        Aurora,
        /// <summary>
        /// 
        /// </summary>
        Blake,
        /// <summary>
        /// 
        /// </summary>
        Clara,
        /// <summary>
        /// 
        /// </summary>
        David,
        /// <summary>
        /// 
        /// </summary>
        Drew,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Felix,
        /// <summary>
        /// 
        /// </summary>
        Georgia,
        /// <summary>
        /// 
        /// </summary>
        Jasper,
        /// <summary>
        /// 
        /// </summary>
        Leo,
        /// <summary>
        /// 
        /// </summary>
        Luna,
        /// <summary>
        /// 
        /// </summary>
        Marcus,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Maya,
        /// <summary>
        /// 
        /// </summary>
        Mia,
        /// <summary>
        /// 
        /// </summary>
        Morgan,
        /// <summary>
        /// 
        /// </summary>
        Nathan,
        /// <summary>
        /// 
        /// </summary>
        Nina,
        /// <summary>
        /// 
        /// </summary>
        Petra,
        /// <summary>
        /// 
        /// </summary>
        Roman,
        /// <summary>
        /// 
        /// </summary>
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        Sam,
        /// <summary>
        /// 
        /// </summary>
        Skye,
        /// <summary>
        /// 
        /// </summary>
        Summer,
        /// <summary>
        /// 
        /// </summary>
        Victoria,
        /// <summary>
        /// 
        /// </summary>
        Vincent,
        /// <summary>
        /// 
        /// </summary>
        Violet,
        /// <summary>
        /// 
        /// </summary>
        Zach,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
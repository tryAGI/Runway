
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => GetAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => GetAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
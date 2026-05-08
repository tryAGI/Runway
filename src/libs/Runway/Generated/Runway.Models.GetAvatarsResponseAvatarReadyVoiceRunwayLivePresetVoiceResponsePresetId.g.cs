
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
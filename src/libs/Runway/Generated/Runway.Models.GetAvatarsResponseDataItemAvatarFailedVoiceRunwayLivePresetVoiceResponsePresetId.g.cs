
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => GetAvatarsResponseDataItemAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
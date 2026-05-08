
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
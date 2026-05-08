
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => CreateAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
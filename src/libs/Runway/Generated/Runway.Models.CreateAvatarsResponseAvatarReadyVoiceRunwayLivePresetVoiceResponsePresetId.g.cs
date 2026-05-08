
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => CreateAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
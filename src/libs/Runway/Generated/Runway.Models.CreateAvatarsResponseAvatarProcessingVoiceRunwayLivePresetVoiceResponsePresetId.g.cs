
#nullable enable

namespace Runway
{
    /// <summary>
    /// The preset voice identifier.
    /// </summary>
    public enum CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId
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
    public static class CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam => "adam",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian => "adrian",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora => "aurora",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake => "blake",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara => "clara",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David => "david",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew => "drew",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma => "emma",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix => "felix",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia => "georgia",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper => "jasper",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo => "leo",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna => "luna",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus => "marcus",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max => "max",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya => "maya",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia => "mia",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan => "morgan",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan => "nathan",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina => "nina",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra => "petra",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman => "roman",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby => "ruby",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam => "sam",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye => "skye",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer => "summer",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria => "victoria",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent => "vincent",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet => "violet",
                CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adam,
                "adrian" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Adrian,
                "aurora" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Aurora,
                "blake" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Blake,
                "clara" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Clara,
                "david" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.David,
                "drew" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Drew,
                "emma" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Emma,
                "felix" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Felix,
                "georgia" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Georgia,
                "jasper" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Jasper,
                "leo" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Leo,
                "luna" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Luna,
                "marcus" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Marcus,
                "max" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Max,
                "maya" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Maya,
                "mia" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Mia,
                "morgan" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Morgan,
                "nathan" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nathan,
                "nina" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Nina,
                "petra" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Petra,
                "roman" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Roman,
                "ruby" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Ruby,
                "sam" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Sam,
                "skye" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Skye,
                "summer" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Summer,
                "victoria" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Victoria,
                "vincent" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Vincent,
                "violet" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Violet,
                "zach" => CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponsePresetId.Zach,
                _ => null,
            };
        }
    }
}
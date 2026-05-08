
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId
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
    public static class CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId value)
        {
            return value switch
            {
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Adam => "adam",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Adrian => "adrian",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Aurora => "aurora",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Blake => "blake",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Clara => "clara",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.David => "david",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Drew => "drew",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Emma => "emma",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Felix => "felix",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Georgia => "georgia",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Jasper => "jasper",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Leo => "leo",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Luna => "luna",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Marcus => "marcus",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Max => "max",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Maya => "maya",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Mia => "mia",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Morgan => "morgan",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Nathan => "nathan",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Nina => "nina",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Petra => "petra",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Roman => "roman",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Ruby => "ruby",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Sam => "sam",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Skye => "skye",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Summer => "summer",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Victoria => "victoria",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Vincent => "vincent",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Violet => "violet",
                CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Zach => "zach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId? ToEnum(string value)
        {
            return value switch
            {
                "adam" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Adam,
                "adrian" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Adrian,
                "aurora" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Aurora,
                "blake" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Blake,
                "clara" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Clara,
                "david" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.David,
                "drew" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Drew,
                "emma" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Emma,
                "felix" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Felix,
                "georgia" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Georgia,
                "jasper" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Jasper,
                "leo" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Leo,
                "luna" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Luna,
                "marcus" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Marcus,
                "max" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Max,
                "maya" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Maya,
                "mia" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Mia,
                "morgan" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Morgan,
                "nathan" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Nathan,
                "nina" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Nina,
                "petra" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Petra,
                "roman" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Roman,
                "ruby" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Ruby,
                "sam" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Sam,
                "skye" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Skye,
                "summer" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Summer,
                "victoria" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Victoria,
                "vincent" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Vincent,
                "violet" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Violet,
                "zach" => CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Zach,
                _ => null,
            };
        }
    }
}
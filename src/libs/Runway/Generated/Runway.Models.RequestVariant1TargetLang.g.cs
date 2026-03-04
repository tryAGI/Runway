
#nullable enable

namespace Runway
{
    /// <summary>
    /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
    /// </summary>
    public enum RequestVariant1TargetLang
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Zh,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Fil,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Ta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant1TargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant1TargetLang value)
        {
            return value switch
            {
                RequestVariant1TargetLang.En => "en",
                RequestVariant1TargetLang.Hi => "hi",
                RequestVariant1TargetLang.Pt => "pt",
                RequestVariant1TargetLang.Zh => "zh",
                RequestVariant1TargetLang.Es => "es",
                RequestVariant1TargetLang.Fr => "fr",
                RequestVariant1TargetLang.De => "de",
                RequestVariant1TargetLang.Ja => "ja",
                RequestVariant1TargetLang.Ar => "ar",
                RequestVariant1TargetLang.Ru => "ru",
                RequestVariant1TargetLang.Ko => "ko",
                RequestVariant1TargetLang.Id => "id",
                RequestVariant1TargetLang.It => "it",
                RequestVariant1TargetLang.Nl => "nl",
                RequestVariant1TargetLang.Tr => "tr",
                RequestVariant1TargetLang.Pl => "pl",
                RequestVariant1TargetLang.Sv => "sv",
                RequestVariant1TargetLang.Fil => "fil",
                RequestVariant1TargetLang.Ms => "ms",
                RequestVariant1TargetLang.Ro => "ro",
                RequestVariant1TargetLang.Uk => "uk",
                RequestVariant1TargetLang.El => "el",
                RequestVariant1TargetLang.Cs => "cs",
                RequestVariant1TargetLang.Da => "da",
                RequestVariant1TargetLang.Fi => "fi",
                RequestVariant1TargetLang.Bg => "bg",
                RequestVariant1TargetLang.Hr => "hr",
                RequestVariant1TargetLang.Sk => "sk",
                RequestVariant1TargetLang.Ta => "ta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant1TargetLang? ToEnum(string value)
        {
            return value switch
            {
                "en" => RequestVariant1TargetLang.En,
                "hi" => RequestVariant1TargetLang.Hi,
                "pt" => RequestVariant1TargetLang.Pt,
                "zh" => RequestVariant1TargetLang.Zh,
                "es" => RequestVariant1TargetLang.Es,
                "fr" => RequestVariant1TargetLang.Fr,
                "de" => RequestVariant1TargetLang.De,
                "ja" => RequestVariant1TargetLang.Ja,
                "ar" => RequestVariant1TargetLang.Ar,
                "ru" => RequestVariant1TargetLang.Ru,
                "ko" => RequestVariant1TargetLang.Ko,
                "id" => RequestVariant1TargetLang.Id,
                "it" => RequestVariant1TargetLang.It,
                "nl" => RequestVariant1TargetLang.Nl,
                "tr" => RequestVariant1TargetLang.Tr,
                "pl" => RequestVariant1TargetLang.Pl,
                "sv" => RequestVariant1TargetLang.Sv,
                "fil" => RequestVariant1TargetLang.Fil,
                "ms" => RequestVariant1TargetLang.Ms,
                "ro" => RequestVariant1TargetLang.Ro,
                "uk" => RequestVariant1TargetLang.Uk,
                "el" => RequestVariant1TargetLang.El,
                "cs" => RequestVariant1TargetLang.Cs,
                "da" => RequestVariant1TargetLang.Da,
                "fi" => RequestVariant1TargetLang.Fi,
                "bg" => RequestVariant1TargetLang.Bg,
                "hr" => RequestVariant1TargetLang.Hr,
                "sk" => RequestVariant1TargetLang.Sk,
                "ta" => RequestVariant1TargetLang.Ta,
                _ => null,
            };
        }
    }
}
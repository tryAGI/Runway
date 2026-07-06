
#nullable enable

namespace Runway
{
    /// <summary>
    /// Target language for the localized ad. Use ISO-style codes (e.g. "ja" for Japanese, "es" for Spanish).
    /// </summary>
    public enum CreateRecipesAdLocalizationRequestTargetLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
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
        Hi,
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
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
        /// <summary>
        /// 
        /// </summary>
        ZhHant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesAdLocalizationRequestTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesAdLocalizationRequestTargetLanguage value)
        {
            return value switch
            {
                CreateRecipesAdLocalizationRequestTargetLanguage.Ar => "ar",
                CreateRecipesAdLocalizationRequestTargetLanguage.De => "de",
                CreateRecipesAdLocalizationRequestTargetLanguage.El => "el",
                CreateRecipesAdLocalizationRequestTargetLanguage.En => "en",
                CreateRecipesAdLocalizationRequestTargetLanguage.Es => "es",
                CreateRecipesAdLocalizationRequestTargetLanguage.Fr => "fr",
                CreateRecipesAdLocalizationRequestTargetLanguage.Hi => "hi",
                CreateRecipesAdLocalizationRequestTargetLanguage.Id => "id",
                CreateRecipesAdLocalizationRequestTargetLanguage.It => "it",
                CreateRecipesAdLocalizationRequestTargetLanguage.Ja => "ja",
                CreateRecipesAdLocalizationRequestTargetLanguage.Ko => "ko",
                CreateRecipesAdLocalizationRequestTargetLanguage.Nl => "nl",
                CreateRecipesAdLocalizationRequestTargetLanguage.Pl => "pl",
                CreateRecipesAdLocalizationRequestTargetLanguage.Pt => "pt",
                CreateRecipesAdLocalizationRequestTargetLanguage.Ru => "ru",
                CreateRecipesAdLocalizationRequestTargetLanguage.Sv => "sv",
                CreateRecipesAdLocalizationRequestTargetLanguage.Th => "th",
                CreateRecipesAdLocalizationRequestTargetLanguage.Tr => "tr",
                CreateRecipesAdLocalizationRequestTargetLanguage.Uk => "uk",
                CreateRecipesAdLocalizationRequestTargetLanguage.Vi => "vi",
                CreateRecipesAdLocalizationRequestTargetLanguage.Zh => "zh",
                CreateRecipesAdLocalizationRequestTargetLanguage.ZhHant => "zh-Hant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesAdLocalizationRequestTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => CreateRecipesAdLocalizationRequestTargetLanguage.Ar,
                "de" => CreateRecipesAdLocalizationRequestTargetLanguage.De,
                "el" => CreateRecipesAdLocalizationRequestTargetLanguage.El,
                "en" => CreateRecipesAdLocalizationRequestTargetLanguage.En,
                "es" => CreateRecipesAdLocalizationRequestTargetLanguage.Es,
                "fr" => CreateRecipesAdLocalizationRequestTargetLanguage.Fr,
                "hi" => CreateRecipesAdLocalizationRequestTargetLanguage.Hi,
                "id" => CreateRecipesAdLocalizationRequestTargetLanguage.Id,
                "it" => CreateRecipesAdLocalizationRequestTargetLanguage.It,
                "ja" => CreateRecipesAdLocalizationRequestTargetLanguage.Ja,
                "ko" => CreateRecipesAdLocalizationRequestTargetLanguage.Ko,
                "nl" => CreateRecipesAdLocalizationRequestTargetLanguage.Nl,
                "pl" => CreateRecipesAdLocalizationRequestTargetLanguage.Pl,
                "pt" => CreateRecipesAdLocalizationRequestTargetLanguage.Pt,
                "ru" => CreateRecipesAdLocalizationRequestTargetLanguage.Ru,
                "sv" => CreateRecipesAdLocalizationRequestTargetLanguage.Sv,
                "th" => CreateRecipesAdLocalizationRequestTargetLanguage.Th,
                "tr" => CreateRecipesAdLocalizationRequestTargetLanguage.Tr,
                "uk" => CreateRecipesAdLocalizationRequestTargetLanguage.Uk,
                "vi" => CreateRecipesAdLocalizationRequestTargetLanguage.Vi,
                "zh" => CreateRecipesAdLocalizationRequestTargetLanguage.Zh,
                "zh-Hant" => CreateRecipesAdLocalizationRequestTargetLanguage.ZhHant,
                _ => null,
            };
        }
    }
}
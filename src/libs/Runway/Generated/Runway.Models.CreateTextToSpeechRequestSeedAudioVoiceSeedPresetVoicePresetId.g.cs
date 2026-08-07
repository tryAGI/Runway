
#nullable enable

namespace Runway
{
    /// <summary>
    /// A Seed Audio preset voice id.
    /// </summary>
    public enum CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId
    {
        /// <summary>
        /// 
        /// </summary>
        CedricEnZh,
        /// <summary>
        /// 
        /// </summary>
        CelesteZh,
        /// <summary>
        /// 
        /// </summary>
        CorinneMixedEnZh,
        /// <summary>
        /// 
        /// </summary>
        EstherMixedEnZh,
        /// <summary>
        /// 
        /// </summary>
        FelixZh,
        /// <summary>
        /// 
        /// </summary>
        JeanEnZh,
        /// <summary>
        /// 
        /// </summary>
        KianEnZh,
        /// <summary>
        /// 
        /// </summary>
        LylaMixedEnZh,
        /// <summary>
        /// 
        /// </summary>
        MabelEnZh,
        /// <summary>
        /// 
        /// </summary>
        MagnusEnZh,
        /// <summary>
        /// 
        /// </summary>
        MindyEnEsIdPtZh,
        /// <summary>
        /// 
        /// </summary>
        MonkeyKingZh,
        /// <summary>
        /// 
        /// </summary>
        NadiaEnZh,
        /// <summary>
        /// 
        /// </summary>
        OpalEnZh,
        /// <summary>
        /// 
        /// </summary>
        PearlEnZh,
        /// <summary>
        /// 
        /// </summary>
        QuentinEnZh,
        /// <summary>
        /// 
        /// </summary>
        SandyEsMixedEnZh,
        /// <summary>
        /// 
        /// </summary>
        SophieEnZh,
        /// <summary>
        /// 
        /// </summary>
        TracyEsZh,
        /// <summary>
        /// 
        /// </summary>
        ViviMixedEnZhJaEsId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId value)
        {
            return value switch
            {
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CedricEnZh => "cedric_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CelesteZh => "celeste_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CorinneMixedEnZh => "corinne_mixed_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.EstherMixedEnZh => "esther_mixed_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.FelixZh => "felix_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.JeanEnZh => "jean_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.KianEnZh => "kian_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.LylaMixedEnZh => "lyla_mixed_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MabelEnZh => "mabel_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MagnusEnZh => "magnus_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MindyEnEsIdPtZh => "mindy_en_es_id_pt_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MonkeyKingZh => "monkey_king_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.NadiaEnZh => "nadia_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.OpalEnZh => "opal_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.PearlEnZh => "pearl_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.QuentinEnZh => "quentin_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.SandyEsMixedEnZh => "sandy_es_mixed_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.SophieEnZh => "sophie_en_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.TracyEsZh => "tracy_es_zh",
                CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.ViviMixedEnZhJaEsId => "vivi_mixed_en_zh_ja_es_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId? ToEnum(string value)
        {
            return value switch
            {
                "cedric_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CedricEnZh,
                "celeste_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CelesteZh,
                "corinne_mixed_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.CorinneMixedEnZh,
                "esther_mixed_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.EstherMixedEnZh,
                "felix_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.FelixZh,
                "jean_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.JeanEnZh,
                "kian_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.KianEnZh,
                "lyla_mixed_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.LylaMixedEnZh,
                "mabel_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MabelEnZh,
                "magnus_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MagnusEnZh,
                "mindy_en_es_id_pt_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MindyEnEsIdPtZh,
                "monkey_king_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.MonkeyKingZh,
                "nadia_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.NadiaEnZh,
                "opal_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.OpalEnZh,
                "pearl_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.PearlEnZh,
                "quentin_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.QuentinEnZh,
                "sandy_es_mixed_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.SandyEsMixedEnZh,
                "sophie_en_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.SophieEnZh,
                "tracy_es_zh" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.TracyEsZh,
                "vivi_mixed_en_zh_ja_es_id" => CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId.ViviMixedEnZhJaEsId,
                _ => null,
            };
        }
    }
}
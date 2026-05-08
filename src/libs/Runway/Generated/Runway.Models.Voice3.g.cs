#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional voice override for TTS. If not provided, the avatar's configured voice is used.
    /// </summary>
    public readonly partial struct Voice3 : global::System.IEquatable<Voice3>
    {
        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? Preset { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? Preset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preset))]
#endif
        public bool IsPreset => Preset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? value)
        {
            value = Preset;
            return IsPreset;
        }

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? Custom { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice3(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice value) => new Voice3((global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice?(Voice3 @this) => @this.Preset;

        /// <summary>
        /// 
        /// </summary>
        public Voice3(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? value)
        {
            Preset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice3(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice value) => new Voice3((global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice?(Voice3 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice3(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Voice3(
            global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice? preset,
            global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice? custom
            )
        {
            Preset = preset;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            Preset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Preset?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreset && !IsCustom || !IsPreset && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice, TResult>? preset = null,
            global::System.Func<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreset && preset != null)
            {
                return preset(Preset!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice>? preset = null,

            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreset)
            {
                preset?.Invoke(Preset!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice>? preset = null,
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreset)
            {
                preset?.Invoke(Preset!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Preset,
                typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice),
                Custom,
                typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Voice3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice?>.Default.Equals(Preset, other.Preset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice3 obj1, Voice3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice3 obj1, Voice3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice3 o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The speech source for avatar video generation. Either an audio file or text script.
    /// </summary>
    public readonly partial struct Speech : global::System.IEquatable<Speech>
    {
        /// <summary>
        /// Provide an audio file for the avatar to speak.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestSpeechAudioInput? Audio { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestSpeechAudioInput? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateAvatarVideosRequestSpeechAudioInput? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        /// Provide text for the avatar to speak via TTS.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestSpeechTextInput? Text { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestSpeechTextInput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateAvatarVideosRequestSpeechTextInput? value)
        {
            value = Text;
            return IsText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Speech(global::Runway.CreateAvatarVideosRequestSpeechAudioInput value) => new Speech((global::Runway.CreateAvatarVideosRequestSpeechAudioInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestSpeechAudioInput?(Speech @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public Speech(global::Runway.CreateAvatarVideosRequestSpeechAudioInput? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Speech(global::Runway.CreateAvatarVideosRequestSpeechTextInput value) => new Speech((global::Runway.CreateAvatarVideosRequestSpeechTextInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestSpeechTextInput?(Speech @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Speech(global::Runway.CreateAvatarVideosRequestSpeechTextInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Speech(
            global::Runway.CreateAvatarVideosRequestSpeechAudioInput? audio,
            global::Runway.CreateAvatarVideosRequestSpeechTextInput? text
            )
        {
            Audio = audio;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Audio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsText || !IsAudio && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateAvatarVideosRequestSpeechAudioInput, TResult>? audio = null,
            global::System.Func<global::Runway.CreateAvatarVideosRequestSpeechTextInput, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechAudioInput>? audio = null,

            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInput>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechAudioInput>? audio = null,
            global::System.Action<global::Runway.CreateAvatarVideosRequestSpeechTextInput>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Audio,
                typeof(global::Runway.CreateAvatarVideosRequestSpeechAudioInput),
                Text,
                typeof(global::Runway.CreateAvatarVideosRequestSpeechTextInput),
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
        public bool Equals(Speech other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestSpeechAudioInput?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestSpeechTextInput?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Speech obj1, Speech obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Speech>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Speech obj1, Speech obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Speech o && Equals(o);
        }
    }
}

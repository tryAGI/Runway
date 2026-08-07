#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice to use for text-to-speech generation. If omitted, a default voice is used.
    /// </summary>
    public readonly partial struct Voice4 : global::System.IEquatable<Voice4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice for Seed Audio text-to-speech.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? SeedPreset { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? SeedPreset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SeedPreset))]
#endif
        public bool IsSeedPreset => SeedPreset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSeedPreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? value)
        {
            value = SeedPreset;
            return IsSeedPreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice PickSeedPreset() => IsSeedPreset
            ? SeedPreset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SeedPreset' but the value was {ToString()}.");

        /// <summary>
        /// Clone from a single reference audio clip, then speak promptText in that voice.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? ReferenceAudio { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? ReferenceAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReferenceAudio))]
#endif
        public bool IsReferenceAudio => ReferenceAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReferenceAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? value)
        {
            value = ReferenceAudio;
            return IsReferenceAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice PickReferenceAudio() => IsReferenceAudio
            ? ReferenceAudio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReferenceAudio' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice4(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice value) => new Voice4((global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice?(Voice4 @this) => @this.SeedPreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice4(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? value)
        {
            SeedPreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice4 FromSeedPreset(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? value) => new Voice4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice4(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice value) => new Voice4((global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice?(Voice4 @this) => @this.ReferenceAudio;

        /// <summary>
        /// 
        /// </summary>
        public Voice4(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? value)
        {
            ReferenceAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice4 FromReferenceAudio(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? value) => new Voice4(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice4(
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType? type,
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice? seedPreset,
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? referenceAudio
            )
        {
            Type = type;

            SeedPreset = seedPreset;
            ReferenceAudio = referenceAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReferenceAudio as object ??
            SeedPreset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SeedPreset?.ToString() ??
            ReferenceAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSeedPreset && !IsReferenceAudio || !IsSeedPreset && IsReferenceAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice, TResult>? seedPreset = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice, TResult>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSeedPreset && seedPreset != null)
            {
                return seedPreset(SeedPreset!);
            }
            else if (IsReferenceAudio && referenceAudio != null)
            {
                return referenceAudio(ReferenceAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice>? seedPreset = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSeedPreset)
            {
                seedPreset?.Invoke(SeedPreset!);
            }
            else if (IsReferenceAudio)
            {
                referenceAudio?.Invoke(ReferenceAudio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice>? seedPreset = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSeedPreset)
            {
                seedPreset?.Invoke(SeedPreset!);
            }
            else if (IsReferenceAudio)
            {
                referenceAudio?.Invoke(ReferenceAudio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SeedPreset,
                typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice),
                ReferenceAudio,
                typeof(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice),
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
        public bool Equals(Voice4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice?>.Default.Equals(SeedPreset, other.SeedPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice?>.Default.Equals(ReferenceAudio, other.ReferenceAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice4 obj1, Voice4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice4 obj1, Voice4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice4 o && Equals(o);
        }
    }
}

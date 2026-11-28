#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice to speak with. When omitted, models that support a default voice remain eligible.
    /// </summary>
    public readonly partial struct Voice3 : global::System.IEquatable<Voice3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? Preset { get; init; }
#else
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? Preset { get; }
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
            out global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? value)
        {
            value = Preset;
            return IsPreset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice PickPreset() => Preset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Preset' but the value was {ToString()}.");

        /// <summary>
        /// Clone a voice from a reference audio clip, then speak promptText in that voice. Routes only to models that support voice cloning.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? ReferenceAudio { get; init; }
#else
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? ReferenceAudio { get; }
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
            out global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? value)
        {
            value = ReferenceAudio;
            return IsReferenceAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice PickReferenceAudio() => ReferenceAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReferenceAudio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice3(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice value) => new Voice3((global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice?(Voice3 @this) => @this.Preset;

        /// <summary>
        ///
        /// </summary>
        public Voice3(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? value)
        {
            Preset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice3 FromPreset(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? value) => new Voice3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice3(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice value) => new Voice3((global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice?(Voice3 @this) => @this.ReferenceAudio;

        /// <summary>
        ///
        /// </summary>
        public Voice3(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? value)
        {
            ReferenceAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice3 FromReferenceAudio(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? value) => new Voice3(value);

        /// <summary>
        ///
        /// </summary>
        public Voice3(
            global::Runway.CreateGenerateAudioRequestInputVoiceDiscriminatorType? type,
            global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice? preset,
            global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice? referenceAudio
            )
        {
            Type = type;

            Preset = preset;
            ReferenceAudio = referenceAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReferenceAudio as object ??
            Preset as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Preset?.ToString() ??
            ReferenceAudio?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPreset && !IsReferenceAudio || !IsPreset && IsReferenceAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice, TResult>? preset = null,
            global::System.Func<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice, TResult>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0 && preset != null)
            {
                return preset(__value0);
            }
            else if (ReferenceAudio is { } __value1 && referenceAudio != null)
            {
                return referenceAudio(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice>? preset = null,

            global::System.Action<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0)
            {
                preset?.Invoke(__value0);
            }
            else if (ReferenceAudio is { } __value1)
            {
                referenceAudio?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice>? preset = null,
            global::System.Action<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice>? referenceAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Preset is { } __value0)
            {
                preset?.Invoke(__value0);
            }
            else if (ReferenceAudio is { } __value1)
            {
                referenceAudio?.Invoke(__value1);
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
                typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice),
                ReferenceAudio,
                typeof(global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoice?>.Default.Equals(Preset, other.Preset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateAudioRequestInputVoiceAudioReferenceVoice?>.Default.Equals(ReferenceAudio, other.ReferenceAudio)
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

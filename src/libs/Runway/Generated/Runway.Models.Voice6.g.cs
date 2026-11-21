#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice to use for the generated speech.
    /// </summary>
    public readonly partial struct Voice6 : global::System.IEquatable<Voice6>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A voice preset from the RunwayML API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? RunwayPreset { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? RunwayPreset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunwayPreset))]
#endif
        public bool IsRunwayPreset => RunwayPreset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunwayPreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? value)
        {
            value = RunwayPreset;
            return IsRunwayPreset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice PickRunwayPreset() => RunwayPreset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayPreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice belonging to the authenticated organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? Custom { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? Custom { get; }
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
            out global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice6(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice value) => new Voice6((global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice?(Voice6 @this) => @this.RunwayPreset;

        /// <summary>
        ///
        /// </summary>
        public Voice6(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? value)
        {
            RunwayPreset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice6 FromRunwayPreset(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? value) => new Voice6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice6(global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice value) => new Voice6((global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice?(Voice6 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public Voice6(global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice6 FromCustom(global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? value) => new Voice6(value);

        /// <summary>
        ///
        /// </summary>
        public Voice6(
            global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType? type,
            global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice? runwayPreset,
            global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice? custom
            )
        {
            Type = type;

            RunwayPreset = runwayPreset;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            RunwayPreset as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunwayPreset?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunwayPreset && !IsCustom || !IsRunwayPreset && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice, TResult>? runwayPreset = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0 && runwayPreset != null)
            {
                return runwayPreset(__value0);
            }
            else if (Custom is { } __value1 && custom != null)
            {
                return custom(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice>? runwayPreset = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0)
            {
                runwayPreset?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice>? runwayPreset = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0)
            {
                runwayPreset?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunwayPreset,
                typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice),
                Custom,
                typeof(global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice),
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
        public bool Equals(Voice6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice?>.Default.Equals(RunwayPreset, other.RunwayPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestElevenV3VoiceCustomTextToSpeechVoice?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Voice6 obj1, Voice6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Voice6 obj1, Voice6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice6 o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configuration for the avatar.<br/>
    /// Example: {"type":"runway-live-preset","presetId":"adrian"}
    /// </summary>
    public readonly partial struct Voice : global::System.IEquatable<Voice>
    {
        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice? RunwayLivePreset { get; init; }
#else
        public global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice? RunwayLivePreset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunwayLivePreset))]
#endif
        public bool IsRunwayLivePreset => RunwayLivePreset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunwayLivePreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsRequestVoiceCustomVoice? Custom { get; init; }
#else
        public global::Runway.CreateAvatarsRequestVoiceCustomVoice? Custom { get; }
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
            out global::Runway.CreateAvatarsRequestVoiceCustomVoice? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice value) => new Voice((global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice?(Voice @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice(global::Runway.CreateAvatarsRequestVoiceCustomVoice value) => new Voice((global::Runway.CreateAvatarsRequestVoiceCustomVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsRequestVoiceCustomVoice?(Voice @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice(global::Runway.CreateAvatarsRequestVoiceCustomVoice? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Voice(
            global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice? runwayLivePreset,
            global::Runway.CreateAvatarsRequestVoiceCustomVoice? custom
            )
        {
            RunwayLivePreset = runwayLivePreset;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            RunwayLivePreset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RunwayLivePreset?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunwayLivePreset && !IsCustom || !IsRunwayLivePreset && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.CreateAvatarsRequestVoiceCustomVoice, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayLivePreset && runwayLivePreset != null)
            {
                return runwayLivePreset(RunwayLivePreset!);
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
            global::System.Action<global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice>? runwayLivePreset = null,

            global::System.Action<global::Runway.CreateAvatarsRequestVoiceCustomVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayLivePreset)
            {
                runwayLivePreset?.Invoke(RunwayLivePreset!);
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
            global::System.Action<global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice>? runwayLivePreset = null,
            global::System.Action<global::Runway.CreateAvatarsRequestVoiceCustomVoice>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayLivePreset)
            {
                runwayLivePreset?.Invoke(RunwayLivePreset!);
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
                RunwayLivePreset,
                typeof(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice),
                Custom,
                typeof(global::Runway.CreateAvatarsRequestVoiceCustomVoice),
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
        public bool Equals(Voice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoice?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsRequestVoiceCustomVoice?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice obj1, Voice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice obj1, Voice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice o && Equals(o);
        }
    }
}

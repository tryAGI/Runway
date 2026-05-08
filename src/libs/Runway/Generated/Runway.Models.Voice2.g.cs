#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configuration for the avatar.<br/>
    /// Example: {"type":"runway-live-preset","presetId":"adrian"}
    /// </summary>
    public readonly partial struct Voice2 : global::System.IEquatable<Voice2>
    {
        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? RunwayLivePreset { get; init; }
#else
        public global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? RunwayLivePreset { get; }
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
            out global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsRequestVoiceCustomVoice? Custom { get; init; }
#else
        public global::Runway.PatchAvatarsRequestVoiceCustomVoice? Custom { get; }
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
            out global::Runway.PatchAvatarsRequestVoiceCustomVoice? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice2(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice value) => new Voice2((global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice?(Voice2 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice2(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice2(global::Runway.PatchAvatarsRequestVoiceCustomVoice value) => new Voice2((global::Runway.PatchAvatarsRequestVoiceCustomVoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsRequestVoiceCustomVoice?(Voice2 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice2(global::Runway.PatchAvatarsRequestVoiceCustomVoice? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Voice2(
            global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice? runwayLivePreset,
            global::Runway.PatchAvatarsRequestVoiceCustomVoice? custom
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
            global::System.Func<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.PatchAvatarsRequestVoiceCustomVoice, TResult>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice>? runwayLivePreset = null,

            global::System.Action<global::Runway.PatchAvatarsRequestVoiceCustomVoice>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice>? runwayLivePreset = null,
            global::System.Action<global::Runway.PatchAvatarsRequestVoiceCustomVoice>? custom = null,
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
                typeof(global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice),
                Custom,
                typeof(global::Runway.PatchAvatarsRequestVoiceCustomVoice),
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
        public bool Equals(Voice2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsRequestVoiceRunwayLivePresetVoice?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsRequestVoiceCustomVoice?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice2 obj1, Voice2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice2 obj1, Voice2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice2 o && Equals(o);
        }
    }
}

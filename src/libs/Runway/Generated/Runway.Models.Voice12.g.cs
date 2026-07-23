#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice12 : global::System.IEquatable<Voice12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse PickRunwayLivePreset() => IsRunwayLivePreset
            ? RunwayLivePreset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayLivePreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice12(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse value) => new Voice12((global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?(Voice12 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice12(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice12 FromRunwayLivePreset(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value) => new Voice12(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice12(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse value) => new Voice12((global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?(Voice12 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice12(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice12 FromCustom(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value) => new Voice12(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice12(
            global::Runway.GetAvatarsResponseAvatarReadyVoiceDiscriminatorType? type,
            global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? custom
            )
        {
            Type = type;

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
            global::System.Func<global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse),
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
        public bool Equals(Voice12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice12 obj1, Voice12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice12 obj1, Voice12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice12 o && Equals(o);
        }
    }
}

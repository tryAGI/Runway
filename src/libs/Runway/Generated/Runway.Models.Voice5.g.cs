#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice5 : global::System.IEquatable<Voice5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse PickRunwayLivePreset() => IsRunwayLivePreset
            ? RunwayLivePreset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayLivePreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice5(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse value) => new Voice5((global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse?(Voice5 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice5(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice5 FromRunwayLivePreset(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? value) => new Voice5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice5(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse value) => new Voice5((global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse?(Voice5 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice5(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice5 FromCustom(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? value) => new Voice5(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice5(
            global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType? type,
            global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse),
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
        public bool Equals(Voice5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarReadyVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice5 obj1, Voice5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice5 obj1, Voice5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice5 o && Equals(o);
        }
    }
}

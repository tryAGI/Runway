#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice15 : global::System.IEquatable<Voice15>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse PickRunwayLivePreset() => IsRunwayLivePreset
            ? RunwayLivePreset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayLivePreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice15(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse value) => new Voice15((global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?(Voice15 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice15(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice15 FromRunwayLivePreset(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? value) => new Voice15(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice15(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse value) => new Voice15((global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?(Voice15 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice15(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice15 FromCustom(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? value) => new Voice15(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice15(
            global::Runway.PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType? type,
            global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse),
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
        public bool Equals(Voice15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarReadyVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice15 obj1, Voice15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice15 obj1, Voice15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice15 o && Equals(o);
        }
    }
}

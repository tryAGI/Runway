#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice8 : global::System.IEquatable<Voice8>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse PickRunwayLivePreset() => IsRunwayLivePreset
            ? RunwayLivePreset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayLivePreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice8(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse value) => new Voice8((global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?(Voice8 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice8(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice8 FromRunwayLivePreset(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value) => new Voice8(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice8(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse value) => new Voice8((global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?(Voice8 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice8(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice8 FromCustom(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value) => new Voice8(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice8(
            global::Runway.CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType? type,
            global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse),
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
        public bool Equals(Voice8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice8 obj1, Voice8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice8 obj1, Voice8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice8 o && Equals(o);
        }
    }
}

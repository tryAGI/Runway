#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice4 : global::System.IEquatable<Voice4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice4(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse value) => new Voice4((global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse?(Voice4 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice4(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice4(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse value) => new Voice4((global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse?(Voice4 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice4(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Voice4(
            global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType? type,
            global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarProcessingVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
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

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice13 : global::System.IEquatable<Voice13>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice13(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse value) => new Voice13((global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?(Voice13 @this) => @this.RunwayLivePreset;

        /// <summary>
        /// 
        /// </summary>
        public Voice13(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice13 FromRunwayLivePreset(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? value) => new Voice13(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Voice13(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse value) => new Voice13((global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?(Voice13 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Voice13(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Voice13 FromCustom(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? value) => new Voice13(value);

        /// <summary>
        /// 
        /// </summary>
        public Voice13(
            global::Runway.PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType? type,
            global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse, TResult>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse>? custom = null,
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
                typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse),
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
        public bool Equals(Voice13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarProcessingVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Voice13 obj1, Voice13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Voice13 obj1, Voice13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice13 o && Equals(o);
        }
    }
}

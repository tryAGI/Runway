#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice configured for this avatar.
    /// </summary>
    public readonly partial struct Voice19 : global::System.IEquatable<Voice19>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset voice from the Runway API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? RunwayLivePreset { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? value)
        {
            value = RunwayLivePreset;
            return IsRunwayLivePreset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse PickRunwayLivePreset() => RunwayLivePreset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayLivePreset' but the value was {ToString()}.");

        /// <summary>
        /// A custom voice created via the Voices API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? Custom { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? Custom { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice19(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse value) => new Voice19((global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse?(Voice19 @this) => @this.RunwayLivePreset;

        /// <summary>
        ///
        /// </summary>
        public Voice19(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? value)
        {
            RunwayLivePreset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice19 FromRunwayLivePreset(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? value) => new Voice19(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Voice19(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse value) => new Voice19((global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse?(Voice19 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public Voice19(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Voice19 FromCustom(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? value) => new Voice19(value);

        /// <summary>
        ///
        /// </summary>
        public Voice19(
            global::Runway.PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType? type,
            global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse? runwayLivePreset,
            global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse? custom
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
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse, TResult>? runwayLivePreset = null,
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayLivePreset is { } __value0 && runwayLivePreset != null)
            {
                return runwayLivePreset(__value0);
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,

            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayLivePreset is { } __value0)
            {
                runwayLivePreset?.Invoke(__value0);
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse>? runwayLivePreset = null,
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayLivePreset is { } __value0)
            {
                runwayLivePreset?.Invoke(__value0);
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
                RunwayLivePreset,
                typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse),
                Custom,
                typeof(global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse),
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
        public bool Equals(Voice19 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarFailedVoiceRunwayLivePresetVoiceResponse?>.Default.Equals(RunwayLivePreset, other.RunwayLivePreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarFailedVoiceCustomVoiceResponse?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Voice19 obj1, Voice19 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Voice19>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Voice19 obj1, Voice19 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Voice19 o && Equals(o);
        }
    }
}

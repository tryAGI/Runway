#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The avatar used in this conversation.
    /// </summary>
    public readonly partial struct AvatarVariant1 : global::System.IEquatable<AvatarVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// A preset avatar.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? RunwayPreset { get; init; }
#else
        public global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? RunwayPreset { get; }
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
            out global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? value)
        {
            value = RunwayPreset;
            return IsRunwayPreset;
        }

        /// <summary>
        /// A custom avatar created by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? Custom { get; init; }
#else
        public global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? Custom { get; }
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
            out global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AvatarVariant1(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary value) => new AvatarVariant1((global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary?(AvatarVariant1 @this) => @this.RunwayPreset;

        /// <summary>
        /// 
        /// </summary>
        public AvatarVariant1(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? value)
        {
            RunwayPreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AvatarVariant1 FromRunwayPreset(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? value) => new AvatarVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AvatarVariant1(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary value) => new AvatarVariant1((global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary?(AvatarVariant1 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public AvatarVariant1(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AvatarVariant1 FromCustom(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? value) => new AvatarVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public AvatarVariant1(
            global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType? type,
            global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary? runwayPreset,
            global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary? custom
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
            global::System.Func<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary, TResult>? runwayPreset = null,
            global::System.Func<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset && runwayPreset != null)
            {
                return runwayPreset(RunwayPreset!);
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
            global::System.Action<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary>? runwayPreset = null,

            global::System.Action<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset)
            {
                runwayPreset?.Invoke(RunwayPreset!);
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
            global::System.Action<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary>? runwayPreset = null,
            global::System.Action<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset)
            {
                runwayPreset?.Invoke(RunwayPreset!);
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
                RunwayPreset,
                typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary),
                Custom,
                typeof(global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary),
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
        public bool Equals(AvatarVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary?>.Default.Equals(RunwayPreset, other.RunwayPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AvatarVariant1 obj1, AvatarVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AvatarVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AvatarVariant1 obj1, AvatarVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AvatarVariant1 o && Equals(o);
        }
    }
}

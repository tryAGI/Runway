#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateRecipesMultiShotVideoRequest : global::System.IEquatable<CreateRecipesMultiShotVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode? Mode { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant1? Auto { get; init; }
#else
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant1? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRecipesMultiShotVideoRequestVariant1? value)
        {
            value = Auto;
            return IsAuto;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant1 PickAuto() => IsAuto
            ? Auto!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Auto' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant2? Custom { get; init; }
#else
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant2? Custom { get; }
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
            out global::Runway.CreateRecipesMultiShotVideoRequestVariant2? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRecipesMultiShotVideoRequestVariant2 PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateRecipesMultiShotVideoRequest(global::Runway.CreateRecipesMultiShotVideoRequestVariant1 value) => new CreateRecipesMultiShotVideoRequest((global::Runway.CreateRecipesMultiShotVideoRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRecipesMultiShotVideoRequestVariant1?(CreateRecipesMultiShotVideoRequest @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public CreateRecipesMultiShotVideoRequest(global::Runway.CreateRecipesMultiShotVideoRequestVariant1? value)
        {
            Auto = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateRecipesMultiShotVideoRequest FromAuto(global::Runway.CreateRecipesMultiShotVideoRequestVariant1? value) => new CreateRecipesMultiShotVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateRecipesMultiShotVideoRequest(global::Runway.CreateRecipesMultiShotVideoRequestVariant2 value) => new CreateRecipesMultiShotVideoRequest((global::Runway.CreateRecipesMultiShotVideoRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRecipesMultiShotVideoRequestVariant2?(CreateRecipesMultiShotVideoRequest @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public CreateRecipesMultiShotVideoRequest(global::Runway.CreateRecipesMultiShotVideoRequestVariant2? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateRecipesMultiShotVideoRequest FromCustom(global::Runway.CreateRecipesMultiShotVideoRequestVariant2? value) => new CreateRecipesMultiShotVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateRecipesMultiShotVideoRequest(
            global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode? mode,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant1? auto,
            global::Runway.CreateRecipesMultiShotVideoRequestVariant2? custom
            )
        {
            Mode = mode;

            Auto = auto;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Auto?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsCustom || !IsAuto && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRecipesMultiShotVideoRequestVariant1, TResult>? auto = null,
            global::System.Func<global::Runway.CreateRecipesMultiShotVideoRequestVariant2, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
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
            global::System.Action<global::Runway.CreateRecipesMultiShotVideoRequestVariant1>? auto = null,

            global::System.Action<global::Runway.CreateRecipesMultiShotVideoRequestVariant2>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
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
            global::System.Action<global::Runway.CreateRecipesMultiShotVideoRequestVariant1>? auto = null,
            global::System.Action<global::Runway.CreateRecipesMultiShotVideoRequestVariant2>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
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
                Auto,
                typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1),
                Custom,
                typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2),
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
        public bool Equals(CreateRecipesMultiShotVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRecipesMultiShotVideoRequestVariant1?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRecipesMultiShotVideoRequestVariant2?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateRecipesMultiShotVideoRequest obj1, CreateRecipesMultiShotVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateRecipesMultiShotVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateRecipesMultiShotVideoRequest obj1, CreateRecipesMultiShotVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateRecipesMultiShotVideoRequest o && Equals(o);
        }
    }
}

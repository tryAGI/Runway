#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateVideoUpscaleRequest : global::System.IEquatable<CreateVideoUpscaleRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoUpscaleRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? MagnificVideoUpscalerCreative { get; init; }
#else
        public global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? MagnificVideoUpscalerCreative { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MagnificVideoUpscalerCreative))]
#endif
        public bool IsMagnificVideoUpscalerCreative => MagnificVideoUpscalerCreative != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMagnificVideoUpscalerCreative(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? value)
        {
            value = MagnificVideoUpscalerCreative;
            return IsMagnificVideoUpscalerCreative;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative PickMagnificVideoUpscalerCreative() => IsMagnificVideoUpscalerCreative
            ? MagnificVideoUpscalerCreative!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MagnificVideoUpscalerCreative' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? EnhanceFrameRate { get; init; }
#else
        public global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? EnhanceFrameRate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnhanceFrameRate))]
#endif
        public bool IsEnhanceFrameRate => EnhanceFrameRate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnhanceFrameRate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? value)
        {
            value = EnhanceFrameRate;
            return IsEnhanceFrameRate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate PickEnhanceFrameRate() => IsEnhanceFrameRate
            ? EnhanceFrameRate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnhanceFrameRate' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoUpscaleRequest(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative value) => new CreateVideoUpscaleRequest((global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative?(CreateVideoUpscaleRequest @this) => @this.MagnificVideoUpscalerCreative;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoUpscaleRequest(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? value)
        {
            MagnificVideoUpscalerCreative = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoUpscaleRequest FromMagnificVideoUpscalerCreative(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? value) => new CreateVideoUpscaleRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoUpscaleRequest(global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate value) => new CreateVideoUpscaleRequest((global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate?(CreateVideoUpscaleRequest @this) => @this.EnhanceFrameRate;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoUpscaleRequest(global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? value)
        {
            EnhanceFrameRate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoUpscaleRequest FromEnhanceFrameRate(global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? value) => new CreateVideoUpscaleRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVideoUpscaleRequest(
            global::Runway.CreateVideoUpscaleRequestDiscriminatorModel? model,
            global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? magnificVideoUpscalerCreative,
            global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate? enhanceFrameRate
            )
        {
            Model = model;

            MagnificVideoUpscalerCreative = magnificVideoUpscalerCreative;
            EnhanceFrameRate = enhanceFrameRate;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnhanceFrameRate as object ??
            MagnificVideoUpscalerCreative as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MagnificVideoUpscalerCreative?.ToString() ??
            EnhanceFrameRate?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMagnificVideoUpscalerCreative && !IsEnhanceFrameRate || !IsMagnificVideoUpscalerCreative && IsEnhanceFrameRate;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative, TResult>? magnificVideoUpscalerCreative = null,
            global::System.Func<global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate, TResult>? enhanceFrameRate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificVideoUpscalerCreative && magnificVideoUpscalerCreative != null)
            {
                return magnificVideoUpscalerCreative(MagnificVideoUpscalerCreative!);
            }
            else if (IsEnhanceFrameRate && enhanceFrameRate != null)
            {
                return enhanceFrameRate(EnhanceFrameRate!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative>? magnificVideoUpscalerCreative = null,

            global::System.Action<global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate>? enhanceFrameRate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificVideoUpscalerCreative)
            {
                magnificVideoUpscalerCreative?.Invoke(MagnificVideoUpscalerCreative!);
            }
            else if (IsEnhanceFrameRate)
            {
                enhanceFrameRate?.Invoke(EnhanceFrameRate!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative>? magnificVideoUpscalerCreative = null,
            global::System.Action<global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate>? enhanceFrameRate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificVideoUpscalerCreative)
            {
                magnificVideoUpscalerCreative?.Invoke(MagnificVideoUpscalerCreative!);
            }
            else if (IsEnhanceFrameRate)
            {
                enhanceFrameRate?.Invoke(EnhanceFrameRate!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MagnificVideoUpscalerCreative,
                typeof(global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative),
                EnhanceFrameRate,
                typeof(global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate),
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
        public bool Equals(CreateVideoUpscaleRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative?>.Default.Equals(MagnificVideoUpscalerCreative, other.MagnificVideoUpscalerCreative) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoUpscaleRequestEnhanceFrameRate?>.Default.Equals(EnhanceFrameRate, other.EnhanceFrameRate)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateVideoUpscaleRequest obj1, CreateVideoUpscaleRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVideoUpscaleRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateVideoUpscaleRequest obj1, CreateVideoUpscaleRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVideoUpscaleRequest o && Equals(o);
        }
    }
}

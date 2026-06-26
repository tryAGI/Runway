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
        public CreateVideoUpscaleRequest(
            global::Runway.CreateVideoUpscaleRequestDiscriminatorModel? model,
            global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative? magnificVideoUpscalerCreative
            )
        {
            Model = model;

            MagnificVideoUpscalerCreative = magnificVideoUpscalerCreative;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MagnificVideoUpscalerCreative as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MagnificVideoUpscalerCreative?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMagnificVideoUpscalerCreative;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative, TResult>? magnificVideoUpscalerCreative = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative>? magnificVideoUpscalerCreative = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative>? magnificVideoUpscalerCreative = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreative?>.Default.Equals(MagnificVideoUpscalerCreative, other.MagnificVideoUpscalerCreative) 
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

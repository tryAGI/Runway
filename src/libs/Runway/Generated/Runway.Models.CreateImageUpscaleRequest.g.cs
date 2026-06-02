#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateImageUpscaleRequest : global::System.IEquatable<CreateImageUpscaleRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateImageUpscaleRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? MagnificPrecisionUpscalerV2 { get; init; }
#else
        public global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? MagnificPrecisionUpscalerV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MagnificPrecisionUpscalerV2))]
#endif
        public bool IsMagnificPrecisionUpscalerV2 => MagnificPrecisionUpscalerV2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMagnificPrecisionUpscalerV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? value)
        {
            value = MagnificPrecisionUpscalerV2;
            return IsMagnificPrecisionUpscalerV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2 PickMagnificPrecisionUpscalerV2() => IsMagnificPrecisionUpscalerV2
            ? MagnificPrecisionUpscalerV2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MagnificPrecisionUpscalerV2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImageUpscaleRequest(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2 value) => new CreateImageUpscaleRequest((global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2?(CreateImageUpscaleRequest @this) => @this.MagnificPrecisionUpscalerV2;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageUpscaleRequest(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? value)
        {
            MagnificPrecisionUpscalerV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateImageUpscaleRequest FromMagnificPrecisionUpscalerV2(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? value) => new CreateImageUpscaleRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateImageUpscaleRequest(
            global::Runway.CreateImageUpscaleRequestDiscriminatorModel? model,
            global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2? magnificPrecisionUpscalerV2
            )
        {
            Model = model;

            MagnificPrecisionUpscalerV2 = magnificPrecisionUpscalerV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MagnificPrecisionUpscalerV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MagnificPrecisionUpscalerV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMagnificPrecisionUpscalerV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2, TResult>? magnificPrecisionUpscalerV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificPrecisionUpscalerV2 && magnificPrecisionUpscalerV2 != null)
            {
                return magnificPrecisionUpscalerV2(MagnificPrecisionUpscalerV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2>? magnificPrecisionUpscalerV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificPrecisionUpscalerV2)
            {
                magnificPrecisionUpscalerV2?.Invoke(MagnificPrecisionUpscalerV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2>? magnificPrecisionUpscalerV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMagnificPrecisionUpscalerV2)
            {
                magnificPrecisionUpscalerV2?.Invoke(MagnificPrecisionUpscalerV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MagnificPrecisionUpscalerV2,
                typeof(global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2),
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
        public bool Equals(CreateImageUpscaleRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2?>.Default.Equals(MagnificPrecisionUpscalerV2, other.MagnificPrecisionUpscalerV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateImageUpscaleRequest obj1, CreateImageUpscaleRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateImageUpscaleRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateImageUpscaleRequest obj1, CreateImageUpscaleRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateImageUpscaleRequest o && Equals(o);
        }
    }
}

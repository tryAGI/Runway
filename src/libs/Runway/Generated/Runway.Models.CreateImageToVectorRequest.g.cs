#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateImageToVectorRequest : global::System.IEquatable<CreateImageToVectorRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVectorRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVectorRequestIdeogramVector? IdeogramVector { get; init; }
#else
        public global::Runway.CreateImageToVectorRequestIdeogramVector? IdeogramVector { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdeogramVector))]
#endif
        public bool IsIdeogramVector => IdeogramVector != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdeogramVector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVectorRequestIdeogramVector? value)
        {
            value = IdeogramVector;
            return IsIdeogramVector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVectorRequestIdeogramVector PickIdeogramVector() => IdeogramVector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IdeogramVector' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVectorRequest(global::Runway.CreateImageToVectorRequestIdeogramVector value) => new CreateImageToVectorRequest((global::Runway.CreateImageToVectorRequestIdeogramVector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVectorRequestIdeogramVector?(CreateImageToVectorRequest @this) => @this.IdeogramVector;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVectorRequest(global::Runway.CreateImageToVectorRequestIdeogramVector? value)
        {
            IdeogramVector = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVectorRequest FromIdeogramVector(global::Runway.CreateImageToVectorRequestIdeogramVector? value) => new CreateImageToVectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVectorRequest(
            global::Runway.CreateImageToVectorRequestDiscriminatorModel? model,
            global::Runway.CreateImageToVectorRequestIdeogramVector? ideogramVector
            )
        {
            Model = model;

            IdeogramVector = ideogramVector;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            IdeogramVector as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            IdeogramVector?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsIdeogramVector;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateImageToVectorRequestIdeogramVector, TResult>? ideogramVector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramVector is { } __value0 && ideogramVector != null)
            {
                return ideogramVector(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateImageToVectorRequestIdeogramVector>? ideogramVector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramVector is { } __value0)
            {
                ideogramVector?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateImageToVectorRequestIdeogramVector>? ideogramVector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IdeogramVector is { } __value0)
            {
                ideogramVector?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IdeogramVector,
                typeof(global::Runway.CreateImageToVectorRequestIdeogramVector),
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
        public bool Equals(CreateImageToVectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVectorRequestIdeogramVector?>.Default.Equals(IdeogramVector, other.IdeogramVector)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateImageToVectorRequest obj1, CreateImageToVectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateImageToVectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateImageToVectorRequest obj1, CreateImageToVectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateImageToVectorRequest o && Equals(o);
        }
    }
}

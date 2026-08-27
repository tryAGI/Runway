#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateVideoToHdrRequest : global::System.IEquatable<CreateVideoToHdrRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToHdrRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToHdrRequestRuby? Ruby { get; init; }
#else
        public global::Runway.CreateVideoToHdrRequestRuby? Ruby { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ruby))]
#endif
        public bool IsRuby => Ruby != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRuby(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToHdrRequestRuby? value)
        {
            value = Ruby;
            return IsRuby;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToHdrRequestRuby PickRuby() => IsRuby
            ? Ruby!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ruby' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToHdrRequest(global::Runway.CreateVideoToHdrRequestRuby value) => new CreateVideoToHdrRequest((global::Runway.CreateVideoToHdrRequestRuby?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToHdrRequestRuby?(CreateVideoToHdrRequest @this) => @this.Ruby;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToHdrRequest(global::Runway.CreateVideoToHdrRequestRuby? value)
        {
            Ruby = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToHdrRequest FromRuby(global::Runway.CreateVideoToHdrRequestRuby? value) => new CreateVideoToHdrRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToHdrRequest(
            global::Runway.CreateVideoToHdrRequestDiscriminatorModel? model,
            global::Runway.CreateVideoToHdrRequestRuby? ruby
            )
        {
            Model = model;

            Ruby = ruby;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Ruby as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Ruby?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRuby;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoToHdrRequestRuby, TResult>? ruby = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRuby && ruby != null)
            {
                return ruby(Ruby!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoToHdrRequestRuby>? ruby = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRuby)
            {
                ruby?.Invoke(Ruby!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoToHdrRequestRuby>? ruby = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRuby)
            {
                ruby?.Invoke(Ruby!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ruby,
                typeof(global::Runway.CreateVideoToHdrRequestRuby),
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
        public bool Equals(CreateVideoToHdrRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToHdrRequestRuby?>.Default.Equals(Ruby, other.Ruby)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateVideoToHdrRequest obj1, CreateVideoToHdrRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVideoToHdrRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateVideoToHdrRequest obj1, CreateVideoToHdrRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVideoToHdrRequest o && Equals(o);
        }
    }
}

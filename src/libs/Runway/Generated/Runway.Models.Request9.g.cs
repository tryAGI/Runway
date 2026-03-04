#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request9 : global::System.IEquatable<Request9>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant19? Value1 { get; init; }
#else
        public global::Runway.RequestVariant19? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request9(global::Runway.RequestVariant19 value) => new Request9((global::Runway.RequestVariant19?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant19?(Request9 @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Request9(global::Runway.RequestVariant19? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.RequestVariant19?, TResult>? value1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.RequestVariant19?>? value1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Runway.RequestVariant19),
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
        public bool Equals(Request9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant19?>.Default.Equals(Value1, other.Value1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request9 obj1, Request9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request9 obj1, Request9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request9 o && Equals(o);
        }
    }
}

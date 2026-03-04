#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request2 : global::System.IEquatable<Request2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant12? Value1 { get; init; }
#else
        public global::Runway.RequestVariant12? Value1 { get; }
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
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant22? Value2 { get; init; }
#else
        public global::Runway.RequestVariant22? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant32? Value3 { get; init; }
#else
        public global::Runway.RequestVariant32? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request2(global::Runway.RequestVariant12 value) => new Request2((global::Runway.RequestVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant12?(Request2 @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Request2(global::Runway.RequestVariant12? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request2(global::Runway.RequestVariant22 value) => new Request2((global::Runway.RequestVariant22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant22?(Request2 @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Request2(global::Runway.RequestVariant22? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request2(global::Runway.RequestVariant32 value) => new Request2((global::Runway.RequestVariant32?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant32?(Request2 @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Request2(global::Runway.RequestVariant32? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Request2(
            global::Runway.RequestVariant12? value1,
            global::Runway.RequestVariant22? value2,
            global::Runway.RequestVariant32? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.RequestVariant12?, TResult>? value1 = null,
            global::System.Func<global::Runway.RequestVariant22?, TResult>? value2 = null,
            global::System.Func<global::Runway.RequestVariant32?, TResult>? value3 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.RequestVariant12?>? value1 = null,
            global::System.Action<global::Runway.RequestVariant22?>? value2 = null,
            global::System.Action<global::Runway.RequestVariant32?>? value3 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                typeof(global::Runway.RequestVariant12),
                Value2,
                typeof(global::Runway.RequestVariant22),
                Value3,
                typeof(global::Runway.RequestVariant32),
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
        public bool Equals(Request2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant12?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant22?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant32?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request2 obj1, Request2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request2 obj1, Request2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request2 o && Equals(o);
        }
    }
}

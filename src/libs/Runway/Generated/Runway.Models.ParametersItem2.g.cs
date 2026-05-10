#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ParametersItem2 : global::System.IEquatable<ParametersItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? String { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? Integer { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? Integer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Integer))]
#endif
        public bool IsInteger => Integer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInteger(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? Number { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? Number { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? Boolean { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? Boolean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBoolean(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? Array { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? Array { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? ObjectValue { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? ObjectValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter?(ParametersItem2 @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromString(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter?(ParametersItem2 @this) => @this.Integer;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? value)
        {
            Integer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromInteger(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter?(ParametersItem2 @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromNumber(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter?(ParametersItem2 @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromBoolean(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter?(ParametersItem2 @this) => @this.Array;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? value)
        {
            Array = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromArray(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter?(ParametersItem2 @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem2 FromObjectValue(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? value) => new ParametersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem2(
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter? @string,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter? integer,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter? number,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter? boolean,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter? array,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter? objectValue
            )
        {
            Type = type;

            String = @string;
            Integer = integer;
            Number = number;
            Boolean = boolean;
            Array = array;
            ObjectValue = objectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObjectValue as object ??
            Array as object ??
            Boolean as object ??
            Number as object ??
            Integer as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Integer?.ToString() ??
            Number?.ToString() ??
            Boolean?.ToString() ??
            Array?.ToString() ??
            ObjectValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsString && IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsString && !IsInteger && IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsString && !IsInteger && !IsNumber && IsBoolean && !IsArray && !IsObjectValue || !IsString && !IsInteger && !IsNumber && !IsBoolean && IsArray && !IsObjectValue || !IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter, TResult>? @string = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter, TResult>? integer = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter, TResult>? number = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter, TResult>? boolean = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter, TResult>? array = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter, TResult>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsInteger && integer != null)
            {
                return integer(Integer!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }
            else if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter>? @string = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter>? integer = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter>? number = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter>? boolean = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter>? array = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter>? @string = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter>? integer = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter>? number = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter>? boolean = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter>? array = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter),
                Integer,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter),
                Number,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter),
                Boolean,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter),
                Array,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter),
                ObjectValue,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter),
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
        public bool Equals(ParametersItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterStringParameter?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterIntegerParameter?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterNumberParameter?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterBooleanParameter?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameter?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCToolParameterObjectParameter?>.Default.Equals(ObjectValue, other.ObjectValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ParametersItem2 obj1, ParametersItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParametersItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ParametersItem2 obj1, ParametersItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParametersItem2 o && Equals(o);
        }
    }
}

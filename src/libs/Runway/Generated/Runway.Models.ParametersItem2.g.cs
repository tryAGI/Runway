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
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? String { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? String { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter PickString() => String is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? Integer { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? Integer { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter PickInteger() => Integer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? Number { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? Number { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter PickNumber() => Number is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? Boolean { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? Boolean { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter PickBoolean() => Boolean is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? Array { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? Array { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter PickArray() => Array is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? ObjectValue { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? ObjectValue { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter PickObjectValue() => ObjectValue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter?(ParametersItem2 @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromString(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter?(ParametersItem2 @this) => @this.Integer;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? value)
        {
            Integer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromInteger(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter?(ParametersItem2 @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromNumber(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter?(ParametersItem2 @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromBoolean(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter?(ParametersItem2 @this) => @this.Array;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? value)
        {
            Array = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromArray(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter value) => new ParametersItem2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter?(ParametersItem2 @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem2 FromObjectValue(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? value) => new ParametersItem2(value);

        /// <summary>
        ///
        /// </summary>
        public ParametersItem2(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter? @string,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter? integer,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter? number,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter? boolean,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter? array,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter? objectValue
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter, TResult>? @string = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter, TResult>? integer = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter, TResult>? number = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter, TResult>? boolean = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter, TResult>? array = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter, TResult>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0 && @string != null)
            {
                return @string(__value0);
            }
            else if (Integer is { } __value1 && integer != null)
            {
                return integer(__value1);
            }
            else if (Number is { } __value2 && number != null)
            {
                return number(__value2);
            }
            else if (Boolean is { } __value3 && boolean != null)
            {
                return boolean(__value3);
            }
            else if (Array is { } __value4 && array != null)
            {
                return array(__value4);
            }
            else if (ObjectValue is { } __value5 && objectValue != null)
            {
                return objectValue(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter>? @string = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter>? integer = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter>? number = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter>? boolean = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter>? array = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0)
            {
                @string?.Invoke(__value0);
            }
            else if (Integer is { } __value1)
            {
                integer?.Invoke(__value1);
            }
            else if (Number is { } __value2)
            {
                number?.Invoke(__value2);
            }
            else if (Boolean is { } __value3)
            {
                boolean?.Invoke(__value3);
            }
            else if (Array is { } __value4)
            {
                array?.Invoke(__value4);
            }
            else if (ObjectValue is { } __value5)
            {
                objectValue?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter>? @string = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter>? integer = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter>? number = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter>? boolean = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter>? array = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (String is { } __value0)
            {
                @string?.Invoke(__value0);
            }
            else if (Integer is { } __value1)
            {
                integer?.Invoke(__value1);
            }
            else if (Number is { } __value2)
            {
                number?.Invoke(__value2);
            }
            else if (Boolean is { } __value3)
            {
                boolean?.Invoke(__value3);
            }
            else if (Array is { } __value4)
            {
                array?.Invoke(__value4);
            }
            else if (ObjectValue is { } __value5)
            {
                objectValue?.Invoke(__value5);
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
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter),
                Integer,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter),
                Number,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter),
                Boolean,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter),
                Array,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter),
                ObjectValue,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterStringParameter?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterIntegerParameter?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterNumberParameter?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterBooleanParameter?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameter?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterObjectParameter?>.Default.Equals(ObjectValue, other.ObjectValue)
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

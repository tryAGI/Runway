#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ParametersItem : global::System.IEquatable<ParametersItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? String { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? String { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter PickString() => String is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? Integer { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? Integer { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter PickInteger() => Integer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? Number { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? Number { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter PickNumber() => Number is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? Boolean { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? Boolean { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter PickBoolean() => Boolean is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? Array { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? Array { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter PickArray() => Array is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? ObjectValue { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? ObjectValue { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter PickObjectValue() => ObjectValue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter?(ParametersItem @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromString(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter?(ParametersItem @this) => @this.Integer;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? value)
        {
            Integer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromInteger(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter?(ParametersItem @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromNumber(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter?(ParametersItem @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromBoolean(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter?(ParametersItem @this) => @this.Array;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? value)
        {
            Array = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromArray(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter?(ParametersItem @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParametersItem FromObjectValue(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? value) => new ParametersItem(value);

        /// <summary>
        ///
        /// </summary>
        public ParametersItem(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter? @string,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter? integer,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter? number,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter? boolean,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter? array,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter? objectValue
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter, TResult>? @string = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter, TResult>? integer = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter, TResult>? number = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter, TResult>? boolean = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter, TResult>? array = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter, TResult>? objectValue = null,
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
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter>? @string = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter>? integer = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter>? number = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter>? boolean = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter>? array = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter>? objectValue = null,
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
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter>? @string = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter>? integer = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter>? number = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter>? boolean = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter>? array = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter>? objectValue = null,
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
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter),
                Integer,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter),
                Number,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter),
                Boolean,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter),
                Array,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter),
                ObjectValue,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter),
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
        public bool Equals(ParametersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterStringParameter?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterIntegerParameter?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterNumberParameter?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterBooleanParameter?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameter?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterObjectParameter?>.Default.Equals(ObjectValue, other.ObjectValue)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ParametersItem obj1, ParametersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParametersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ParametersItem obj1, ParametersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParametersItem o && Equals(o);
        }
    }
}

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
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? String { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? String { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter PickString() => IsString
            ? String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? Integer { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? Integer { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter PickInteger() => IsInteger
            ? Integer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? Number { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? Number { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter PickNumber() => IsNumber
            ? Number!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? Boolean { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? Boolean { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter PickBoolean() => IsBoolean
            ? Boolean!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? Array { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? Array { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter PickArray() => IsArray
            ? Array!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? ObjectValue { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? ObjectValue { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter?(ParametersItem @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromString(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter?(ParametersItem @this) => @this.Integer;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? value)
        {
            Integer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromInteger(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter?(ParametersItem @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromNumber(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter?(ParametersItem @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromBoolean(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter?(ParametersItem @this) => @this.Array;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? value)
        {
            Array = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromArray(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter value) => new ParametersItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter?(ParametersItem @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParametersItem FromObjectValue(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? value) => new ParametersItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter? @string,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter? integer,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter? number,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter? boolean,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter? array,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter? objectValue
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter, TResult>? @string = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter, TResult>? integer = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter, TResult>? number = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter, TResult>? boolean = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter, TResult>? array = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter, TResult>? objectValue = null,
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
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter>? @string = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter>? integer = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter>? number = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter>? boolean = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter>? array = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter>? objectValue = null,
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
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter>? @string = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter>? integer = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter>? number = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter>? boolean = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter>? array = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter>? objectValue = null,
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
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter),
                Integer,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter),
                Number,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter),
                Boolean,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter),
                Array,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter),
                ObjectValue,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterStringParameter?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterIntegerParameter?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterNumberParameter?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterBooleanParameter?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameter?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterObjectParameter?>.Default.Equals(ObjectValue, other.ObjectValue) 
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

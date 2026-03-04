#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
    /// </summary>
    public readonly partial struct Character : global::System.IEquatable<Character>
    {
        /// <summary>
        /// An image of your character. In the output, the character will use the reference video performance in its original static environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant1CharacterVariant1? Value1 { get; init; }
#else
        public global::Runway.RequestVariant1CharacterVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// A video of your character. In the output, the character will use the reference video performance in its original animated environment and some of the character's own movements.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.RequestVariant1CharacterVariant2? Value2 { get; init; }
#else
        public global::Runway.RequestVariant1CharacterVariant2? Value2 { get; }
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
        public static implicit operator Character(global::Runway.RequestVariant1CharacterVariant1 value) => new Character((global::Runway.RequestVariant1CharacterVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant1CharacterVariant1?(Character @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Character(global::Runway.RequestVariant1CharacterVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Character(global::Runway.RequestVariant1CharacterVariant2 value) => new Character((global::Runway.RequestVariant1CharacterVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.RequestVariant1CharacterVariant2?(Character @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Character(global::Runway.RequestVariant1CharacterVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Character(
            global::Runway.RequestVariant1CharacterVariant1? value1,
            global::Runway.RequestVariant1CharacterVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.RequestVariant1CharacterVariant1?, TResult>? value1 = null,
            global::System.Func<global::Runway.RequestVariant1CharacterVariant2?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.RequestVariant1CharacterVariant1?>? value1 = null,
            global::System.Action<global::Runway.RequestVariant1CharacterVariant2?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Runway.RequestVariant1CharacterVariant1),
                Value2,
                typeof(global::Runway.RequestVariant1CharacterVariant2),
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
        public bool Equals(Character other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant1CharacterVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.RequestVariant1CharacterVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Character obj1, Character obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Character>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Character obj1, Character obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Character o && Equals(o);
        }
    }
}

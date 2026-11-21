#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateTextToMusicRequest : global::System.IEquatable<CreateTextToMusicRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToMusicRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToMusicRequestElevenMusicV25? ElevenMusicV25 { get; init; }
#else
        public global::Runway.CreateTextToMusicRequestElevenMusicV25? ElevenMusicV25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenMusicV25))]
#endif
        public bool IsElevenMusicV25 => ElevenMusicV25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickElevenMusicV25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToMusicRequestElevenMusicV25? value)
        {
            value = ElevenMusicV25;
            return IsElevenMusicV25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToMusicRequestElevenMusicV25 PickElevenMusicV25() => ElevenMusicV25 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenMusicV25' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToMusicRequest(global::Runway.CreateTextToMusicRequestElevenMusicV25 value) => new CreateTextToMusicRequest((global::Runway.CreateTextToMusicRequestElevenMusicV25?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToMusicRequestElevenMusicV25?(CreateTextToMusicRequest @this) => @this.ElevenMusicV25;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToMusicRequest(global::Runway.CreateTextToMusicRequestElevenMusicV25? value)
        {
            ElevenMusicV25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToMusicRequest FromElevenMusicV25(global::Runway.CreateTextToMusicRequestElevenMusicV25? value) => new CreateTextToMusicRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateTextToMusicRequest(
            global::Runway.CreateTextToMusicRequestDiscriminatorModel? model,
            global::Runway.CreateTextToMusicRequestElevenMusicV25? elevenMusicV25
            )
        {
            Model = model;

            ElevenMusicV25 = elevenMusicV25;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ElevenMusicV25 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ElevenMusicV25?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsElevenMusicV25;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToMusicRequestElevenMusicV25, TResult>? elevenMusicV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ElevenMusicV25 is { } __value0 && elevenMusicV25 != null)
            {
                return elevenMusicV25(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToMusicRequestElevenMusicV25>? elevenMusicV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ElevenMusicV25 is { } __value0)
            {
                elevenMusicV25?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToMusicRequestElevenMusicV25>? elevenMusicV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ElevenMusicV25 is { } __value0)
            {
                elevenMusicV25?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenMusicV25,
                typeof(global::Runway.CreateTextToMusicRequestElevenMusicV25),
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
        public bool Equals(CreateTextToMusicRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToMusicRequestElevenMusicV25?>.Default.Equals(ElevenMusicV25, other.ElevenMusicV25)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateTextToMusicRequest obj1, CreateTextToMusicRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToMusicRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateTextToMusicRequest obj1, CreateTextToMusicRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToMusicRequest o && Equals(o);
        }
    }
}

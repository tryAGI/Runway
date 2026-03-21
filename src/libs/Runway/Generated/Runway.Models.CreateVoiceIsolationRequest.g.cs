#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateVoiceIsolationRequest : global::System.IEquatable<CreateVoiceIsolationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation? ElevenVoiceIsolation { get; init; }
#else
        public global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation? ElevenVoiceIsolation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenVoiceIsolation))]
#endif
        public bool IsElevenVoiceIsolation => ElevenVoiceIsolation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVoiceIsolationRequest(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation value) => new CreateVoiceIsolationRequest((global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?(CreateVoiceIsolationRequest @this) => @this.ElevenVoiceIsolation;

        /// <summary>
        /// 
        /// </summary>
        public CreateVoiceIsolationRequest(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation? value)
        {
            ElevenVoiceIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenVoiceIsolation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenVoiceIsolation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenVoiceIsolation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?, TResult>? elevenVoiceIsolation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceIsolation && elevenVoiceIsolation != null)
            {
                return elevenVoiceIsolation(ElevenVoiceIsolation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?>? elevenVoiceIsolation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceIsolation)
            {
                elevenVoiceIsolation?.Invoke(ElevenVoiceIsolation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenVoiceIsolation,
                typeof(global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation),
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
        public bool Equals(CreateVoiceIsolationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVoiceIsolationRequestElevenVoiceIsolation?>.Default.Equals(ElevenVoiceIsolation, other.ElevenVoiceIsolation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateVoiceIsolationRequest obj1, CreateVoiceIsolationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVoiceIsolationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateVoiceIsolationRequest obj1, CreateVoiceIsolationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVoiceIsolationRequest o && Equals(o);
        }
    }
}

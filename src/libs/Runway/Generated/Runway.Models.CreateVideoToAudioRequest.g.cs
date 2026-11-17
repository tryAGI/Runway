#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateVideoToAudioRequest : global::System.IEquatable<CreateVideoToAudioRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToAudioRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToAudioRequestMireloSfx20? MireloSfx20 { get; init; }
#else
        public global::Runway.CreateVideoToAudioRequestMireloSfx20? MireloSfx20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MireloSfx20))]
#endif
        public bool IsMireloSfx20 => MireloSfx20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMireloSfx20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToAudioRequestMireloSfx20? value)
        {
            value = MireloSfx20;
            return IsMireloSfx20;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToAudioRequestMireloSfx20 PickMireloSfx20() => MireloSfx20 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MireloSfx20' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToAudioRequest(global::Runway.CreateVideoToAudioRequestMireloSfx20 value) => new CreateVideoToAudioRequest((global::Runway.CreateVideoToAudioRequestMireloSfx20?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToAudioRequestMireloSfx20?(CreateVideoToAudioRequest @this) => @this.MireloSfx20;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToAudioRequest(global::Runway.CreateVideoToAudioRequestMireloSfx20? value)
        {
            MireloSfx20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToAudioRequest FromMireloSfx20(global::Runway.CreateVideoToAudioRequestMireloSfx20? value) => new CreateVideoToAudioRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToAudioRequest(
            global::Runway.CreateVideoToAudioRequestDiscriminatorModel? model,
            global::Runway.CreateVideoToAudioRequestMireloSfx20? mireloSfx20
            )
        {
            Model = model;

            MireloSfx20 = mireloSfx20;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MireloSfx20 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MireloSfx20?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMireloSfx20;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoToAudioRequestMireloSfx20, TResult>? mireloSfx20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MireloSfx20 is { } __value0 && mireloSfx20 != null)
            {
                return mireloSfx20(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoToAudioRequestMireloSfx20>? mireloSfx20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MireloSfx20 is { } __value0)
            {
                mireloSfx20?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoToAudioRequestMireloSfx20>? mireloSfx20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MireloSfx20 is { } __value0)
            {
                mireloSfx20?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MireloSfx20,
                typeof(global::Runway.CreateVideoToAudioRequestMireloSfx20),
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
        public bool Equals(CreateVideoToAudioRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToAudioRequestMireloSfx20?>.Default.Equals(MireloSfx20, other.MireloSfx20)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateVideoToAudioRequest obj1, CreateVideoToAudioRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVideoToAudioRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateVideoToAudioRequest obj1, CreateVideoToAudioRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVideoToAudioRequest o && Equals(o);
        }
    }
}

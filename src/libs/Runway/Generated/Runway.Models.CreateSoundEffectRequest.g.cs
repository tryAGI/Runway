#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateSoundEffectRequest : global::System.IEquatable<CreateSoundEffectRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateSoundEffectRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateSoundEffectRequestSeedAudio? SeedAudio { get; init; }
#else
        public global::Runway.CreateSoundEffectRequestSeedAudio? SeedAudio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SeedAudio))]
#endif
        public bool IsSeedAudio => SeedAudio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateSoundEffectRequestSeedAudio? value)
        {
            value = SeedAudio;
            return IsSeedAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateSoundEffectRequestSeedAudio PickSeedAudio() => SeedAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SeedAudio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateSoundEffectRequestMireloSfx20? MireloSfx20 { get; init; }
#else
        public global::Runway.CreateSoundEffectRequestMireloSfx20? MireloSfx20 { get; }
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
            out global::Runway.CreateSoundEffectRequestMireloSfx20? value)
        {
            value = MireloSfx20;
            return IsMireloSfx20;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateSoundEffectRequestMireloSfx20 PickMireloSfx20() => MireloSfx20 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MireloSfx20' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; init; }
#else
        public global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenTextToSoundV2))]
#endif
        public bool IsElevenTextToSoundV2 => ElevenTextToSoundV2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickElevenTextToSoundV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? value)
        {
            value = ElevenTextToSoundV2;
            return IsElevenTextToSoundV2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateSoundEffectRequestElevenTextToSoundV2 PickElevenTextToSoundV2() => ElevenTextToSoundV2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenTextToSoundV2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestSeedAudio value) => new CreateSoundEffectRequest((global::Runway.CreateSoundEffectRequestSeedAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateSoundEffectRequestSeedAudio?(CreateSoundEffectRequest @this) => @this.SeedAudio;

        /// <summary>
        ///
        /// </summary>
        public CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestSeedAudio? value)
        {
            SeedAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSoundEffectRequest FromSeedAudio(global::Runway.CreateSoundEffectRequestSeedAudio? value) => new CreateSoundEffectRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestMireloSfx20 value) => new CreateSoundEffectRequest((global::Runway.CreateSoundEffectRequestMireloSfx20?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateSoundEffectRequestMireloSfx20?(CreateSoundEffectRequest @this) => @this.MireloSfx20;

        /// <summary>
        ///
        /// </summary>
        public CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestMireloSfx20? value)
        {
            MireloSfx20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSoundEffectRequest FromMireloSfx20(global::Runway.CreateSoundEffectRequestMireloSfx20? value) => new CreateSoundEffectRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2 value) => new CreateSoundEffectRequest((global::Runway.CreateSoundEffectRequestElevenTextToSoundV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateSoundEffectRequestElevenTextToSoundV2?(CreateSoundEffectRequest @this) => @this.ElevenTextToSoundV2;

        /// <summary>
        ///
        /// </summary>
        public CreateSoundEffectRequest(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? value)
        {
            ElevenTextToSoundV2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSoundEffectRequest FromElevenTextToSoundV2(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? value) => new CreateSoundEffectRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateSoundEffectRequest(
            global::Runway.CreateSoundEffectRequestDiscriminatorModel? model,
            global::Runway.CreateSoundEffectRequestSeedAudio? seedAudio,
            global::Runway.CreateSoundEffectRequestMireloSfx20? mireloSfx20,
            global::Runway.CreateSoundEffectRequestElevenTextToSoundV2? elevenTextToSoundV2
            )
        {
            Model = model;

            SeedAudio = seedAudio;
            MireloSfx20 = mireloSfx20;
            ElevenTextToSoundV2 = elevenTextToSoundV2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ElevenTextToSoundV2 as object ??
            MireloSfx20 as object ??
            SeedAudio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SeedAudio?.ToString() ??
            MireloSfx20?.ToString() ??
            ElevenTextToSoundV2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSeedAudio && !IsMireloSfx20 && !IsElevenTextToSoundV2 || !IsSeedAudio && IsMireloSfx20 && !IsElevenTextToSoundV2 || !IsSeedAudio && !IsMireloSfx20 && IsElevenTextToSoundV2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateSoundEffectRequestSeedAudio, TResult>? seedAudio = null,
            global::System.Func<global::Runway.CreateSoundEffectRequestMireloSfx20, TResult>? mireloSfx20 = null,
            global::System.Func<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2, TResult>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SeedAudio is { } __value0 && seedAudio != null)
            {
                return seedAudio(__value0);
            }
            else if (MireloSfx20 is { } __value1 && mireloSfx20 != null)
            {
                return mireloSfx20(__value1);
            }
            else if (ElevenTextToSoundV2 is { } __value2 && elevenTextToSoundV2 != null)
            {
                return elevenTextToSoundV2(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateSoundEffectRequestSeedAudio>? seedAudio = null,

            global::System.Action<global::Runway.CreateSoundEffectRequestMireloSfx20>? mireloSfx20 = null,

            global::System.Action<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SeedAudio is { } __value0)
            {
                seedAudio?.Invoke(__value0);
            }
            else if (MireloSfx20 is { } __value1)
            {
                mireloSfx20?.Invoke(__value1);
            }
            else if (ElevenTextToSoundV2 is { } __value2)
            {
                elevenTextToSoundV2?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateSoundEffectRequestSeedAudio>? seedAudio = null,
            global::System.Action<global::Runway.CreateSoundEffectRequestMireloSfx20>? mireloSfx20 = null,
            global::System.Action<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SeedAudio is { } __value0)
            {
                seedAudio?.Invoke(__value0);
            }
            else if (MireloSfx20 is { } __value1)
            {
                mireloSfx20?.Invoke(__value1);
            }
            else if (ElevenTextToSoundV2 is { } __value2)
            {
                elevenTextToSoundV2?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SeedAudio,
                typeof(global::Runway.CreateSoundEffectRequestSeedAudio),
                MireloSfx20,
                typeof(global::Runway.CreateSoundEffectRequestMireloSfx20),
                ElevenTextToSoundV2,
                typeof(global::Runway.CreateSoundEffectRequestElevenTextToSoundV2),
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
        public bool Equals(CreateSoundEffectRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateSoundEffectRequestSeedAudio?>.Default.Equals(SeedAudio, other.SeedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateSoundEffectRequestMireloSfx20?>.Default.Equals(MireloSfx20, other.MireloSfx20) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateSoundEffectRequestElevenTextToSoundV2?>.Default.Equals(ElevenTextToSoundV2, other.ElevenTextToSoundV2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateSoundEffectRequest obj1, CreateSoundEffectRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSoundEffectRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateSoundEffectRequest obj1, CreateSoundEffectRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSoundEffectRequest o && Equals(o);
        }
    }
}

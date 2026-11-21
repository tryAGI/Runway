#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateTextToSpeechRequest : global::System.IEquatable<CreateTextToSpeechRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestSeedAudio? SeedAudio { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestSeedAudio? SeedAudio { get; }
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
            out global::Runway.CreateTextToSpeechRequestSeedAudio? value)
        {
            value = SeedAudio;
            return IsSeedAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestSeedAudio PickSeedAudio() => SeedAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SeedAudio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestElevenV4? ElevenV4 { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestElevenV4? ElevenV4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenV4))]
#endif
        public bool IsElevenV4 => ElevenV4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickElevenV4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestElevenV4? value)
        {
            value = ElevenV4;
            return IsElevenV4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenV4 PickElevenV4() => ElevenV4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenV4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestGemini38FlashTts? Gemini38FlashTts { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestGemini38FlashTts? Gemini38FlashTts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini38FlashTts))]
#endif
        public bool IsGemini38FlashTts => Gemini38FlashTts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini38FlashTts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestGemini38FlashTts? value)
        {
            value = Gemini38FlashTts;
            return IsGemini38FlashTts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestGemini38FlashTts PickGemini38FlashTts() => Gemini38FlashTts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini38FlashTts' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? Gemini38FlashLiteTts { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? Gemini38FlashLiteTts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini38FlashLiteTts))]
#endif
        public bool IsGemini38FlashLiteTts => Gemini38FlashLiteTts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini38FlashLiteTts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? value)
        {
            value = Gemini38FlashLiteTts;
            return IsGemini38FlashLiteTts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts PickGemini38FlashLiteTts() => Gemini38FlashLiteTts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini38FlashLiteTts' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? ElevenMultilingualV2 { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? ElevenMultilingualV2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenMultilingualV2))]
#endif
        public bool IsElevenMultilingualV2 => ElevenMultilingualV2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickElevenMultilingualV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? value)
        {
            value = ElevenMultilingualV2;
            return IsElevenMultilingualV2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenMultilingualV2 PickElevenMultilingualV2() => ElevenMultilingualV2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenMultilingualV2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToSpeechRequestElevenV3? ElevenV3 { get; init; }
#else
        public global::Runway.CreateTextToSpeechRequestElevenV3? ElevenV3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenV3))]
#endif
        public bool IsElevenV3 => ElevenV3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickElevenV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToSpeechRequestElevenV3? value)
        {
            value = ElevenV3;
            return IsElevenV3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToSpeechRequestElevenV3 PickElevenV3() => ElevenV3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenV3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestSeedAudio value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestSeedAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestSeedAudio?(CreateTextToSpeechRequest @this) => @this.SeedAudio;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestSeedAudio? value)
        {
            SeedAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromSeedAudio(global::Runway.CreateTextToSpeechRequestSeedAudio? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenV4 value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestElevenV4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestElevenV4?(CreateTextToSpeechRequest @this) => @this.ElevenV4;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenV4? value)
        {
            ElevenV4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromElevenV4(global::Runway.CreateTextToSpeechRequestElevenV4? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestGemini38FlashTts value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestGemini38FlashTts?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestGemini38FlashTts?(CreateTextToSpeechRequest @this) => @this.Gemini38FlashTts;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestGemini38FlashTts? value)
        {
            Gemini38FlashTts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromGemini38FlashTts(global::Runway.CreateTextToSpeechRequestGemini38FlashTts? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts?(CreateTextToSpeechRequest @this) => @this.Gemini38FlashLiteTts;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? value)
        {
            Gemini38FlashLiteTts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromGemini38FlashLiteTts(global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2 value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestElevenMultilingualV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestElevenMultilingualV2?(CreateTextToSpeechRequest @this) => @this.ElevenMultilingualV2;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? value)
        {
            ElevenMultilingualV2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromElevenMultilingualV2(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenV3 value) => new CreateTextToSpeechRequest((global::Runway.CreateTextToSpeechRequestElevenV3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToSpeechRequestElevenV3?(CreateTextToSpeechRequest @this) => @this.ElevenV3;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(global::Runway.CreateTextToSpeechRequestElevenV3? value)
        {
            ElevenV3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToSpeechRequest FromElevenV3(global::Runway.CreateTextToSpeechRequestElevenV3? value) => new CreateTextToSpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateTextToSpeechRequest(
            global::Runway.CreateTextToSpeechRequestDiscriminatorModel? model,
            global::Runway.CreateTextToSpeechRequestSeedAudio? seedAudio,
            global::Runway.CreateTextToSpeechRequestElevenV4? elevenV4,
            global::Runway.CreateTextToSpeechRequestGemini38FlashTts? gemini38FlashTts,
            global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts? gemini38FlashLiteTts,
            global::Runway.CreateTextToSpeechRequestElevenMultilingualV2? elevenMultilingualV2,
            global::Runway.CreateTextToSpeechRequestElevenV3? elevenV3
            )
        {
            Model = model;

            SeedAudio = seedAudio;
            ElevenV4 = elevenV4;
            Gemini38FlashTts = gemini38FlashTts;
            Gemini38FlashLiteTts = gemini38FlashLiteTts;
            ElevenMultilingualV2 = elevenMultilingualV2;
            ElevenV3 = elevenV3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ElevenV3 as object ??
            ElevenMultilingualV2 as object ??
            Gemini38FlashLiteTts as object ??
            Gemini38FlashTts as object ??
            ElevenV4 as object ??
            SeedAudio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SeedAudio?.ToString() ??
            ElevenV4?.ToString() ??
            Gemini38FlashTts?.ToString() ??
            Gemini38FlashLiteTts?.ToString() ??
            ElevenMultilingualV2?.ToString() ??
            ElevenV3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSeedAudio && !IsElevenV4 && !IsGemini38FlashTts && !IsGemini38FlashLiteTts && !IsElevenMultilingualV2 && !IsElevenV3 || !IsSeedAudio && IsElevenV4 && !IsGemini38FlashTts && !IsGemini38FlashLiteTts && !IsElevenMultilingualV2 && !IsElevenV3 || !IsSeedAudio && !IsElevenV4 && IsGemini38FlashTts && !IsGemini38FlashLiteTts && !IsElevenMultilingualV2 && !IsElevenV3 || !IsSeedAudio && !IsElevenV4 && !IsGemini38FlashTts && IsGemini38FlashLiteTts && !IsElevenMultilingualV2 && !IsElevenV3 || !IsSeedAudio && !IsElevenV4 && !IsGemini38FlashTts && !IsGemini38FlashLiteTts && IsElevenMultilingualV2 && !IsElevenV3 || !IsSeedAudio && !IsElevenV4 && !IsGemini38FlashTts && !IsGemini38FlashLiteTts && !IsElevenMultilingualV2 && IsElevenV3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToSpeechRequestSeedAudio, TResult>? seedAudio = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestElevenV4, TResult>? elevenV4 = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestGemini38FlashTts, TResult>? gemini38FlashTts = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts, TResult>? gemini38FlashLiteTts = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2, TResult>? elevenMultilingualV2 = null,
            global::System.Func<global::Runway.CreateTextToSpeechRequestElevenV3, TResult>? elevenV3 = null,
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
            else if (ElevenV4 is { } __value1 && elevenV4 != null)
            {
                return elevenV4(__value1);
            }
            else if (Gemini38FlashTts is { } __value2 && gemini38FlashTts != null)
            {
                return gemini38FlashTts(__value2);
            }
            else if (Gemini38FlashLiteTts is { } __value3 && gemini38FlashLiteTts != null)
            {
                return gemini38FlashLiteTts(__value3);
            }
            else if (ElevenMultilingualV2 is { } __value4 && elevenMultilingualV2 != null)
            {
                return elevenMultilingualV2(__value4);
            }
            else if (ElevenV3 is { } __value5 && elevenV3 != null)
            {
                return elevenV3(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudio>? seedAudio = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV4>? elevenV4 = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestGemini38FlashTts>? gemini38FlashTts = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts>? gemini38FlashLiteTts = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2>? elevenMultilingualV2 = null,

            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3>? elevenV3 = null,
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
            else if (ElevenV4 is { } __value1)
            {
                elevenV4?.Invoke(__value1);
            }
            else if (Gemini38FlashTts is { } __value2)
            {
                gemini38FlashTts?.Invoke(__value2);
            }
            else if (Gemini38FlashLiteTts is { } __value3)
            {
                gemini38FlashLiteTts?.Invoke(__value3);
            }
            else if (ElevenMultilingualV2 is { } __value4)
            {
                elevenMultilingualV2?.Invoke(__value4);
            }
            else if (ElevenV3 is { } __value5)
            {
                elevenV3?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToSpeechRequestSeedAudio>? seedAudio = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV4>? elevenV4 = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestGemini38FlashTts>? gemini38FlashTts = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts>? gemini38FlashLiteTts = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2>? elevenMultilingualV2 = null,
            global::System.Action<global::Runway.CreateTextToSpeechRequestElevenV3>? elevenV3 = null,
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
            else if (ElevenV4 is { } __value1)
            {
                elevenV4?.Invoke(__value1);
            }
            else if (Gemini38FlashTts is { } __value2)
            {
                gemini38FlashTts?.Invoke(__value2);
            }
            else if (Gemini38FlashLiteTts is { } __value3)
            {
                gemini38FlashLiteTts?.Invoke(__value3);
            }
            else if (ElevenMultilingualV2 is { } __value4)
            {
                elevenMultilingualV2?.Invoke(__value4);
            }
            else if (ElevenV3 is { } __value5)
            {
                elevenV3?.Invoke(__value5);
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
                typeof(global::Runway.CreateTextToSpeechRequestSeedAudio),
                ElevenV4,
                typeof(global::Runway.CreateTextToSpeechRequestElevenV4),
                Gemini38FlashTts,
                typeof(global::Runway.CreateTextToSpeechRequestGemini38FlashTts),
                Gemini38FlashLiteTts,
                typeof(global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts),
                ElevenMultilingualV2,
                typeof(global::Runway.CreateTextToSpeechRequestElevenMultilingualV2),
                ElevenV3,
                typeof(global::Runway.CreateTextToSpeechRequestElevenV3),
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
        public bool Equals(CreateTextToSpeechRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestSeedAudio?>.Default.Equals(SeedAudio, other.SeedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestElevenV4?>.Default.Equals(ElevenV4, other.ElevenV4) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestGemini38FlashTts?>.Default.Equals(Gemini38FlashTts, other.Gemini38FlashTts) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTts?>.Default.Equals(Gemini38FlashLiteTts, other.Gemini38FlashLiteTts) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestElevenMultilingualV2?>.Default.Equals(ElevenMultilingualV2, other.ElevenMultilingualV2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToSpeechRequestElevenV3?>.Default.Equals(ElevenV3, other.ElevenV3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateTextToSpeechRequest obj1, CreateTextToSpeechRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToSpeechRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateTextToSpeechRequest obj1, CreateTextToSpeechRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToSpeechRequest o && Equals(o);
        }
    }
}

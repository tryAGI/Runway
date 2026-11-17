#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateTextToImageRequest : global::System.IEquatable<CreateTextToImageRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGen4ImageTurbo? Gen4ImageTurbo { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGen4ImageTurbo? Gen4ImageTurbo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4ImageTurbo))]
#endif
        public bool IsGen4ImageTurbo => Gen4ImageTurbo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGen4ImageTurbo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGen4ImageTurbo? value)
        {
            value = Gen4ImageTurbo;
            return IsGen4ImageTurbo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGen4ImageTurbo PickGen4ImageTurbo() => Gen4ImageTurbo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen4ImageTurbo' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGen4Image? Gen4Image { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGen4Image? Gen4Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Image))]
#endif
        public bool IsGen4Image => Gen4Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGen4Image(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGen4Image? value)
        {
            value = Gen4Image;
            return IsGen4Image;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGen4Image PickGen4Image() => Gen4Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen4Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGptImage2? GptImage2 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGptImage2? GptImage2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage2))]
#endif
        public bool IsGptImage2 => GptImage2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGptImage2? value)
        {
            value = GptImage2;
            return IsGptImage2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGptImage2 PickGptImage2() => GptImage2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGeminiImage31Flash? GeminiImage31Flash { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGeminiImage31Flash? GeminiImage31Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiImage31Flash))]
#endif
        public bool IsGeminiImage31Flash => GeminiImage31Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiImage31Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGeminiImage31Flash? value)
        {
            value = GeminiImage31Flash;
            return IsGeminiImage31Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGeminiImage31Flash PickGeminiImage31Flash() => GeminiImage31Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiImage31Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestMuseImage? MuseImage { get; init; }
#else
        public global::Runway.CreateTextToImageRequestMuseImage? MuseImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MuseImage))]
#endif
        public bool IsMuseImage => MuseImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMuseImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestMuseImage? value)
        {
            value = MuseImage;
            return IsMuseImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestMuseImage PickMuseImage() => MuseImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MuseImage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestSeedream5Pro? Seedream5Pro { get; init; }
#else
        public global::Runway.CreateTextToImageRequestSeedream5Pro? Seedream5Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedream5Pro))]
#endif
        public bool IsSeedream5Pro => Seedream5Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedream5Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestSeedream5Pro? value)
        {
            value = Seedream5Pro;
            return IsSeedream5Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestSeedream5Pro PickSeedream5Pro() => Seedream5Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedream5Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestSeedream5Lite? Seedream5Lite { get; init; }
#else
        public global::Runway.CreateTextToImageRequestSeedream5Lite? Seedream5Lite { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedream5Lite))]
#endif
        public bool IsSeedream5Lite => Seedream5Lite != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedream5Lite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestSeedream5Lite? value)
        {
            value = Seedream5Lite;
            return IsSeedream5Lite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestSeedream5Lite PickSeedream5Lite() => Seedream5Lite is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedream5Lite' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGrokImagineImage2? GrokImagineImage2 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGrokImagineImage2? GrokImagineImage2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GrokImagineImage2))]
#endif
        public bool IsGrokImagineImage2 => GrokImagineImage2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrokImagineImage2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGrokImagineImage2? value)
        {
            value = GrokImagineImage2;
            return IsGrokImagineImage2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGrokImagineImage2 PickGrokImagineImage2() => GrokImagineImage2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GrokImagineImage2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? GeminiImage31FlashLite { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? GeminiImage31FlashLite { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiImage31FlashLite))]
#endif
        public bool IsGeminiImage31FlashLite => GeminiImage31FlashLite != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiImage31FlashLite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? value)
        {
            value = GeminiImage31FlashLite;
            return IsGeminiImage31FlashLite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGeminiImage31FlashLite PickGeminiImage31FlashLite() => GeminiImage31FlashLite is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiImage31FlashLite' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGeminiImage3Pro? GeminiImage3Pro { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGeminiImage3Pro? GeminiImage3Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiImage3Pro))]
#endif
        public bool IsGeminiImage3Pro => GeminiImage3Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiImage3Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGeminiImage3Pro? value)
        {
            value = GeminiImage3Pro;
            return IsGeminiImage3Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGeminiImage3Pro PickGeminiImage3Pro() => GeminiImage3Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiImage3Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGptImage25Flare? GptImage25Flare { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGptImage25Flare? GptImage25Flare { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage25Flare))]
#endif
        public bool IsGptImage25Flare => GptImage25Flare != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage25Flare(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGptImage25Flare? value)
        {
            value = GptImage25Flare;
            return IsGptImage25Flare;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGptImage25Flare PickGptImage25Flare() => GptImage25Flare is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage25Flare' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGptImage25Sunburst? GptImage25Sunburst { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGptImage25Sunburst? GptImage25Sunburst { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage25Sunburst))]
#endif
        public bool IsGptImage25Sunburst => GptImage25Sunburst != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage25Sunburst(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGptImage25Sunburst? value)
        {
            value = GptImage25Sunburst;
            return IsGptImage25Sunburst;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGptImage25Sunburst PickGptImage25Sunburst() => GptImage25Sunburst is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage25Sunburst' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestBriaFibo15? BriaFibo15 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestBriaFibo15? BriaFibo15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BriaFibo15))]
#endif
        public bool IsBriaFibo15 => BriaFibo15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBriaFibo15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestBriaFibo15? value)
        {
            value = BriaFibo15;
            return IsBriaFibo15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestBriaFibo15 PickBriaFibo15() => BriaFibo15 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BriaFibo15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestBriaFiboEdit15? BriaFiboEdit15 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestBriaFiboEdit15? BriaFiboEdit15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BriaFiboEdit15))]
#endif
        public bool IsBriaFiboEdit15 => BriaFiboEdit15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBriaFiboEdit15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestBriaFiboEdit15? value)
        {
            value = BriaFiboEdit15;
            return IsBriaFiboEdit15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestBriaFiboEdit15 PickBriaFiboEdit15() => BriaFiboEdit15 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BriaFiboEdit15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestIdeogram40? Ideogram40 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestIdeogram40? Ideogram40 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ideogram40))]
#endif
        public bool IsIdeogram40 => Ideogram40 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdeogram40(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestIdeogram40? value)
        {
            value = Ideogram40;
            return IsIdeogram40;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestIdeogram40 PickIdeogram40() => Ideogram40 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ideogram40' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestIdeogram45? Ideogram45 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestIdeogram45? Ideogram45 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ideogram45))]
#endif
        public bool IsIdeogram45 => Ideogram45 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdeogram45(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestIdeogram45? value)
        {
            value = Ideogram45;
            return IsIdeogram45;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestIdeogram45 PickIdeogram45() => Ideogram45 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ideogram45' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestSeedream5Flash? Seedream5Flash { get; init; }
#else
        public global::Runway.CreateTextToImageRequestSeedream5Flash? Seedream5Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedream5Flash))]
#endif
        public bool IsSeedream5Flash => Seedream5Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedream5Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestSeedream5Flash? value)
        {
            value = Seedream5Flash;
            return IsSeedream5Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestSeedream5Flash PickSeedream5Flash() => Seedream5Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedream5Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestNanoBanana21? NanoBanana21 { get; init; }
#else
        public global::Runway.CreateTextToImageRequestNanoBanana21? NanoBanana21 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NanoBanana21))]
#endif
        public bool IsNanoBanana21 => NanoBanana21 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNanoBanana21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestNanoBanana21? value)
        {
            value = NanoBanana21;
            return IsNanoBanana21;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestNanoBanana21 PickNanoBanana21() => NanoBanana21 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NanoBanana21' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestRecraftV41Flash? RecraftV41Flash { get; init; }
#else
        public global::Runway.CreateTextToImageRequestRecraftV41Flash? RecraftV41Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecraftV41Flash))]
#endif
        public bool IsRecraftV41Flash => RecraftV41Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRecraftV41Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestRecraftV41Flash? value)
        {
            value = RecraftV41Flash;
            return IsRecraftV41Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestRecraftV41Flash PickRecraftV41Flash() => RecraftV41Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecraftV41Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestRecraftV41Vector? RecraftV41Vector { get; init; }
#else
        public global::Runway.CreateTextToImageRequestRecraftV41Vector? RecraftV41Vector { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecraftV41Vector))]
#endif
        public bool IsRecraftV41Vector => RecraftV41Vector != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRecraftV41Vector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestRecraftV41Vector? value)
        {
            value = RecraftV41Vector;
            return IsRecraftV41Vector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestRecraftV41Vector PickRecraftV41Vector() => RecraftV41Vector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecraftV41Vector' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGemini25Flash? Gemini25Flash { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGemini25Flash? Gemini25Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini25Flash))]
#endif
        public bool IsGemini25Flash => Gemini25Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini25Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGemini25Flash? value)
        {
            value = Gemini25Flash;
            return IsGemini25Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGemini25Flash PickGemini25Flash() => Gemini25Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini25Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGptImage26Flare? GptImage26Flare { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGptImage26Flare? GptImage26Flare { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage26Flare))]
#endif
        public bool IsGptImage26Flare => GptImage26Flare != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage26Flare(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGptImage26Flare? value)
        {
            value = GptImage26Flare;
            return IsGptImage26Flare;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGptImage26Flare PickGptImage26Flare() => GptImage26Flare is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage26Flare' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToImageRequestGptImage26Sunburst? GptImage26Sunburst { get; init; }
#else
        public global::Runway.CreateTextToImageRequestGptImage26Sunburst? GptImage26Sunburst { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage26Sunburst))]
#endif
        public bool IsGptImage26Sunburst => GptImage26Sunburst != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage26Sunburst(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToImageRequestGptImage26Sunburst? value)
        {
            value = GptImage26Sunburst;
            return IsGptImage26Sunburst;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateTextToImageRequestGptImage26Sunburst PickGptImage26Sunburst() => GptImage26Sunburst is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage26Sunburst' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGen4ImageTurbo value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGen4ImageTurbo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGen4ImageTurbo?(CreateTextToImageRequest @this) => @this.Gen4ImageTurbo;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGen4ImageTurbo? value)
        {
            Gen4ImageTurbo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGen4ImageTurbo(global::Runway.CreateTextToImageRequestGen4ImageTurbo? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGen4Image value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGen4Image?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGen4Image?(CreateTextToImageRequest @this) => @this.Gen4Image;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGen4Image? value)
        {
            Gen4Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGen4Image(global::Runway.CreateTextToImageRequestGen4Image? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage2 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGptImage2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGptImage2?(CreateTextToImageRequest @this) => @this.GptImage2;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage2? value)
        {
            GptImage2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGptImage2(global::Runway.CreateTextToImageRequestGptImage2? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage31Flash value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGeminiImage31Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGeminiImage31Flash?(CreateTextToImageRequest @this) => @this.GeminiImage31Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage31Flash? value)
        {
            GeminiImage31Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGeminiImage31Flash(global::Runway.CreateTextToImageRequestGeminiImage31Flash? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestMuseImage value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestMuseImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestMuseImage?(CreateTextToImageRequest @this) => @this.MuseImage;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestMuseImage? value)
        {
            MuseImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromMuseImage(global::Runway.CreateTextToImageRequestMuseImage? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Pro value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestSeedream5Pro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestSeedream5Pro?(CreateTextToImageRequest @this) => @this.Seedream5Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Pro? value)
        {
            Seedream5Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromSeedream5Pro(global::Runway.CreateTextToImageRequestSeedream5Pro? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Lite value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestSeedream5Lite?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestSeedream5Lite?(CreateTextToImageRequest @this) => @this.Seedream5Lite;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Lite? value)
        {
            Seedream5Lite = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromSeedream5Lite(global::Runway.CreateTextToImageRequestSeedream5Lite? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGrokImagineImage2 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGrokImagineImage2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGrokImagineImage2?(CreateTextToImageRequest @this) => @this.GrokImagineImage2;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGrokImagineImage2? value)
        {
            GrokImagineImage2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGrokImagineImage2(global::Runway.CreateTextToImageRequestGrokImagineImage2? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGeminiImage31FlashLite?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGeminiImage31FlashLite?(CreateTextToImageRequest @this) => @this.GeminiImage31FlashLite;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? value)
        {
            GeminiImage31FlashLite = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGeminiImage31FlashLite(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage3Pro value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGeminiImage3Pro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGeminiImage3Pro?(CreateTextToImageRequest @this) => @this.GeminiImage3Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGeminiImage3Pro? value)
        {
            GeminiImage3Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGeminiImage3Pro(global::Runway.CreateTextToImageRequestGeminiImage3Pro? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage25Flare value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGptImage25Flare?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGptImage25Flare?(CreateTextToImageRequest @this) => @this.GptImage25Flare;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage25Flare? value)
        {
            GptImage25Flare = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGptImage25Flare(global::Runway.CreateTextToImageRequestGptImage25Flare? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage25Sunburst value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGptImage25Sunburst?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGptImage25Sunburst?(CreateTextToImageRequest @this) => @this.GptImage25Sunburst;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage25Sunburst? value)
        {
            GptImage25Sunburst = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGptImage25Sunburst(global::Runway.CreateTextToImageRequestGptImage25Sunburst? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestBriaFibo15 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestBriaFibo15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestBriaFibo15?(CreateTextToImageRequest @this) => @this.BriaFibo15;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestBriaFibo15? value)
        {
            BriaFibo15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromBriaFibo15(global::Runway.CreateTextToImageRequestBriaFibo15? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestBriaFiboEdit15 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestBriaFiboEdit15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestBriaFiboEdit15?(CreateTextToImageRequest @this) => @this.BriaFiboEdit15;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestBriaFiboEdit15? value)
        {
            BriaFiboEdit15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromBriaFiboEdit15(global::Runway.CreateTextToImageRequestBriaFiboEdit15? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestIdeogram40 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestIdeogram40?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestIdeogram40?(CreateTextToImageRequest @this) => @this.Ideogram40;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestIdeogram40? value)
        {
            Ideogram40 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromIdeogram40(global::Runway.CreateTextToImageRequestIdeogram40? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestIdeogram45 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestIdeogram45?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestIdeogram45?(CreateTextToImageRequest @this) => @this.Ideogram45;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestIdeogram45? value)
        {
            Ideogram45 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromIdeogram45(global::Runway.CreateTextToImageRequestIdeogram45? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Flash value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestSeedream5Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestSeedream5Flash?(CreateTextToImageRequest @this) => @this.Seedream5Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestSeedream5Flash? value)
        {
            Seedream5Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromSeedream5Flash(global::Runway.CreateTextToImageRequestSeedream5Flash? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestNanoBanana21 value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestNanoBanana21?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestNanoBanana21?(CreateTextToImageRequest @this) => @this.NanoBanana21;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestNanoBanana21? value)
        {
            NanoBanana21 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromNanoBanana21(global::Runway.CreateTextToImageRequestNanoBanana21? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestRecraftV41Flash value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestRecraftV41Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestRecraftV41Flash?(CreateTextToImageRequest @this) => @this.RecraftV41Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestRecraftV41Flash? value)
        {
            RecraftV41Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromRecraftV41Flash(global::Runway.CreateTextToImageRequestRecraftV41Flash? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestRecraftV41Vector value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestRecraftV41Vector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestRecraftV41Vector?(CreateTextToImageRequest @this) => @this.RecraftV41Vector;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestRecraftV41Vector? value)
        {
            RecraftV41Vector = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromRecraftV41Vector(global::Runway.CreateTextToImageRequestRecraftV41Vector? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGemini25Flash value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGemini25Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGemini25Flash?(CreateTextToImageRequest @this) => @this.Gemini25Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGemini25Flash? value)
        {
            Gemini25Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGemini25Flash(global::Runway.CreateTextToImageRequestGemini25Flash? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage26Flare value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGptImage26Flare?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGptImage26Flare?(CreateTextToImageRequest @this) => @this.GptImage26Flare;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage26Flare? value)
        {
            GptImage26Flare = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGptImage26Flare(global::Runway.CreateTextToImageRequestGptImage26Flare? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage26Sunburst value) => new CreateTextToImageRequest((global::Runway.CreateTextToImageRequestGptImage26Sunburst?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateTextToImageRequestGptImage26Sunburst?(CreateTextToImageRequest @this) => @this.GptImage26Sunburst;

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(global::Runway.CreateTextToImageRequestGptImage26Sunburst? value)
        {
            GptImage26Sunburst = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTextToImageRequest FromGptImage26Sunburst(global::Runway.CreateTextToImageRequestGptImage26Sunburst? value) => new CreateTextToImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateTextToImageRequest(
            global::Runway.CreateTextToImageRequestDiscriminatorModel? model,
            global::Runway.CreateTextToImageRequestGen4ImageTurbo? gen4ImageTurbo,
            global::Runway.CreateTextToImageRequestGen4Image? gen4Image,
            global::Runway.CreateTextToImageRequestGptImage2? gptImage2,
            global::Runway.CreateTextToImageRequestGeminiImage31Flash? geminiImage31Flash,
            global::Runway.CreateTextToImageRequestMuseImage? museImage,
            global::Runway.CreateTextToImageRequestSeedream5Pro? seedream5Pro,
            global::Runway.CreateTextToImageRequestSeedream5Lite? seedream5Lite,
            global::Runway.CreateTextToImageRequestGrokImagineImage2? grokImagineImage2,
            global::Runway.CreateTextToImageRequestGeminiImage31FlashLite? geminiImage31FlashLite,
            global::Runway.CreateTextToImageRequestGeminiImage3Pro? geminiImage3Pro,
            global::Runway.CreateTextToImageRequestGptImage25Flare? gptImage25Flare,
            global::Runway.CreateTextToImageRequestGptImage25Sunburst? gptImage25Sunburst,
            global::Runway.CreateTextToImageRequestBriaFibo15? briaFibo15,
            global::Runway.CreateTextToImageRequestBriaFiboEdit15? briaFiboEdit15,
            global::Runway.CreateTextToImageRequestIdeogram40? ideogram40,
            global::Runway.CreateTextToImageRequestIdeogram45? ideogram45,
            global::Runway.CreateTextToImageRequestSeedream5Flash? seedream5Flash,
            global::Runway.CreateTextToImageRequestNanoBanana21? nanoBanana21,
            global::Runway.CreateTextToImageRequestRecraftV41Flash? recraftV41Flash,
            global::Runway.CreateTextToImageRequestRecraftV41Vector? recraftV41Vector,
            global::Runway.CreateTextToImageRequestGemini25Flash? gemini25Flash,
            global::Runway.CreateTextToImageRequestGptImage26Flare? gptImage26Flare,
            global::Runway.CreateTextToImageRequestGptImage26Sunburst? gptImage26Sunburst
            )
        {
            Model = model;

            Gen4ImageTurbo = gen4ImageTurbo;
            Gen4Image = gen4Image;
            GptImage2 = gptImage2;
            GeminiImage31Flash = geminiImage31Flash;
            MuseImage = museImage;
            Seedream5Pro = seedream5Pro;
            Seedream5Lite = seedream5Lite;
            GrokImagineImage2 = grokImagineImage2;
            GeminiImage31FlashLite = geminiImage31FlashLite;
            GeminiImage3Pro = geminiImage3Pro;
            GptImage25Flare = gptImage25Flare;
            GptImage25Sunburst = gptImage25Sunburst;
            BriaFibo15 = briaFibo15;
            BriaFiboEdit15 = briaFiboEdit15;
            Ideogram40 = ideogram40;
            Ideogram45 = ideogram45;
            Seedream5Flash = seedream5Flash;
            NanoBanana21 = nanoBanana21;
            RecraftV41Flash = recraftV41Flash;
            RecraftV41Vector = recraftV41Vector;
            Gemini25Flash = gemini25Flash;
            GptImage26Flare = gptImage26Flare;
            GptImage26Sunburst = gptImage26Sunburst;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GptImage26Sunburst as object ??
            GptImage26Flare as object ??
            Gemini25Flash as object ??
            RecraftV41Vector as object ??
            RecraftV41Flash as object ??
            NanoBanana21 as object ??
            Seedream5Flash as object ??
            Ideogram45 as object ??
            Ideogram40 as object ??
            BriaFiboEdit15 as object ??
            BriaFibo15 as object ??
            GptImage25Sunburst as object ??
            GptImage25Flare as object ??
            GeminiImage3Pro as object ??
            GeminiImage31FlashLite as object ??
            GrokImagineImage2 as object ??
            Seedream5Lite as object ??
            Seedream5Pro as object ??
            MuseImage as object ??
            GeminiImage31Flash as object ??
            GptImage2 as object ??
            Gen4Image as object ??
            Gen4ImageTurbo as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Gen4ImageTurbo?.ToString() ??
            Gen4Image?.ToString() ??
            GptImage2?.ToString() ??
            GeminiImage31Flash?.ToString() ??
            MuseImage?.ToString() ??
            Seedream5Pro?.ToString() ??
            Seedream5Lite?.ToString() ??
            GrokImagineImage2?.ToString() ??
            GeminiImage31FlashLite?.ToString() ??
            GeminiImage3Pro?.ToString() ??
            GptImage25Flare?.ToString() ??
            GptImage25Sunburst?.ToString() ??
            BriaFibo15?.ToString() ??
            BriaFiboEdit15?.ToString() ??
            Ideogram40?.ToString() ??
            Ideogram45?.ToString() ??
            Seedream5Flash?.ToString() ??
            NanoBanana21?.ToString() ??
            RecraftV41Flash?.ToString() ??
            RecraftV41Vector?.ToString() ??
            Gemini25Flash?.ToString() ??
            GptImage26Flare?.ToString() ??
            GptImage26Sunburst?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && IsGemini25Flash && !IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && IsGptImage26Flare && !IsGptImage26Sunburst || !IsGen4ImageTurbo && !IsGen4Image && !IsGptImage2 && !IsGeminiImage31Flash && !IsMuseImage && !IsSeedream5Pro && !IsSeedream5Lite && !IsGrokImagineImage2 && !IsGeminiImage31FlashLite && !IsGeminiImage3Pro && !IsGptImage25Flare && !IsGptImage25Sunburst && !IsBriaFibo15 && !IsBriaFiboEdit15 && !IsIdeogram40 && !IsIdeogram45 && !IsSeedream5Flash && !IsNanoBanana21 && !IsRecraftV41Flash && !IsRecraftV41Vector && !IsGemini25Flash && !IsGptImage26Flare && IsGptImage26Sunburst;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToImageRequestGen4ImageTurbo, TResult>? gen4ImageTurbo = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGen4Image, TResult>? gen4Image = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGptImage2, TResult>? gptImage2 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGeminiImage31Flash, TResult>? geminiImage31Flash = null,
            global::System.Func<global::Runway.CreateTextToImageRequestMuseImage, TResult>? museImage = null,
            global::System.Func<global::Runway.CreateTextToImageRequestSeedream5Pro, TResult>? seedream5Pro = null,
            global::System.Func<global::Runway.CreateTextToImageRequestSeedream5Lite, TResult>? seedream5Lite = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGrokImagineImage2, TResult>? grokImagineImage2 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite, TResult>? geminiImage31FlashLite = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGeminiImage3Pro, TResult>? geminiImage3Pro = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGptImage25Flare, TResult>? gptImage25Flare = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGptImage25Sunburst, TResult>? gptImage25Sunburst = null,
            global::System.Func<global::Runway.CreateTextToImageRequestBriaFibo15, TResult>? briaFibo15 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestBriaFiboEdit15, TResult>? briaFiboEdit15 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestIdeogram40, TResult>? ideogram40 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestIdeogram45, TResult>? ideogram45 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestSeedream5Flash, TResult>? seedream5Flash = null,
            global::System.Func<global::Runway.CreateTextToImageRequestNanoBanana21, TResult>? nanoBanana21 = null,
            global::System.Func<global::Runway.CreateTextToImageRequestRecraftV41Flash, TResult>? recraftV41Flash = null,
            global::System.Func<global::Runway.CreateTextToImageRequestRecraftV41Vector, TResult>? recraftV41Vector = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGemini25Flash, TResult>? gemini25Flash = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGptImage26Flare, TResult>? gptImage26Flare = null,
            global::System.Func<global::Runway.CreateTextToImageRequestGptImage26Sunburst, TResult>? gptImage26Sunburst = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen4ImageTurbo is { } __value0 && gen4ImageTurbo != null)
            {
                return gen4ImageTurbo(__value0);
            }
            else if (Gen4Image is { } __value1 && gen4Image != null)
            {
                return gen4Image(__value1);
            }
            else if (GptImage2 is { } __value2 && gptImage2 != null)
            {
                return gptImage2(__value2);
            }
            else if (GeminiImage31Flash is { } __value3 && geminiImage31Flash != null)
            {
                return geminiImage31Flash(__value3);
            }
            else if (MuseImage is { } __value4 && museImage != null)
            {
                return museImage(__value4);
            }
            else if (Seedream5Pro is { } __value5 && seedream5Pro != null)
            {
                return seedream5Pro(__value5);
            }
            else if (Seedream5Lite is { } __value6 && seedream5Lite != null)
            {
                return seedream5Lite(__value6);
            }
            else if (GrokImagineImage2 is { } __value7 && grokImagineImage2 != null)
            {
                return grokImagineImage2(__value7);
            }
            else if (GeminiImage31FlashLite is { } __value8 && geminiImage31FlashLite != null)
            {
                return geminiImage31FlashLite(__value8);
            }
            else if (GeminiImage3Pro is { } __value9 && geminiImage3Pro != null)
            {
                return geminiImage3Pro(__value9);
            }
            else if (GptImage25Flare is { } __value10 && gptImage25Flare != null)
            {
                return gptImage25Flare(__value10);
            }
            else if (GptImage25Sunburst is { } __value11 && gptImage25Sunburst != null)
            {
                return gptImage25Sunburst(__value11);
            }
            else if (BriaFibo15 is { } __value12 && briaFibo15 != null)
            {
                return briaFibo15(__value12);
            }
            else if (BriaFiboEdit15 is { } __value13 && briaFiboEdit15 != null)
            {
                return briaFiboEdit15(__value13);
            }
            else if (Ideogram40 is { } __value14 && ideogram40 != null)
            {
                return ideogram40(__value14);
            }
            else if (Ideogram45 is { } __value15 && ideogram45 != null)
            {
                return ideogram45(__value15);
            }
            else if (Seedream5Flash is { } __value16 && seedream5Flash != null)
            {
                return seedream5Flash(__value16);
            }
            else if (NanoBanana21 is { } __value17 && nanoBanana21 != null)
            {
                return nanoBanana21(__value17);
            }
            else if (RecraftV41Flash is { } __value18 && recraftV41Flash != null)
            {
                return recraftV41Flash(__value18);
            }
            else if (RecraftV41Vector is { } __value19 && recraftV41Vector != null)
            {
                return recraftV41Vector(__value19);
            }
            else if (Gemini25Flash is { } __value20 && gemini25Flash != null)
            {
                return gemini25Flash(__value20);
            }
            else if (GptImage26Flare is { } __value21 && gptImage26Flare != null)
            {
                return gptImage26Flare(__value21);
            }
            else if (GptImage26Sunburst is { } __value22 && gptImage26Sunburst != null)
            {
                return gptImage26Sunburst(__value22);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToImageRequestGen4ImageTurbo>? gen4ImageTurbo = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGen4Image>? gen4Image = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGptImage2>? gptImage2 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage31Flash>? geminiImage31Flash = null,

            global::System.Action<global::Runway.CreateTextToImageRequestMuseImage>? museImage = null,

            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Pro>? seedream5Pro = null,

            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Lite>? seedream5Lite = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGrokImagineImage2>? grokImagineImage2 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite>? geminiImage31FlashLite = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage3Pro>? geminiImage3Pro = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGptImage25Flare>? gptImage25Flare = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGptImage25Sunburst>? gptImage25Sunburst = null,

            global::System.Action<global::Runway.CreateTextToImageRequestBriaFibo15>? briaFibo15 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestBriaFiboEdit15>? briaFiboEdit15 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestIdeogram40>? ideogram40 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestIdeogram45>? ideogram45 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Flash>? seedream5Flash = null,

            global::System.Action<global::Runway.CreateTextToImageRequestNanoBanana21>? nanoBanana21 = null,

            global::System.Action<global::Runway.CreateTextToImageRequestRecraftV41Flash>? recraftV41Flash = null,

            global::System.Action<global::Runway.CreateTextToImageRequestRecraftV41Vector>? recraftV41Vector = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGemini25Flash>? gemini25Flash = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGptImage26Flare>? gptImage26Flare = null,

            global::System.Action<global::Runway.CreateTextToImageRequestGptImage26Sunburst>? gptImage26Sunburst = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen4ImageTurbo is { } __value0)
            {
                gen4ImageTurbo?.Invoke(__value0);
            }
            else if (Gen4Image is { } __value1)
            {
                gen4Image?.Invoke(__value1);
            }
            else if (GptImage2 is { } __value2)
            {
                gptImage2?.Invoke(__value2);
            }
            else if (GeminiImage31Flash is { } __value3)
            {
                geminiImage31Flash?.Invoke(__value3);
            }
            else if (MuseImage is { } __value4)
            {
                museImage?.Invoke(__value4);
            }
            else if (Seedream5Pro is { } __value5)
            {
                seedream5Pro?.Invoke(__value5);
            }
            else if (Seedream5Lite is { } __value6)
            {
                seedream5Lite?.Invoke(__value6);
            }
            else if (GrokImagineImage2 is { } __value7)
            {
                grokImagineImage2?.Invoke(__value7);
            }
            else if (GeminiImage31FlashLite is { } __value8)
            {
                geminiImage31FlashLite?.Invoke(__value8);
            }
            else if (GeminiImage3Pro is { } __value9)
            {
                geminiImage3Pro?.Invoke(__value9);
            }
            else if (GptImage25Flare is { } __value10)
            {
                gptImage25Flare?.Invoke(__value10);
            }
            else if (GptImage25Sunburst is { } __value11)
            {
                gptImage25Sunburst?.Invoke(__value11);
            }
            else if (BriaFibo15 is { } __value12)
            {
                briaFibo15?.Invoke(__value12);
            }
            else if (BriaFiboEdit15 is { } __value13)
            {
                briaFiboEdit15?.Invoke(__value13);
            }
            else if (Ideogram40 is { } __value14)
            {
                ideogram40?.Invoke(__value14);
            }
            else if (Ideogram45 is { } __value15)
            {
                ideogram45?.Invoke(__value15);
            }
            else if (Seedream5Flash is { } __value16)
            {
                seedream5Flash?.Invoke(__value16);
            }
            else if (NanoBanana21 is { } __value17)
            {
                nanoBanana21?.Invoke(__value17);
            }
            else if (RecraftV41Flash is { } __value18)
            {
                recraftV41Flash?.Invoke(__value18);
            }
            else if (RecraftV41Vector is { } __value19)
            {
                recraftV41Vector?.Invoke(__value19);
            }
            else if (Gemini25Flash is { } __value20)
            {
                gemini25Flash?.Invoke(__value20);
            }
            else if (GptImage26Flare is { } __value21)
            {
                gptImage26Flare?.Invoke(__value21);
            }
            else if (GptImage26Sunburst is { } __value22)
            {
                gptImage26Sunburst?.Invoke(__value22);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToImageRequestGen4ImageTurbo>? gen4ImageTurbo = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGen4Image>? gen4Image = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGptImage2>? gptImage2 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage31Flash>? geminiImage31Flash = null,
            global::System.Action<global::Runway.CreateTextToImageRequestMuseImage>? museImage = null,
            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Pro>? seedream5Pro = null,
            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Lite>? seedream5Lite = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGrokImagineImage2>? grokImagineImage2 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite>? geminiImage31FlashLite = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGeminiImage3Pro>? geminiImage3Pro = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGptImage25Flare>? gptImage25Flare = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGptImage25Sunburst>? gptImage25Sunburst = null,
            global::System.Action<global::Runway.CreateTextToImageRequestBriaFibo15>? briaFibo15 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestBriaFiboEdit15>? briaFiboEdit15 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestIdeogram40>? ideogram40 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestIdeogram45>? ideogram45 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestSeedream5Flash>? seedream5Flash = null,
            global::System.Action<global::Runway.CreateTextToImageRequestNanoBanana21>? nanoBanana21 = null,
            global::System.Action<global::Runway.CreateTextToImageRequestRecraftV41Flash>? recraftV41Flash = null,
            global::System.Action<global::Runway.CreateTextToImageRequestRecraftV41Vector>? recraftV41Vector = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGemini25Flash>? gemini25Flash = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGptImage26Flare>? gptImage26Flare = null,
            global::System.Action<global::Runway.CreateTextToImageRequestGptImage26Sunburst>? gptImage26Sunburst = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen4ImageTurbo is { } __value0)
            {
                gen4ImageTurbo?.Invoke(__value0);
            }
            else if (Gen4Image is { } __value1)
            {
                gen4Image?.Invoke(__value1);
            }
            else if (GptImage2 is { } __value2)
            {
                gptImage2?.Invoke(__value2);
            }
            else if (GeminiImage31Flash is { } __value3)
            {
                geminiImage31Flash?.Invoke(__value3);
            }
            else if (MuseImage is { } __value4)
            {
                museImage?.Invoke(__value4);
            }
            else if (Seedream5Pro is { } __value5)
            {
                seedream5Pro?.Invoke(__value5);
            }
            else if (Seedream5Lite is { } __value6)
            {
                seedream5Lite?.Invoke(__value6);
            }
            else if (GrokImagineImage2 is { } __value7)
            {
                grokImagineImage2?.Invoke(__value7);
            }
            else if (GeminiImage31FlashLite is { } __value8)
            {
                geminiImage31FlashLite?.Invoke(__value8);
            }
            else if (GeminiImage3Pro is { } __value9)
            {
                geminiImage3Pro?.Invoke(__value9);
            }
            else if (GptImage25Flare is { } __value10)
            {
                gptImage25Flare?.Invoke(__value10);
            }
            else if (GptImage25Sunburst is { } __value11)
            {
                gptImage25Sunburst?.Invoke(__value11);
            }
            else if (BriaFibo15 is { } __value12)
            {
                briaFibo15?.Invoke(__value12);
            }
            else if (BriaFiboEdit15 is { } __value13)
            {
                briaFiboEdit15?.Invoke(__value13);
            }
            else if (Ideogram40 is { } __value14)
            {
                ideogram40?.Invoke(__value14);
            }
            else if (Ideogram45 is { } __value15)
            {
                ideogram45?.Invoke(__value15);
            }
            else if (Seedream5Flash is { } __value16)
            {
                seedream5Flash?.Invoke(__value16);
            }
            else if (NanoBanana21 is { } __value17)
            {
                nanoBanana21?.Invoke(__value17);
            }
            else if (RecraftV41Flash is { } __value18)
            {
                recraftV41Flash?.Invoke(__value18);
            }
            else if (RecraftV41Vector is { } __value19)
            {
                recraftV41Vector?.Invoke(__value19);
            }
            else if (Gemini25Flash is { } __value20)
            {
                gemini25Flash?.Invoke(__value20);
            }
            else if (GptImage26Flare is { } __value21)
            {
                gptImage26Flare?.Invoke(__value21);
            }
            else if (GptImage26Sunburst is { } __value22)
            {
                gptImage26Sunburst?.Invoke(__value22);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gen4ImageTurbo,
                typeof(global::Runway.CreateTextToImageRequestGen4ImageTurbo),
                Gen4Image,
                typeof(global::Runway.CreateTextToImageRequestGen4Image),
                GptImage2,
                typeof(global::Runway.CreateTextToImageRequestGptImage2),
                GeminiImage31Flash,
                typeof(global::Runway.CreateTextToImageRequestGeminiImage31Flash),
                MuseImage,
                typeof(global::Runway.CreateTextToImageRequestMuseImage),
                Seedream5Pro,
                typeof(global::Runway.CreateTextToImageRequestSeedream5Pro),
                Seedream5Lite,
                typeof(global::Runway.CreateTextToImageRequestSeedream5Lite),
                GrokImagineImage2,
                typeof(global::Runway.CreateTextToImageRequestGrokImagineImage2),
                GeminiImage31FlashLite,
                typeof(global::Runway.CreateTextToImageRequestGeminiImage31FlashLite),
                GeminiImage3Pro,
                typeof(global::Runway.CreateTextToImageRequestGeminiImage3Pro),
                GptImage25Flare,
                typeof(global::Runway.CreateTextToImageRequestGptImage25Flare),
                GptImage25Sunburst,
                typeof(global::Runway.CreateTextToImageRequestGptImage25Sunburst),
                BriaFibo15,
                typeof(global::Runway.CreateTextToImageRequestBriaFibo15),
                BriaFiboEdit15,
                typeof(global::Runway.CreateTextToImageRequestBriaFiboEdit15),
                Ideogram40,
                typeof(global::Runway.CreateTextToImageRequestIdeogram40),
                Ideogram45,
                typeof(global::Runway.CreateTextToImageRequestIdeogram45),
                Seedream5Flash,
                typeof(global::Runway.CreateTextToImageRequestSeedream5Flash),
                NanoBanana21,
                typeof(global::Runway.CreateTextToImageRequestNanoBanana21),
                RecraftV41Flash,
                typeof(global::Runway.CreateTextToImageRequestRecraftV41Flash),
                RecraftV41Vector,
                typeof(global::Runway.CreateTextToImageRequestRecraftV41Vector),
                Gemini25Flash,
                typeof(global::Runway.CreateTextToImageRequestGemini25Flash),
                GptImage26Flare,
                typeof(global::Runway.CreateTextToImageRequestGptImage26Flare),
                GptImage26Sunburst,
                typeof(global::Runway.CreateTextToImageRequestGptImage26Sunburst),
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
        public bool Equals(CreateTextToImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGen4ImageTurbo?>.Default.Equals(Gen4ImageTurbo, other.Gen4ImageTurbo) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGen4Image?>.Default.Equals(Gen4Image, other.Gen4Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGptImage2?>.Default.Equals(GptImage2, other.GptImage2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGeminiImage31Flash?>.Default.Equals(GeminiImage31Flash, other.GeminiImage31Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestMuseImage?>.Default.Equals(MuseImage, other.MuseImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestSeedream5Pro?>.Default.Equals(Seedream5Pro, other.Seedream5Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestSeedream5Lite?>.Default.Equals(Seedream5Lite, other.Seedream5Lite) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGrokImagineImage2?>.Default.Equals(GrokImagineImage2, other.GrokImagineImage2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGeminiImage31FlashLite?>.Default.Equals(GeminiImage31FlashLite, other.GeminiImage31FlashLite) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGeminiImage3Pro?>.Default.Equals(GeminiImage3Pro, other.GeminiImage3Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGptImage25Flare?>.Default.Equals(GptImage25Flare, other.GptImage25Flare) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGptImage25Sunburst?>.Default.Equals(GptImage25Sunburst, other.GptImage25Sunburst) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestBriaFibo15?>.Default.Equals(BriaFibo15, other.BriaFibo15) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestBriaFiboEdit15?>.Default.Equals(BriaFiboEdit15, other.BriaFiboEdit15) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestIdeogram40?>.Default.Equals(Ideogram40, other.Ideogram40) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestIdeogram45?>.Default.Equals(Ideogram45, other.Ideogram45) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestSeedream5Flash?>.Default.Equals(Seedream5Flash, other.Seedream5Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestNanoBanana21?>.Default.Equals(NanoBanana21, other.NanoBanana21) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestRecraftV41Flash?>.Default.Equals(RecraftV41Flash, other.RecraftV41Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestRecraftV41Vector?>.Default.Equals(RecraftV41Vector, other.RecraftV41Vector) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGemini25Flash?>.Default.Equals(Gemini25Flash, other.Gemini25Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGptImage26Flare?>.Default.Equals(GptImage26Flare, other.GptImage26Flare) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToImageRequestGptImage26Sunburst?>.Default.Equals(GptImage26Sunburst, other.GptImage26Sunburst)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateTextToImageRequest obj1, CreateTextToImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateTextToImageRequest obj1, CreateTextToImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToImageRequest o && Equals(o);
        }
    }
}

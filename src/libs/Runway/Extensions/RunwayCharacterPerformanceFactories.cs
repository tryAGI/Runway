namespace Runway;

/// <summary>
/// Short-named factory helpers for the <see cref="Character"/> discriminated union used by
/// <c>POST /v1/character_performance</c>. Wraps the verbose
/// <c>CreateCharacterPerformanceRequestActTwoCharacterCharacterImage</c> /
/// <c>...CharacterVideo</c> request shapes.
/// </summary>
public static class RunwayCharacters
{
    /// <summary>
    /// Wraps a static character image (HTTPS URL, Runway URI, or data URI) into the <see cref="Character"/> union.
    /// </summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static Character Image(string uri)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(uri);

        return new Character(new CreateCharacterPerformanceRequestActTwoCharacterCharacterImage
        {
            Uri = uri,
        });
    }

    /// <summary>
    /// Wraps a character video (HTTPS URL, Runway URI, or data URI) into the <see cref="Character"/> union.
    /// </summary>
#pragma warning disable CA1054
    public static Character Video(string uri)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(uri);

        return new Character(new CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo
        {
            Uri = uri,
        });
    }
}

/// <summary>
/// Short-named factory helpers for <c>POST /v1/character_performance</c> request bodies.
/// </summary>
public static class RunwayCharacterPerformance
{
    /// <summary>
    /// Builds an <c>act_two</c> character-performance request from a character (use
    /// <see cref="RunwayCharacters.Image"/> or <see cref="RunwayCharacters.Video"/>) and a reference
    /// performance video URI.
    /// </summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static CreateCharacterPerformanceRequest ActTwo(
        Character character,
        string referenceVideoUri,
        CreateCharacterPerformanceRequestActTwoRatio? ratio = null,
        bool? bodyControl = null,
        int? expressionIntensity = null,
        int? seed = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(referenceVideoUri);

        return new CreateCharacterPerformanceRequest(new CreateCharacterPerformanceRequestActTwo
        {
            Character = character,
            Reference = new CreateCharacterPerformanceRequestActTwoReferenceCharacterReferenceVideo
            {
                Uri = referenceVideoUri,
            },
            Ratio = ratio,
            BodyControl = bodyControl,
            ExpressionIntensity = expressionIntensity,
            Seed = seed,
        });
    }
}

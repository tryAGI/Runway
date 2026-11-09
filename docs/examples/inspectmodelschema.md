# InspectModelSchema



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var imageToVideo = RunwayModelSchema.Lookup("gen4_turbo");

var multiEndpoint = RunwayModelSchema.Lookup("veo3.1_fast");

var gptImage = RunwayModelSchema.Lookup("gpt_image_2");

var withDash = RunwayModelSchema.Lookup("gen4-turbo");

var unknown = RunwayModelSchema.Lookup("definitely_not_a_runway_model");

var known = RunwayModelSchema.KnownModelIds().ToList();

// EnsureModelSupportsEndpoint catches mismatches against the spec.
var rejection = Action(() => RunwayModelSchema.EnsureModelSupportsEndpoint("gpt_image_2", "text_to_video"));

// Correct pairing passes silently.
Action(() => RunwayModelSchema.EnsureModelSupportsEndpoint("gpt_image_2", "text_to_image"))

// Unknown models are allowed through (so brand-new spec entries work without a CLI release).
Action(() => RunwayModelSchema.EnsureModelSupportsEndpoint("future_model_id", "text_to_image"))

// EnsureRequiredParametersProvided complains when a spec-required param is marked missing,
// and translates spec property names to the CLI flag the user should add.
var missingPromptImage = Action(() => RunwayModelSchema.EnsureRequiredParametersProvided(
    "gen4_turbo",
    "image_to_video",
    new Dictionary<string, bool>
    {
        ["promptImage"] = false,
        ["ratio"] = true,
    }));
    .WithMessage("*requires promptImage (--image)*");

// DescribeRequiredParam annotates known spec params with their CLI flag.
// Unknown spec params fall through to bare name.

// Spec param the caller didn't list is not enforced (CLI doesn't track every flag).
Action(() => RunwayModelSchema.EnsureRequiredParametersProvided(
    "gen4_image_turbo",
    "text_to_image",
    new Dictionary<string, bool>
    {
        ["promptText"] = true,
        // ratio + referenceImages omitted -> not enforced
    }))

// All required flags satisfied -> passes silently.
Action(() => RunwayModelSchema.EnsureRequiredParametersProvided(
    "veo3.1_fast",
    "text_to_video",
    new Dictionary<string, bool>
    {
        ["promptText"] = true,
        ["ratio"] = true,
    }))

// Unknown model -> passes silently (brand-new spec entries don't break the CLI).
Action(() => RunwayModelSchema.EnsureRequiredParametersProvided(
    "future_unknown_model",
    "text_to_image",
    new Dictionary<string, bool>()))

static Action Action(Action action) => action;
```
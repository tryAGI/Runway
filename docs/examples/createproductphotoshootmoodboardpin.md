# CreateProductPhotoshootMoodboardPin



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
    prompt: "compact ceramic pour-over coffee mug",
    referenceImages: null,
    count: null,
    ratio: null,
    model: null,
    mode: "moodboard_pin",
    productContext: "slow-living lifestyle accessory",
    brandContext: "warm, neutral palette",
    quality: null,
    resolution: null);

var job = plan.Jobs[0];

var json = RunwayCliCreativeRecipes.ToJson(plan);
```
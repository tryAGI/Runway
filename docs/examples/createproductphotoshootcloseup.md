# CreateProductPhotoshootCloseup



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
    prompt: "wireless earbud charging case with brushed aluminum finish",
    referenceImages: null,
    count: null,
    ratio: null,
    model: null,
    mode: "closeup_product_with_person",
    productContext: "premium audio accessory targeted at on-the-go professionals",
    brandContext: "minimal Scandinavian design language",
    quality: null,
    resolution: null);

var job = plan.Jobs[0];

var json = RunwayCliCreativeRecipes.ToJson(plan);
```
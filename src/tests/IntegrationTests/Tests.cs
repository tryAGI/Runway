namespace Runway.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RunwayClient GetAuthenticatedClient()
    {
        var apiKey =
            RunwayEnvironment.GetApiKey() is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RUNWAY_API_KEY, RUNWAYML_API_SECRET, or .env API key is not found.");
    
        var client = new RunwayClient(apiKey);
        
        return client;
    }
}

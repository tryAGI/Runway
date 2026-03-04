namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImageToVideo()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateImageToVideoAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestVariant3
            {
                PromptImage = new AnyOf<AnyOf<string, string, string>?, IList<RequestVariant3PromptImageVariant2Item>>
                {
                    Value1 = new AnyOf<string, string, string>
                    {
                        Value1 = "https://img.freepik.com/free-photo/beautiful-woman-with-long-blond-hair-looking-camera-outdoors-generated-by-artificial-intelligence_188544-240170.jpg",
                    },
                },
                PromptText = "The girl smiles a little",
                Seed = 999999999,
                Model = "gen3a_turbo",
                Duration = 5,
                Ratio = RequestVariant3Ratio.x1280_768,
            });
        response.Id.Should().NotBe(default(Guid));

        Response taskDetail;
        do
        {
            taskDetail = await client.TaskManagement.GetTasksByIdAsync(
                id: response.Id,
                xRunwayVersion: "2024-11-06");

            if (taskDetail.IsValue4)
            {
                Console.WriteLine($"Progress: {taskDetail.Value4!.Progress}");
            }

            await Task.Delay(TimeSpan.FromSeconds(10));
        }
        while (!taskDetail.IsValue5 && !taskDetail.IsValue6 && !taskDetail.IsValue3);

        if (taskDetail.IsValue6)
        {
            Console.WriteLine($"Task ID: {taskDetail.Value6!.Id}");
            Console.WriteLine($"Task Status: {taskDetail.Value6.Status}");
            Console.WriteLine($"CreatedAt: {taskDetail.Value6.CreatedAt}");

            foreach (var output in taskDetail.Value6.Output)
            {
                Console.WriteLine($"Video URL: {output}");
            }
        }
        else if (taskDetail.IsValue5)
        {
            Console.WriteLine($"Task ID: {taskDetail.Value5!.Id}");
            Console.WriteLine($"Task Status: {taskDetail.Value5.Status}");
            Console.WriteLine($"Failure: {taskDetail.Value5.Failure}");
            Console.WriteLine($"FailureCode: {taskDetail.Value5.FailureCode}");
        }

        taskDetail.IsValue6.Should().BeTrue();
        taskDetail.Value6!.Output.Should().NotBeNullOrEmpty();
    }
}

namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateImageToVideo()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.CreateVideoFromImageAsync(
            xRunwayVersion: CreateVideoFromImageXRunwayVersion.x20240913,
            promptImage: "https://img.freepik.com/free-photo/beautiful-woman-with-long-blond-hair-looking-camera-outdoors-generated-by-artificial-intelligence_188544-240170.jpg",
            seed: 999999999,
            model: CreateVideoFromImageRequestModel.Gen3aTurbo,
            promptText: "The girl smiles a little",
            watermark: false,
            duration: 5,
            ratio: CreateVideoFromImageRequestRatio.x16_9);
        response.Id.Should().NotBe(default(Guid)); 

        GetTaskDetailResponse taskDetail;
        do
        {
            taskDetail = await client.GetTaskDetailAsync(GetTaskDetailXRunwayVersion.x20240913, response.Id);
            
            Console.WriteLine($"Progress: {taskDetail.Progress}");
            
            await Task.Delay(TimeSpan.FromSeconds(10));
        }
        while (taskDetail.Status != GetTaskDetailResponseStatus.FAILED &&
               taskDetail.Status != GetTaskDetailResponseStatus.SUCCEEDED &&
               taskDetail.Status != GetTaskDetailResponseStatus.CANCELLED);

        Console.WriteLine($"Task ID: {taskDetail.Id}");
        Console.WriteLine($"Task Status: {taskDetail.Status}");
        Console.WriteLine($"CreatedAt: {taskDetail.CreatedAt}");
        Console.WriteLine($"Failure: {taskDetail.Failure}");
        Console.WriteLine($"FailureCode: {taskDetail.FailureCode}");
        Console.WriteLine($"Progress: {taskDetail.Progress}");
        
        foreach (var output in taskDetail.Output ?? [])
        {
            Console.WriteLine($"Video URL: {output}");
        }
        
        taskDetail.Status.Should().Be(GetTaskDetailResponseStatus.SUCCEEDED);
        taskDetail.Output.Should().NotBeNullOrEmpty();
    }
}

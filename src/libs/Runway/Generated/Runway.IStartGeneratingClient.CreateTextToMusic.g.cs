#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Generate music<br/>
        /// This endpoint will start a new task to generate a song or instrumental track from a text description.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.textToMusic<br/>
        ///   .create({<br/>
        ///     model: 'eleven_music_v2_5',<br/>
        ///     promptText: 'An upbeat synthwave track with driving drums and a soaring lead synth',<br/>
        ///     duration: 60,<br/>
        ///     instrumental: true,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateTextToMusicResponse> CreateTextToMusicAsync(

            global::Runway.CreateTextToMusicRequest request,
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate music<br/>
        /// This endpoint will start a new task to generate a song or instrumental track from a text description.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.textToMusic<br/>
        ///   .create({<br/>
        ///     model: 'eleven_music_v2_5',<br/>
        ///     promptText: 'An upbeat synthwave track with driving drums and a soaring lead synth',<br/>
        ///     duration: 60,<br/>
        ///     instrumental: true,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateTextToMusicResponse>> CreateTextToMusicAsResponseAsync(

            global::Runway.CreateTextToMusicRequest request,
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate music<br/>
        /// This endpoint will start a new task to generate a song or instrumental track from a text description.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateTextToMusicResponse> CreateTextToMusicAsync(
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
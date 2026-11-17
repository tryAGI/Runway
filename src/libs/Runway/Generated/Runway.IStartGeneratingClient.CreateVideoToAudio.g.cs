#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Generate audio from a video<br/>
        /// Generate synchronized sound effects for a video, optionally guided by a text description. Returns audio, not a video with a replacement soundtrack.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// const response = await fetch('https://api.dev.runwayml.com/v1/video_to_audio', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: 'Bearer ' + process.env.RUNWAYML_API_SECRET,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///     'X-Runway-Version': '2024-11-06',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     model: 'mirelo_sfx_2_0',<br/>
        ///     videoUri: 'https://example.com/video.mp4',<br/>
        ///     duration: 5,<br/>
        ///     preserveSpeech: false,<br/>
        ///   }),<br/>
        /// });<br/>
        /// console.log(await response.json());
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateVideoToAudioResponse> CreateVideoToAudioAsync(

            global::Runway.CreateVideoToAudioRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate audio from a video<br/>
        /// Generate synchronized sound effects for a video, optionally guided by a text description. Returns audio, not a video with a replacement soundtrack.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// const response = await fetch('https://api.dev.runwayml.com/v1/video_to_audio', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: 'Bearer ' + process.env.RUNWAYML_API_SECRET,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///     'X-Runway-Version': '2024-11-06',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     model: 'mirelo_sfx_2_0',<br/>
        ///     videoUri: 'https://example.com/video.mp4',<br/>
        ///     duration: 5,<br/>
        ///     preserveSpeech: false,<br/>
        ///   }),<br/>
        /// });<br/>
        /// console.log(await response.json());
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateVideoToAudioResponse>> CreateVideoToAudioAsResponseAsync(

            global::Runway.CreateVideoToAudioRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate audio from a video<br/>
        /// Generate synchronized sound effects for a video, optionally guided by a text description. Returns audio, not a video with a replacement soundtrack.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateVideoToAudioResponse> CreateVideoToAudioAsync(
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
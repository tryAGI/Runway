#nullable enable

namespace Runway
{
    public partial interface IAvatarVideosClient
    {
        /// <summary>
        /// Generate avatar video from audio or text<br/>
        /// Start an asynchronous task to generate a video of an avatar speaking. Provide `speech` with `type: "audio"` (audio file) or `type: "text"` (text script for TTS). Poll `GET /v1/tasks/:id` to check progress and retrieve the output video URL once complete.
        /// </summary>
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
        /// const task = await client.avatarVideos<br/>
        ///   .create({<br/>
        ///     model: 'gwm1_avatars',<br/>
        ///     avatar: {<br/>
        ///       type: 'runway-preset',<br/>
        ///       presetId: 'influencer',<br/>
        ///     },<br/>
        ///     speech: {<br/>
        ///       type: 'text',<br/>
        ///       text: 'Welcome to Runway! I can help you create amazing videos.',<br/>
        ///       voice: { type: 'preset', presetId: 'clara' },<br/>
        ///     },<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateAvatarVideosResponse> CreateAvatarVideosAsync(

            global::Runway.CreateAvatarVideosRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate avatar video from audio or text<br/>
        /// Start an asynchronous task to generate a video of an avatar speaking. Provide `speech` with `type: "audio"` (audio file) or `type: "text"` (text script for TTS). Poll `GET /v1/tasks/:id` to check progress and retrieve the output video URL once complete.
        /// </summary>
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
        /// const task = await client.avatarVideos<br/>
        ///   .create({<br/>
        ///     model: 'gwm1_avatars',<br/>
        ///     avatar: {<br/>
        ///       type: 'runway-preset',<br/>
        ///       presetId: 'influencer',<br/>
        ///     },<br/>
        ///     speech: {<br/>
        ///       type: 'text',<br/>
        ///       text: 'Welcome to Runway! I can help you create amazing videos.',<br/>
        ///       voice: { type: 'preset', presetId: 'clara' },<br/>
        ///     },<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateAvatarVideosResponse>> CreateAvatarVideosAsResponseAsync(

            global::Runway.CreateAvatarVideosRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate avatar video from audio or text<br/>
        /// Start an asynchronous task to generate a video of an avatar speaking. Provide `speech` with `type: "audio"` (audio file) or `type: "text"` (text script for TTS). Poll `GET /v1/tasks/:id` to check progress and retrieve the output video URL once complete.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="model">
        /// The model to use for avatar video generation.
        /// </param>
        /// <param name="avatar">
        /// The avatar configuration for the session.
        /// </param>
        /// <param name="speech">
        /// The speech source for avatar video generation. Either an audio file or text script.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateAvatarVideosResponse> CreateAvatarVideosAsync(
            global::Runway.Avatar avatar,
            global::Runway.Speech speech,
            string xRunwayVersion = "2024-11-06",
            string model = "gwm1_avatars",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
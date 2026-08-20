#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Video to HDR<br/>
        /// This endpoint starts a task to upconvert an SDR video to true HDR with Ruby, Runway's HDR grading model. The output keeps the source's own pixels — luma and color are extended into the HDR range, nothing is re-synthesized. Set `outputFormat` to choose the delivery profile: `hdr10` (HEVC Main 10, BT.2020 + PQ, the default), `hlg` (HEVC Main 10, BT.2020 + HLG), `hdr_prores` (BT.2020 + PQ ProRes .mov editorial mezzanine, tier selectable with `proresProfile`), or `hdr_exr_sequence` (a .zip of half-float OpenEXR frames in linear BT.2020 display light, for compositing). Tasks bill per second of output at 20 credits per second, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K) — an upconvert delivers at the source's own resolution.
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
        /// const task = await client.videoToHdr<br/>
        ///   .create({<br/>
        ///     model: 'ruby',<br/>
        ///     videoUri: 'https://example.com/bunny.mp4',<br/>
        ///     outputFormat: 'hdr10',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateVideoToHdrResponse> CreateVideoToHdrAsync(

            global::Runway.CreateVideoToHdrRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video to HDR<br/>
        /// This endpoint starts a task to upconvert an SDR video to true HDR with Ruby, Runway's HDR grading model. The output keeps the source's own pixels — luma and color are extended into the HDR range, nothing is re-synthesized. Set `outputFormat` to choose the delivery profile: `hdr10` (HEVC Main 10, BT.2020 + PQ, the default), `hlg` (HEVC Main 10, BT.2020 + HLG), `hdr_prores` (BT.2020 + PQ ProRes .mov editorial mezzanine, tier selectable with `proresProfile`), or `hdr_exr_sequence` (a .zip of half-float OpenEXR frames in linear BT.2020 display light, for compositing). Tasks bill per second of output at 20 credits per second, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K) — an upconvert delivers at the source's own resolution.
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
        /// const task = await client.videoToHdr<br/>
        ///   .create({<br/>
        ///     model: 'ruby',<br/>
        ///     videoUri: 'https://example.com/bunny.mp4',<br/>
        ///     outputFormat: 'hdr10',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateVideoToHdrResponse>> CreateVideoToHdrAsResponseAsync(

            global::Runway.CreateVideoToHdrRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video to HDR<br/>
        /// This endpoint starts a task to upconvert an SDR video to true HDR with Ruby, Runway's HDR grading model. The output keeps the source's own pixels — luma and color are extended into the HDR range, nothing is re-synthesized. Set `outputFormat` to choose the delivery profile: `hdr10` (HEVC Main 10, BT.2020 + PQ, the default), `hlg` (HEVC Main 10, BT.2020 + HLG), `hdr_prores` (BT.2020 + PQ ProRes .mov editorial mezzanine, tier selectable with `proresProfile`), or `hdr_exr_sequence` (a .zip of half-float OpenEXR frames in linear BT.2020 display light, for compositing). Tasks bill per second of output at 20 credits per second, rising to 40 credits per second when the source is larger than 4 megapixels (roughly 4K) — an upconvert delivers at the source's own resolution.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateVideoToHdrResponse> CreateVideoToHdrAsync(
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
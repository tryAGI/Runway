#nullable enable

namespace Runway
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a temporary media file that can be referenced in API generation requests. The uploaded files will be automatically expired and deleted after a period of time. It is strongly recommended to use our SDKs for this which have a simplified interface that directly accepts file objects.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response25> CreateUploadsAsync(
            string xRunwayVersion,
            global::Runway.Request12 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Uploads a temporary media file that can be referenced in API generation requests. The uploaded files will be automatically expired and deleted after a period of time. It is strongly recommended to use our SDKs for this which have a simplified interface that directly accepts file objects.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="filename">
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </param>
        /// <param name="type">
        /// The type of upload to create
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.Response25> CreateUploadsAsync(
            string xRunwayVersion,
            string filename,
            global::Runway.RequestType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
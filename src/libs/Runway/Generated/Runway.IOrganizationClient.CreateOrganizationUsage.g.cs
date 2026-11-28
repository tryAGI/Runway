#nullable enable

namespace Runway
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Query credit usage<br/>
        /// Fetch credit usage data broken down by model and day for the organization associated with the API key used to make the request. Up to 90 days of data can be queried at a time. Usage updates hourly; recent activity may not appear yet.
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
        /// const usage = await client.organization.retrieveUsage();<br/>
        /// console.log(usage);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateOrganizationUsageResponse> CreateOrganizationUsageAsync(

            global::Runway.CreateOrganizationUsageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query credit usage<br/>
        /// Fetch credit usage data broken down by model and day for the organization associated with the API key used to make the request. Up to 90 days of data can be queried at a time. Usage updates hourly; recent activity may not appear yet.
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
        /// const usage = await client.organization.retrieveUsage();<br/>
        /// console.log(usage);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateOrganizationUsageResponse>> CreateOrganizationUsageAsResponseAsync(

            global::Runway.CreateOrganizationUsageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query credit usage<br/>
        /// Fetch credit usage data broken down by model and day for the organization associated with the API key used to make the request. Up to 90 days of data can be queried at a time. Usage updates hourly; recent activity may not appear yet.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="startDate">
        /// The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.
        /// </param>
        /// <param name="beforeDate">
        /// The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.
        /// </param>
        /// <param name="tags">
        /// Only count generations that were created with every one of these tags in the `X-Runway-Tags` header. Tags are case-insensitive. Up to 10 tags.
        /// </param>
        /// <param name="groupBy">
        /// Also break usage down by tag in `resultsByTag`. `"tag"` gives one bucket per tag; a generation with several tags counts toward each of them. `"tag:&lt;key&gt;"` (for example `"tag:team"`) gives one bucket per value of that key, so each generation counts once. Generations without a matching tag fall under a `null` tag.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateOrganizationUsageResponse> CreateOrganizationUsageAsync(
            string xRunwayVersion = "2024-11-06",
            global::System.DateTime? startDate = default,
            global::System.DateTime? beforeDate = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? groupBy = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
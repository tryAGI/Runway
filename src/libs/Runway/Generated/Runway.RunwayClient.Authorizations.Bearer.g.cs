
#nullable enable

namespace Runway
{
    public sealed partial class RunwayClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Runway.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}
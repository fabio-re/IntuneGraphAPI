using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace IntuneGraphAPI.Services
{
    public interface IGraphService
    {
        Task<string> GetTokenFromGraphAsync(string tenantId, string clientId, string clientSecret);
        Task<string?> CallGraphMethod(HttpMethod httpMethod, string requestUrl, string accessToken);
        Task<GraphServiceClient> GetAuthGraphServiceClient(string tenantId, string clientId, string clientSecret);
    }
}
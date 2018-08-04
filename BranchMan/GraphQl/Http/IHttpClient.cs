using System.Threading.Tasks;

namespace GraphQl
{
    public interface IHttpClient
    {
        Task<HttpClientResponse> PostAsync(string url, string body);
    }
}
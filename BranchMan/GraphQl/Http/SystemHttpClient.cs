using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQl
{
    public sealed class SystemHttpClient : IHttpClient
    {        
        private readonly HttpClient client;

        public SystemHttpClient(HttpClient client)
        {            
            this.client = client;            
        }

        public async Task<HttpClientResponse> PostAsync(string url, string body)
        {                        
            var response = await client.PostAsync(url, new StringContent(body));

            if (response.IsSuccessStatusCode)
            {
                return HttpClientResponse.Succeeded(await response.Content.ReadAsStringAsync());
            }

            return HttpClientResponse.Failed();
        }
    }
}

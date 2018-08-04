using System.Threading.Tasks;
using GraphQl.Serialization;

namespace GraphQl.Client
{
    public sealed class GraphQlManager : IGraphQlManager
    {
        private readonly IHttpClient httpClient;
        private readonly IStringDeserializer stringDeserializer;

        public GraphQlManager(IHttpClient httpClient, IStringDeserializer stringDeserializer)
        {
            this.httpClient = httpClient;
            this.stringDeserializer = stringDeserializer;
        }

        public async Task<QueryResponse<T>> PerformQueryAsync<T>(GraphQlHost host, string query)
        {
            var response = await httpClient.PostAsync(host.GetHostUrl(), query);

            if (!response.IsSuccess)
            {    
                return QueryResponse.Failed<T>();
            }

            var deserializedObject = stringDeserializer.Deserialize<T>(response.StringResponse);

            return QueryResponse.Success(deserializedObject);
        }
    }
}
using System.Threading.Tasks;

namespace GraphQl.Client
{
    public interface IGraphQlManager
    {
        Task<QueryResponse<T>> PerformQueryAsync<T>(GraphQlHost host, string query);
    }
}
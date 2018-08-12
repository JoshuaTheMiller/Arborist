using System.Threading.Tasks;

namespace Arborist.Backend
{
    public interface IUserBranchCatalogRetriever
    {
        Task<UserCatalogResponse> RetrieveByUser(string id);
    }
}
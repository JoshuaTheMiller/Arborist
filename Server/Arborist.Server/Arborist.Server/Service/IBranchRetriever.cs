using System.Threading.Tasks;

namespace Arborist.Server.Service
{
    public interface IBranchRetriever
    {
        Task<OwnerResponse> RetrieveOwnerById(string id);
    }
}
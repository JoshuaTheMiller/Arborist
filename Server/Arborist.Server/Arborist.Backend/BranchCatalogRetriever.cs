using System;
using System.Threading.Tasks;

namespace Arborist.Backend
{
    public sealed class UserBranchCatalogRetriever : IUserBranchCatalogRetriever
    {
        public Task<UserCatalogResponse> RetrieveByUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}

using Arborist.Backend;
using System.Threading.Tasks;

namespace Arborist.Server.Service
{
    public sealed class BranchRetriever : IBranchRetriever
    {
        private readonly IUserBranchCatelogToOwnerMapper mapper;
        private readonly IUserBranchCatalogRetriever userBranchCatalogRetriever;

        public BranchRetriever(IUserBranchCatelogToOwnerMapper mapper, IUserBranchCatalogRetriever userBranchCatelogRetriever)
        {
            this.mapper = mapper;
            this.userBranchCatalogRetriever = userBranchCatelogRetriever;
        }

        public async Task<OwnerResponse> RetrieveOwnerById(string id)
        {
            var response = await userBranchCatalogRetriever.RetrieveByUser(id);

            if (response.RetrievalWasSuccessfull)
            {
                var mapResponse = mapper.Map(response.BranchesOwnedByUser, response.User);

                return OwnerResponse.Success(mapResponse.User, mapResponse.Branches);
            }

            return OwnerResponse.Failed();
        }
    }
}

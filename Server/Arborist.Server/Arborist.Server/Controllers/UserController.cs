using System.Threading.Tasks;
using Arborist.Contracts.Individual;
using Arborist.Server.Service;
using Microsoft.AspNetCore.Mvc;

namespace Arborist.Server.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IBranchRetriever branchRetriever;

        public UsersController(IBranchRetriever branchRetriever)
        {
            this.branchRetriever = branchRetriever;
        }  

        [HttpGet("{gitUserId}/branches")]
        public async Task<GetAllBranchesForUserResponse> GetBranchInformationForUserAsync(string gitUserId)
        {
            var response = await branchRetriever.RetrieveOwnerById(gitUserId);

            if (response.Successful)
            {
                return GetAllBranchesForUserResponse.Invalid();
            }

            return GetAllBranchesForUserResponse.Create(response.User, response.Branches);
        }
    }
}

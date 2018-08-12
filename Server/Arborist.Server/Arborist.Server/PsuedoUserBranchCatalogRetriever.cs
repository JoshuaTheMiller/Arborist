using Arborist.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arborist.Server
{
    public sealed class PsuedoUserBranchCatalogRetriever : IUserBranchCatalogRetriever
    {
        private readonly IDictionary<string, Repository> repoDictionary = new Dictionary<string, Repository>();

        public Task<UserCatalogResponse> RetrieveByUser(string id)
        {
            return Task.FromResult(CreateFakeResponse());
        }

        private UserCatalogResponse CreateFakeResponse()
        {
            var fakeUser = CreateFakeUser();
            var fakeBranchList = CreateFakeBranchList(fakeUser);

            return UserCatalogResponse.Success(fakeUser, fakeBranchList);
        }

        private IEnumerable<Branch> CreateFakeBranchList(User user)
        {
            return Enumerable.Range(0, 10).Select(n => CreateBranchFromNumber(user, n));
        }

        private Branch CreateBranchFromNumber(User user, int number)
        {
            var repo = GetFakeRepo(number);

            return repo.AddBranch(user, $"Branch{number}", DateTime.MinValue);                        
        }

        private Repository GetFakeRepo(int number)
        {
            var key = number.ToString();

            if(repoDictionary.ContainsKey(key))
            {
                return repoDictionary[key];
            }

            var repository = Repository.Create($"Repository{number}", LocationInformation.CreateOnlineOnlyInformation("http://example.com"), key);

            repoDictionary.Add(key, repository);

            return repository;
        }

        private User CreateFakeUser()
        {
            return User.CreateWithStringId("SomeFakeUser", Guid.NewGuid().ToString());
        }
    }
}

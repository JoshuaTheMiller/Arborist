using System.Collections.Generic;
using System.Linq;
using Arborist.Backend;
using Arborist.Contracts.Individual;

namespace Arborist.Server.Service
{
    public sealed class UserBranchCatelogToOwnerMapper : IUserBranchCatelogToOwnerMapper
    {
        public GetAllBranchesForUserResponse Map(IEnumerable<Backend.Branch> branchesOwnedByUser, User user)
        {
            var mappedBranches = MapBranches(branchesOwnedByUser);
            var mappedUser = MapUser(user);

            return GetAllBranchesForUserResponse.Create(mappedUser, mappedBranches);
        }

        private Contracts.User MapUser(User user)
        {
            return Contracts.User.Create(user.Id.ToString(), user.DisplayName);
        }

        private IEnumerable<Contracts.Individual.Branch> MapBranches(IEnumerable<Backend.Branch> branchesOwnedByUser)
        {
            return branchesOwnedByUser.Select(branch => new Contracts.Individual.Branch
            {
                LastCommittedToUtc = branch.LastCommittedToUtc,
                Name = branch.Name,
                OwningRepository = MapRepository(branch.Repository)
            });
        }

        private Contracts.Individual.Repository MapRepository(Backend.Repository repository)
        {
            return new Contracts.Individual.Repository
            {
                Id = repository.Id,
                Name = repository.Name,
                Url = repository.Location.Uri.ToString()                
            };
        }
    }
}

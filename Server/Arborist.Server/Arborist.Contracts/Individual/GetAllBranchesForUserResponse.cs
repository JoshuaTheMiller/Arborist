using System.Collections.Generic;
using System.Linq;

namespace Arborist.Contracts.Individual
{
    public sealed class GetAllBranchesForUserResponse
    {
        private bool IsInvalid { get; set; } = false;

        public User User { get; set; }   
        public IEnumerable<Branch> Branches { get; set; }

        public static GetAllBranchesForUserResponse Invalid()
        {
            return new GetAllBranchesForUserResponse
            {
                IsInvalid = true
            };
        }

        public static bool IsOwnerInvalid(GetAllBranchesForUserResponse owner)
        {
            return owner.IsInvalid;
        }

        public static GetAllBranchesForUserResponse Create(User user, IEnumerable<Branch> branches)
        {
            return new GetAllBranchesForUserResponse
            {
                User = user,
                Branches = branches.ToList()
            };
        }
    }
}

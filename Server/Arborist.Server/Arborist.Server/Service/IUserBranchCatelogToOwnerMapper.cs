using System.Collections.Generic;
using Arborist.Backend;
using Arborist.Contracts.Individual;

namespace Arborist.Server.Service
{
    public interface IUserBranchCatelogToOwnerMapper
    {        
        GetAllBranchesForUserResponse Map(IEnumerable<Backend.Branch> branchesOwnedByUser, User user);
    }
}
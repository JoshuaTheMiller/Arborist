using System.Collections.Generic;
using System.Linq;

namespace Arborist.Backend
{
    public sealed class UserCatalogResponse
    {
        public bool RetrievalWasSuccessfull { get; private set; }
        public User User { get; private set; }
        public IEnumerable<Branch> BranchesOwnedByUser { get; private set; }

        public static UserCatalogResponse Success(User user, IEnumerable<Branch> branches)
        {
            return new UserCatalogResponse
            {
                User = user,
                BranchesOwnedByUser = branches,
                RetrievalWasSuccessfull = true
            };
        }

        public static UserCatalogResponse Failed()
        {
            return new UserCatalogResponse
            {
                User = User.Invalid(),
                BranchesOwnedByUser = Enumerable.Empty<Branch>(),
                RetrievalWasSuccessfull = false
            };
        }
    }
}
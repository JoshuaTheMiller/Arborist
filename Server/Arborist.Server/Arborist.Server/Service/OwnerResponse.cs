using Arborist.Contracts;
using Arborist.Contracts.Individual;
using System.Collections.Generic;
using System.Linq;

namespace Arborist.Server.Service
{
    public sealed class OwnerResponse
    {
        public bool Successful { get; private set; }
        public User User { get; private set; }
        public IEnumerable<Branch> Branches { get; private set; }


        internal static OwnerResponse Success(User user, IEnumerable<Branch> branches)
        {
            return new OwnerResponse
            {
                Successful = true,
                User = user,
                Branches = branches
            };
        }

        internal static OwnerResponse Failed()
        {
            return new OwnerResponse
            {
                Successful = false,
                User = User.None(),
                Branches = Enumerable.Empty<Branch>()
            };
        }
    }
}
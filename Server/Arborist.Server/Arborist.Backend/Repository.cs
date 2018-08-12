using System;
using System.Collections.Generic;
using System.Linq;

namespace Arborist.Backend
{
    public sealed class Repository
    {
        public string Name { get; private set; }
        public LocationInformation Location { get; private set; }
        private readonly IDictionary<string, Branch> branches = new Dictionary<string, Branch>();
        public IEnumerable<Branch> Branches => branches.Values.ToList();
        public string Id { get; private set; }

        public static Repository Create(string name, LocationInformation location, string id)
        {
            return new Repository
            {                
                Location = location,
                Id = id,
                Name = name
            };
        }

        public Branch AddBranch(User owner, string name, DateTime lastCommittedToUtc)
        {
            this.branches.Add(name, Branch.Create(owner, name, lastCommittedToUtc, this));

            return branches[name];
        }
    }
}
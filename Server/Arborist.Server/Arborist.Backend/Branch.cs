using System;

namespace Arborist.Backend
{
    public sealed class Branch
    {
        public User Owner { get; private set; }
        public string Name { get; private set; }
        public DateTime LastCommittedToUtc { get; private set; }
        public Repository Repository { get; private set; }

        internal static Branch Create(User owner, string name, DateTime lastCommittedToUtc, Repository repository)
        {
            return new Branch
            {
                Repository = repository,
                LastCommittedToUtc = lastCommittedToUtc,
                Name = name,
                Owner = owner
            };
        }
    }
}
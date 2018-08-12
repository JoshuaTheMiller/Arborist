using System;

namespace Arborist.Contracts.Individual
{
    public sealed class Branch
    {
        public string Name { get; set; }
        public DateTime LastCommittedToUtc { get; set; }
        public Repository OwningRepository { get; set; }
    }
}

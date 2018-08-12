using System.Collections.Generic;

namespace Arborist.Backend
{
    public sealed class Organization
    {
        public string Name { get; }
        public IEnumerable<Repository> Repositories { get; }
    }
}

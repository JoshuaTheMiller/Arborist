using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public interface IPagedBranchRetriever
    {
        Task<IEnumerable<GitBranch>> RetrieveBranchesAsync(string user, string organization);
    }
}
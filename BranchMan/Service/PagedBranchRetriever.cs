using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl;
using GraphQl.Client;

namespace Service
{        
    public sealed class PagedBranchRetriever : IPagedBranchRetriever
    {
        private readonly IGraphQlManagerFactory graphQlManagerFactory;
        private readonly IConfigurationProvider configurationProvider;

        private static readonly string CHRGitHubHost = "ChrGitHubHostName";

        public PagedBranchRetriever(IGraphQlManagerFactory graphQlManagerFactory, IConfigurationProvider configurationProvider)
        {
            this.graphQlManagerFactory = graphQlManagerFactory;
            this.configurationProvider = configurationProvider;
        }

        //TODO: Return a response object
        public async Task<IEnumerable<GitBranch>> RetrieveBranchesAsync(string user, string organization)
        {
            var hostName = await configurationProvider.GetValueAsync(CHRGitHubHost);

            var graphQlHost = GraphQlHost.Create(hostName);

            var manager = graphQlManagerFactory.Create(hostName);

            var query = ConstructGraphQlQuery(user, organization);

            var response = await manager.PerformQueryAsync<IEnumerable<GitBranch>>(graphQlHost, query);

            if (!response.IsSuccess)
            {                
                return Enumerable.Empty<GitBranch>();
            }

            return response.Value;
        }

        private string ConstructGraphQlQuery(string user, string organization)
        {
            return $@"";
        }
    }
}

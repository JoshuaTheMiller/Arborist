using System;

namespace GraphQl.Client
{
    public sealed class GraphQlManagerFactory : IGraphQlManagerFactory
    {        
        private readonly IAuthorizationProvider authorizationProvider;

        public GraphQlManagerFactory(IAuthorizationProvider authorizationProvider)
        {
            this.authorizationProvider = authorizationProvider;
        }

        public GraphQlManager Create(string hostname)
        {
            throw new NotImplementedException();
        }
    }
}

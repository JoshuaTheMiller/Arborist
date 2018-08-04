using System;

namespace GraphQl.Client
{
    public sealed class GraphQlHost
    {
        private GraphQlHost(string hostName)
        {
            HostName = hostName;
        }

        public string HostName { get; }

        public string GetHostUrl()
        {
            return  $"https://{HostName}/api/graphql";
        }

        public static GraphQlHost Create(string hostName)
        {
            if (string.IsNullOrWhiteSpace(hostName))
            {
                throw new ArgumentNullException(nameof(hostName), "The given hostname has to be a non null or whitespace string.");
            }

            return new GraphQlHost(hostName);
        }
    }
}
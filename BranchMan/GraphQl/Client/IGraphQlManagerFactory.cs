namespace GraphQl.Client
{
    public interface IGraphQlManagerFactory
    {
        GraphQlManager Create(string hostname);
    }
}
namespace GraphQl.QueryConverter
{
    public interface IGraphQlConverter<T>  : IGraphQlConverter
        where T : GraphQlPart
    {
        string ConvertToString(T part); 
    }

    public interface IGraphQlConverter
    {
        GraphQlPartType SupportedType { get; }
    }
}
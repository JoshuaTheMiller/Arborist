namespace GraphQl.Serialization
{
    public interface IStringDeserializer
    {
        T Deserialize<T>(string @string);
    }
}
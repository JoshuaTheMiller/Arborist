using Newtonsoft.Json;

namespace GraphQl.Serialization
{
    public sealed class StringDeserializer : IStringDeserializer
    {
        public T Deserialize<T>(string @string)
        {
            return JsonConvert.DeserializeObject<T>(@string);
        }
    }
}

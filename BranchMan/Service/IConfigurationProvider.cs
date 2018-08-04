using System.Threading.Tasks;

namespace Service
{
    public interface IConfigurationProvider
    {
        Task<string> GetValueAsync(string chr);
    }
}
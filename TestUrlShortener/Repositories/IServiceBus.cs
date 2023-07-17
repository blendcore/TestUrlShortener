using TestUrlShortener.Models;
using System.Threading.Tasks;

namespace TestUrlShortener.Repositories
{
    public interface IServiceBus
    {
        Task SendMessageAsync(ShortUrl shortUrl);
    }
}

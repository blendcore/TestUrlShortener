using System.Collections.Generic;
using System.Linq;
using TestUrlShortener.Models;

namespace TestUrlShortener.Services
{
    public interface IShortUrlService
    {
        ShortUrl GetById(int id);

        ShortUrl GetByPath(string path);

        IQueryable<ShortUrl> GetAll();

        void Delete(int id);

        int Save(ShortUrl shortUrl);
    }
}

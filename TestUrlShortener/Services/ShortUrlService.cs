using System.Linq;
using TestUrlShortener.Data;
using TestUrlShortener.Helpers;
using TestUrlShortener.Models;

namespace TestUrlShortener.Services
{
    public class ShortUrlService : IShortUrlService
    {
        private readonly AppDbContext _context;
        public ShortUrlService(AppDbContext context)
        {
            _context = context;
        }
        public ShortUrl GetById(int id)
        {
            return _context.ShortUrls.Find(id);
        }

        public ShortUrl GetByPath(string path)
        {
            return _context.ShortUrls.Find(ShortUrlHelper.Decode((path)));
        }

        public IQueryable<ShortUrl> GetAll() { 
            return _context.ShortUrls;
        }

        public int Save(ShortUrl shortUrl)
        {
            _context.ShortUrls.Add(shortUrl);
            _context.SaveChanges();

            return shortUrl.Id;
        }

        public void Delete(int id)
        {
            var _url = _context.ShortUrls.FirstOrDefault(u => u.Id == id);
            if (_url != null)
            {
                _context.ShortUrls.Remove(_url);
                _context.SaveChanges();
            }
        }
    }
}

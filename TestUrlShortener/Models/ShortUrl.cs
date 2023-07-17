using System.ComponentModel.DataAnnotations;

namespace TestUrlShortener.Models
{
    public class ShortUrl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Url]        
        public string OriginalUrl { get; set; }
    }
}

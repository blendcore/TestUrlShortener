﻿using Microsoft.EntityFrameworkCore;
using TestUrlShortener.Models;

namespace TestUrlShortener.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}

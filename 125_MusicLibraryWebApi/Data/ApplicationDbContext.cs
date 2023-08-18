using _125_MusicLibraryWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

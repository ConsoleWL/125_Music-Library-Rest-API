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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
            new Song
            {
                Id = 4,
                Title = "The Golden Age",
                Artist = "Beck",
                Album = "Sea Change",
                ReleaseDate = DateTime.Now,
                Genre = "Alternative"
            },
            new Song
            {
                Id = 5,
                Title = "TestTitle",
                Artist = "TestBeck",
                Album = "TestSea Change",
                ReleaseDate = DateTime.Now,
                Genre = "TestAlternative"
            });
        }
    }
}

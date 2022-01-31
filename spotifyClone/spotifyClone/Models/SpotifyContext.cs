using System;
using Microsoft.EntityFrameworkCore;

namespace spotifyClone.Models
{
    public class SpotifyContext : DbContext
    {
        public DbSet<AlbumCategory> AlbumCategory { get; set; } = null!;
        public DbSet<Album> Album { get; set; } = null!;
        public DbSet<Song> Song { get; set; } = null!;

        public SpotifyContext(DbContextOptions<SpotifyContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumCategory>().HasData(
                    new AlbumCategory { Title = "First Category" },
                    new AlbumCategory { Title = "Second Category" },
                    new AlbumCategory { Title = "Third Category" },
                    new AlbumCategory { Title = "Fourth Category" }
            );
        }
    }
}

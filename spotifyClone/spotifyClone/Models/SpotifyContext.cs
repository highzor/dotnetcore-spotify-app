using System;
using Microsoft.EntityFrameworkCore;

namespace spotifyClone.Models
{
    public class SpotifyContext : DbContext
    {
        public DbSet<AlbumCategory> AlbumCategory { get; set; } = null!;
        public DbSet<Album> Album { get; set; } = null!;
        public DbSet<Song> Song { get; set; } = null!;

        public SpotifyContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ec2-54-76-249-45.eu-west-1.compute.amazonaws.com;" +
                "Port=5432;" +
                "Database=dgkvp96nv07rh;" +
                "Username=lkaibkhmobvxba;" +
                "Password=2aa987c904c65decc11cdc215fa209fa0d8ba6883cdc963458b94dc40e3b2c8d;" +
                "SSL Mode=Require;Trust Server Certificate=true");
        }

        //public SpotifyContext(DbContextOptions<SpotifyContext> options)
        //: base(options)
        //{
        //    Database.EnsureCreated();
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AlbumCategory>().HasData(
        //            new AlbumCategory { Title = "First Category" },
        //            new AlbumCategory { Title = "Second Category" },
        //            new AlbumCategory { Title = "Third Category" },
        //            new AlbumCategory { Title = "Fourth Category" }
        //    );
        //}
    }
}

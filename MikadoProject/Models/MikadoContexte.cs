using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace MikadoProject.Models
{
    public class MikadoContexte : DbContext
    {
        public MikadoContexte(DbContextOptions<MikadoContexte> options)
      : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Favori> Favoris { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Favori>().HasKey(favori => new { favori.UserId, favori.MediaId });

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Media>().ToTable("Medias");
        }
    }
}

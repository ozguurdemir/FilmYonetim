using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmYonetim.Domain.Entities;

namespace WebApp.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Theatres> Theatres { get; set; }
        public DbSet<Shows> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().ToTable("Movies");
            modelBuilder.Entity<Theatres>().ToTable(nameof(Theatres));
            modelBuilder.Entity<Shows>().ToTable(nameof(Shows));
        }
    }
}

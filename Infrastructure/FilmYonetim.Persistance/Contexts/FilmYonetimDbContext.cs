using FilmYonetim.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Persistance.Contexts
{
    public class FilmYonetimDbContext : DbContext
    {
        public FilmYonetimDbContext(DbContextOptions options) : base(options)
        {}
        
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Theatres> Theatres { get; set; }
        public DbSet<Shows> Shows { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().ToTable("Movie");
            modelBuilder.Entity<Theatres>().ToTable("Theater");
        }
    }
}

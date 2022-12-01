using FilmYonetim.Domain.Entities;
using System.Diagnostics;
using WebApp.Data;

namespace WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            
            if (context.Movies.Any())
            {
               return;   // DB has been seeded
            }

            
        }
    }
}
using Microsoft.EntityFrameworkCore;
using FilmYonetim.Persistance.Concretes;
using FilmYonetim.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmYonetim.Application.Repos;
using FilmYonetim.Persistance.Repos;

namespace FilmYonetim.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<FilmYonetimDbContext>(options => options.UseSqlServer(@"DESKTOP-BOQ50H3\SQLEXPRESS;Database=DbFilmYonetimPanel;Trusted_Connection=true"));
            services.AddScoped<IMoviesReadRepos, MoviesReadRepos>();
            services.AddScoped<IMoviesWriteRepos, MoviesWriteRepos>();
            services.AddScoped<IShowsReadRepos, ShowsReadRepos>();
            services.AddScoped<IShowsWriteRepos, ShowsWriteRepos>();
            services.AddScoped<ITheatersReadRepos, TheatersReadRepos>();
            services.AddScoped<ITheatersWriteRepos, TheatersWriteRepos>();
        }
    }
}

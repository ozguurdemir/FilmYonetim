using FilmYonetim.Application.Repos;
using FilmYonetim.Domain.Entities;
using FilmYonetim.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Persistance.Repos
{
    public class MoviesReadRepos : ReadRepos<Movies>, IMoviesReadRepos
    {
        public MoviesReadRepos(FilmYonetimDbContext context) : base(context)
        {
        }
    }
}

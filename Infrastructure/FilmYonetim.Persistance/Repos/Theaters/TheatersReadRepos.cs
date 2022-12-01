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
    internal class TheatersReadRepos : ReadRepos<Theatres>, ITheatersReadRepos
    {
        public TheatersReadRepos(FilmYonetimDbContext context) : base(context)
        {
        }
    }
}

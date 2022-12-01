
using FilmYonetim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FilmYonetim.Persistance.Concretes
{
    public class MovieService 
    {
        
        public void Add(Movies movie)
        {
            throw new NotImplementedException();
        }

        public List<Movies> GetMovies()

            => new() 
            {
                new() {Id = 1, Date = 2021, Name = "Dune" },
                new() {Id = 2, Date = 1977, Name = "GodFather" },
                new() {Id = 3, Date = 2019, Name = "Batman" },
                new() {Id = 4, Date = 2020, Name = "Spiderman" },

            };

        public void Remove(Movies movie)
        {
            throw new NotImplementedException();
        }

        public void Update(Movies movie)
        {
            throw new NotImplementedException();
        }
    }
}

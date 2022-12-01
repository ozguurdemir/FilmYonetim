using FilmYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Domain.Entities
{
    public class Movies : BaseEntity
    {
        public string Name { get; set; }
        public int Date { get; set; }
    }
}

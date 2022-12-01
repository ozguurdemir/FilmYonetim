using FilmYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Domain.Entities
{
    public class Shows : BaseEntity
    {        
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public Movies Movies { get; set; }
        public Theatres Theatres { get; set; }        
    }
}

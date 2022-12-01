using FilmYonetim.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Application.Repos
{
    public interface IRepos<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}

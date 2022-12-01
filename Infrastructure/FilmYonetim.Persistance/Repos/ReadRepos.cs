using FilmYonetim.Application.Repos;
using FilmYonetim.Domain.Entities.Common;
using FilmYonetim.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Persistance.Repos
{
    public class ReadRepos<T> : IReadRepos<T> where T : BaseEntity
    {
        readonly private FilmYonetimDbContext _context;

        public ReadRepos(FilmYonetimDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(int id)
            => await Table.FindAsync(id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);

        
    }
}

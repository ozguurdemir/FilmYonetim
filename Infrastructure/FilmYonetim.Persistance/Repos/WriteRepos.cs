using FilmYonetim.Application.Repos;
using FilmYonetim.Domain.Entities.Common;
using FilmYonetim.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Persistance.Repos
{
    public class WriteRepos<T> : IWriteRepos<T> where T : BaseEntity
    {
        readonly private FilmYonetimDbContext _context;

        public WriteRepos(FilmYonetimDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T item)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(item);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> item)
        {
            await Table.AddRangeAsync(item);
            return true;
        }

        public bool Remove(T item)
        {
            EntityEntry<T> entityEntry= Table.Remove(item);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public bool Update(T item)
        {
            EntityEntry entityEntry = Table.Update(item);
            return entityEntry.State == EntityState.Modified;
        }
    }
}

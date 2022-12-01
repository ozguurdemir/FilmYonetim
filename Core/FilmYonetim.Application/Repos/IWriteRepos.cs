using FilmYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetim.Application.Repos
{
    public interface IWriteRepos<T> : IRepos<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T item);
        Task<bool> AddRangeAsync(List<T> item);
        bool Remove(T item);
        Task<bool> RemoveAsync(int id);
        bool Update(T item);
        Task<int> SaveAsync();
    }
}

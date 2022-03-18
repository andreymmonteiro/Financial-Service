using Financial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> SelectAsync(Guid id);

        Task<IEnumerable<T>> SelectAsync();

        Task<T> UpdateAsync(T entity);

        Task<T> InsertASync(T entity);

        Task<bool> DeleteAsync(Guid id);

        
    }
}

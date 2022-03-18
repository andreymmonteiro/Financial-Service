using Financial.Data.Context;
using Financial.Domain.Entities;
using Financial.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Data.Repositories
{
    public sealed class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dbSet;
        private const int ZERO = 0;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(first => first.Id.Equals(id));
            var result = _dbSet.Remove(entity);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<T> InsertASync(T entity)
        {
            _dbSet.Add(entity);
            if(await _context.SaveChangesAsync() > ZERO) 
            {
                return entity;
            }
            return null;
        }

        public async Task<T> SelectAsync(Guid id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(single => single.Id.Equals(id));            
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var oldEntity = await _dbSet.AsNoTracking().FirstOrDefaultAsync(first => first.Id.Equals(entity.Id));
            if(!(oldEntity is null)) 
            {
                entity.UpdateAt = DateTime.Now;
                _context.Update<T>(entity);
                if(await _context.SaveChangesAsync() > ZERO) 
                {
                    return entity;
                }
            }
            return null;
        }
    }
}

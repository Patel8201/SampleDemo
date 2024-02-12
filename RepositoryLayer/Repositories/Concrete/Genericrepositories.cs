using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Concrete
{
    public class Genericrepositories<T> : IGenericrepositories<T> where T : class , IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Genericrepositories(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddtEntityAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void UpdatetEntity(T entity)
        {
            _dbSet.Update(entity);
        }
        public void DeletetEntity(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> GetAlltEntityList()
        {
          return _dbSet.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public async Task<T> GetEntityByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}

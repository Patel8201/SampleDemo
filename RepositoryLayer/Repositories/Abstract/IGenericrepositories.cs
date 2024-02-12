using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Abstract
{
    public interface IGenericrepositories<T> where T : class , IBaseEntity
    {
        Task AddtEntityAsync(T entity);
        void UpdatetEntity(T entity);
        void DeletetEntity(T entity);
        IQueryable<T> GetAlltEntityList();
        IQueryable<T> WhereAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetEntityByIdAsync(int id);
    }
}

using System;
using System.Linq;
using System.Linq.Expressions;

namespace Band.Domain
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); 
        TEntity GetById(TKey id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
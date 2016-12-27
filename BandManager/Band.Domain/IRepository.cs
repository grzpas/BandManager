using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Band.Domain
{
    public interface IRepository<TDomainEntity, in TDomainKey> where TDomainEntity : class
    {
        IEnumerable<TDomainEntity> Find(Expression<Func<TDomainEntity, bool>> filter, Func<IQueryable<TDomainEntity>, IOrderedQueryable<TDomainEntity>> orderBy = null);
        IList<TDomainEntity> GetAll();
        TDomainEntity GetByKey(TDomainKey id);
        void Create(TDomainEntity entity);
        void Update(TDomainEntity entity);
        void Delete(TDomainEntity entity);
    }
}
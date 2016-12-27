using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Band.Domain;
using NHibernate;
using NHibernate.Linq;

namespace Band.Db.Nhibernate
{
    public class NHibernateRepository<TDomainEntity, TDomainKey> : IRepository<TDomainEntity, TDomainKey> where TDomainEntity : class
    {
        private readonly ISession _session;

        public NHibernateRepository(ISession session)
        {
            _session = session;
        }

        protected ISession Session { get { return _session; } }

        public TDomainEntity GetByKey(TDomainKey id)
        {
            return _session.Get<TDomainEntity>(id);
        }

        public void Create(TDomainEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Update(TDomainEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete(TDomainEntity entity)
        {
            _session.Delete(entity);
        }

        public IList<TDomainEntity> GetAll()
        {
            return _session.QueryOver<TDomainEntity>().List();
        }

        public IEnumerable<TDomainEntity> Find(Expression<Func<TDomainEntity, bool>> filter, Func<IQueryable<TDomainEntity>, IOrderedQueryable<TDomainEntity>> orderBy = null)
        {
            if (orderBy != null)
            {
                return orderBy(_session.Query<TDomainEntity>().Where(filter)).ToList();
            }

            return _session.Query<TDomainEntity>().Where(filter).ToList();
        }
    }   
}
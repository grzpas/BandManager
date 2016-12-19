using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Band.Domain;
using NHibernate;

namespace Band.Db.Nhibernate
{
    public class NHibernateRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly ISession _session;

        public NHibernateRepository(ISession session)
        {
            _session = session;
        }

        protected ISession Session { get { return _session; } }

        public TEntity GetByKey(TKey id)
        {
            return _session.Get<TEntity>(id);
        }

        public void Create(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Update(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        
    }   
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using UniversalProject.DataModel;
using UniversalProject.IRepository;

namespace UniversalProject.Repository.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        private readonly IDbContextProvider _dbContextProvider;
        private DbContext DbContext { get { return _dbContextProvider.CurrentDbContext(); } }

        protected BaseRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public virtual void Add(TEntity t)
        {
            DbContext.Set<TEntity>().Add(t);
        }

        public virtual void Edit(TEntity t)
        {
            var entry = DbContext.Entry(t);
            DbContext.Set<TEntity>().Attach(t);
            entry.State = EntityState.Modified;
        }

        public virtual void Delete(Guid id)
        {
            var entity = Get(id);
            DbContext.Set<TEntity>().Remove(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbContext.Set<TEntity>().Where(predicate);
        }

        public virtual TEntity Get(Guid id)
        {
            var entity = DbContext.Set<TEntity>().Find(id);
            return entity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace YnovShop.Data
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class 
    {
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
             int? skip = null, int? take = null)
        {
            return GetQueryable<TEntity>(filter, orderBy, skip, take).ToList();
        }

        protected virtual IQueryable<TEntity> GetQueryable<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null, int? take = null) where TEntity : class
        {
            IQueryable<TEntity> query = _unitOfWork.DbContext.Set<TEntity>();

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            if (skip.HasValue)
                query = query.Skip(skip.Value);

            if (take.HasValue)
                query = query.Take(take.Value);

            return query;
        }

        public void Insert(TEntity entity)
        {
            _unitOfWork.DbContext.Set<TEntity>().Add(entity);
            _unitOfWork.DbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.DbContext.Set<TEntity>().Update(entity);
            _unitOfWork.DbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _unitOfWork.DbContext.Set<TEntity>().Remove(entity);
            _unitOfWork.DbContext.SaveChanges();
        }
    }
}

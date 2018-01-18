using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace YnovShop.Data
{
    public interface IRepositoryBase<TEntity>
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int? skip = null, int? take = null);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}

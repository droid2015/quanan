using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuanAn.Common.DataModel
{
    /// <summary>
    /// A DbUnitOfWork class instance represents the implementation of the Unit Of Work pattern for design-time mode. 
    /// </summary>
    public class DesignTimeUnitOfWork : UnitOfWorkBase, IUnitOfWork
    {

        public static readonly IUnitOfWork Instance = new DesignTimeUnitOfWork();

        void IUnitOfWork.SaveChanges() { }

        EntityState IUnitOfWork.GetState(object entity)
        {
            return EntityState.Detached;
        }

        void IUnitOfWork.Update(object entity) { }

        void IUnitOfWork.Detach(object entity) { }

        bool IUnitOfWork.HasChanges()
        {
            return false;
        }

        protected IRepository<TEntity, TPrimaryKey>
            GetRepository<TEntity, TPrimaryKey>(Expression<Func<TEntity, TPrimaryKey>> getPrimaryKeyExpression, Action<TEntity, TPrimaryKey> setPrimaryKeyAction = null)
            where TEntity : class
        {
            return GetRepositoryCore<IRepository<TEntity, TPrimaryKey>, TEntity>(() => new DesignTimeRepository<TEntity, TPrimaryKey>(getPrimaryKeyExpression, setPrimaryKeyAction));
        }

        protected IReadOnlyRepository<TEntity>
            GetReadOnlyRepository<TEntity>()
            where TEntity : class
        {
            return GetRepositoryCore<IReadOnlyRepository<TEntity>, TEntity>(() => new DesignTimeReadOnlyRepository<TEntity>());
        }
    }
}
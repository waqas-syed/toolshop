using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    /// <summary>
    /// An abstract class containing the implementation of the methods from the IRepository interface, yet it doesn't 
    /// implement the interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private ToolsDbContext _toolsDbContext;
        private readonly IDbSet<T> _dbSet;

        public RepositoryBase(IDbFactory dbFactory)
        {
            _toolsDbContext = dbFactory.GetDbContext();
            _dbSet = _toolsDbContext.Set<T>();
        }

        /// <summary>
        /// Add the Entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Update the given entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _toolsDbContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Delete the entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Get the Id by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IDbSet<T> DbSet { get { return _dbSet; } }
    }
}

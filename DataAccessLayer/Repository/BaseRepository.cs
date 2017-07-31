using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public abstract class BaseRepository <TEntity>:IRepository<TEntity> where TEntity: class
    {
        private ManagementContext _dbContext;

        public BaseRepository(ManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity item)
        {
            _dbContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public void Remove(TEntity item)
        {
            _dbContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _dbContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
    }
}

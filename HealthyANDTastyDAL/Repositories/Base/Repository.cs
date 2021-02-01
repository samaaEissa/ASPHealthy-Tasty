using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace HealthyANDTastyDAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Private attributes
        private DbContext context;
        private DbSet<TEntity> dbSet;

        #endregion

        #region Constructor
        public Repository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        #endregion

        #region Public Functions      

        public void Save(TEntity item)
        {
            dbSet.Add(item);
        }

        public TEntity GetByID(int ID)
        {
            return dbSet.Find(ID);
        }

        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
        public void Delete(int ID)
        {
            TEntity entity = dbSet.Find(ID);
            dbSet.Remove(entity);
        }

        public void Delete(TEntity item)
        {
            dbSet.Remove(item);
        }


        #endregion

        #region Private Functions
        #endregion
    }

}




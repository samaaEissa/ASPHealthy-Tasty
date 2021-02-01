using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyANDTastyDAL
{
   public interface IRepository<TEntity> where TEntity : class
    {
        void Save(TEntity item);
        TEntity GetByID(int ID);
        List<TEntity> GetAll();
        void Delete(int ID);
        void Delete(TEntity item);
    }
}

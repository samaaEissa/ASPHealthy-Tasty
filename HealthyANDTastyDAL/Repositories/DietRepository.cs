using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class DietRepository : Repository<Diet>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;
        public DietRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }
        public Diet GetByName(string name)
        {
            Diet diet = (from item in healthyANDTastyEntities.Diets
                         where item.DietName==name
                         select item).FirstOrDefault();
            return diet;
        }
    }
}

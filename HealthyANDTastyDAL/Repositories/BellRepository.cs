using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class BellRepository : Repository<Bell>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;
        public BellRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }
    }
}

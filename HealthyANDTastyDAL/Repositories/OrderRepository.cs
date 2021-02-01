using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;

        public OrderRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }
    }
}

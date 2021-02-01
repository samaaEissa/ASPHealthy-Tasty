using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class AdminRepository : Repository<Admin>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;
        public AdminRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }
        public Admin checkAdminExist(string userName ,String password)
        {
            Admin admin = (from item in healthyANDTastyEntities.Admins
                          where item.UserName == userName && item.Password == password
                          select item).FirstOrDefault();
            return admin;
        }
    }
}

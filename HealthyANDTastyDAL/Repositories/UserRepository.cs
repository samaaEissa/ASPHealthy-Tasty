using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class UserRepository : Repository<User>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;
        
        public UserRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }

        public User Checkuser(string email,string password)
        {
            User user = (from item in healthyANDTastyEntities.Users
                         where item.e_mail == email && item.password== password
                         select item).FirstOrDefault();
            return user;
        }
        public User GetByPhone(string phone)
        {
           // User user = healthyANDTastyEntities.Users.Where(item => item.phone == phone).FirstOrDefault();
            User user = (from item in healthyANDTastyEntities.Users
                         where item.phone == phone
                         select item).FirstOrDefault();
            return user;
        }
        public int AddPoint(int ID)
        {
            User user = (from item in healthyANDTastyEntities.Users
                         where item.customerID== ID
                         select item).FirstOrDefault();
            int points = user.FreePoints != null ? user.FreePoints.Value : 0;

            points++;
            return points;
        }

        public void setPoint(int ID)
        {
            User user = (from item in healthyANDTastyEntities.Users
                         where item.customerID == ID
                         select item).FirstOrDefault();
            user.FreePoints = 0;
        }
        public int AddFreeMeal(int ID)
        {
            User user = (from item in healthyANDTastyEntities.Users
                         where item.customerID == ID
                         select item).FirstOrDefault();
            int FreeMeals = user.FreePoints != null ? user.FreePoints.Value : 0;

            FreeMeals++;
            return FreeMeals;
        }

        public void setFreeMeals(int ID)
        {
            User user = (from item in healthyANDTastyEntities.Users
                         where item.customerID == ID
                         select item).FirstOrDefault();
            user.free_meals = 0;
        }
        public bool IsUerExist(string email, String password)
        {
            User user = (from item in healthyANDTastyEntities.Users
                           where item.e_mail == email && item.password == password
                           select item).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }
    }
}

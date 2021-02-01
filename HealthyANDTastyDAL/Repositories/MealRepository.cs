using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HealthyANDTastyDAL.Repositories
{
    public class MealRepository : Repository<Meal>
    {
        private HealthyANDTastyEntities healthyANDTastyEntities;
        public MealRepository(DbContext context) : base(context)
        {
            this.healthyANDTastyEntities = (HealthyANDTastyEntities)context;
        }

        public Meal GetByPhone(string name)
        {
            // Meal meal = healthyANDTastyEntities.Meals.Where(item => item.Meals == name).FirstOrDefault();
            Meal meal = (from item in healthyANDTastyEntities.Meals
                         where item.Mname == name
                         select item).FirstOrDefault();
            return meal;
        }
        public List<Meal> GetMealsByDietID(int ID)
        {
            List<Meal> meals = (from item in healthyANDTastyEntities.Meals
                                where item.DietID == ID
                                select item).ToList();
            return meals;
        }
    }
}

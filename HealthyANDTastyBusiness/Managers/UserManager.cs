using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyANDTastyBusiness.Managers
{
    public class UserManager
    {
        #region Private Atrributes
        private UnitOfWork unitOfWork;
        #endregion

        #region Constructor
        public UserManager()
        {
            unitOfWork = new UnitOfWork();
        }
        #endregion

        #region Public Functions
        public string calculatingDiet(double weight, double hight)
        {
            double h = hight / 100;

            double BMI = weight / (h * h);

            if (BMI < 18.5)
            {
                return "Under Weight";
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                return "Healthy";
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                return "Over Weight";
            }
            else
            {
                return "Obese";
            }
        }
        #endregion
        #region
        public void UserRegisteration(User user)
        {
            double weight = user.weight!=null?user.weight.Value:0;
            double height = user.hight!= null ? user.hight.Value : 0;
            string dietName = calculatingDiet(weight, height);
            if (dietName == "Healthy")
              user.Diet= unitOfWork.DietRepository.GetByName(calculatingDiet(weight, height));
            else 
                user.Diet = unitOfWork.DietRepository.GetByName(dietName);
            unitOfWork.UserRepository.Save(user);
            unitOfWork.Commit();
        }
        #endregion

        #region
        public List<Meal> getCustomerMeals(string phone)
        {

            List<Meal> meals ;
            User user = unitOfWork.UserRepository.GetByPhone(phone);
            if (user != null)
            {
                meals = unitOfWork.MealRepository.GetMealsByDietID(user.DietID);
                return meals;
            }
            else
                return null;

        }
        #endregion
        #region
        public User getUserByPhone(string phone)
        {


            User user = unitOfWork.UserRepository.GetByPhone(phone);

            if (user != null)
            {

                return user;
            }
            else
                return null;
        }
        #endregion
    }
}

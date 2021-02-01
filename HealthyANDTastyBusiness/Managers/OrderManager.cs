using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyANDTastyBusiness.Managers
{
    public class OrderManager
    {
        #region Private Atrributes
        private UnitOfWork unitOfWork;
        #endregion

        #region Constructor
        public OrderManager()
        {
            unitOfWork = new UnitOfWork();
        }
        #endregion
        #region
        public bool Ordering(Order order)
        {
            bool state =false;
            unitOfWork.OrderRepository.Save(order);
            User user=unitOfWork.UserRepository.GetByID(order.CustomerID);
            int points = unitOfWork.UserRepository.AddPoint(user.customerID);
            int free_meals = user.free_meals != null ? user.free_meals.Value : 0;
            if (points < 18)
            {
                state= false;
            }
            else if (points == 18 && free_meals <= 3)
            {
                unitOfWork.UserRepository.AddFreeMeal(user.customerID);
                state =true;

            }
            else if (points >18 && free_meals > 3)
            {
                unitOfWork.UserRepository.setPoint(user.customerID);
                unitOfWork.UserRepository.setFreeMeals(user.customerID);
                state= false;
            }
            
            unitOfWork.Commit();
             return state;
        }
        #endregion
    }
}

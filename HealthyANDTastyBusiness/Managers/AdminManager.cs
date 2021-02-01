using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyANDTastyBusiness.Managers
{
    public class AdminManager
    {
        #region Private Atrributes
        private UnitOfWork unitOfWork;
        #endregion

        #region Constructor
        public AdminManager ()
        {
            unitOfWork = new UnitOfWork();
        }
        #endregion

        #region Public Functions
        public Admin checkAdminExist(string userName, String password)
        {
            Admin admin =unitOfWork.AdminRepository.checkAdminExist(userName,password);
            return admin;
        }
        #endregion
    }
}

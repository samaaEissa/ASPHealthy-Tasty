using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthyANDTastyModel;
using HealthyANDTastyDAL;
using HealthyANDTastyDAL.Repositories;

namespace HealthyANDTasty.Controllers
{
    public class LoginController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            if (admin != null)
            {
                if (unitOfWork.AdminRepository.IsUerExist(admin.UserName, admin.Password))
                    return RedirectToAction("Meals","Index");
            }
            return View("Home","Index");
        }
    }
}
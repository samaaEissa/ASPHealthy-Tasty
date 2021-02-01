using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

 
namespace HealthyANDTasty.Controllers
{
    public class DietController : Controller
    {
        private UnitOfWork UnitOfWork = new UnitOfWork();
        // GET:Diet/Display
        public ActionResult Display()
        {
            List<Diet> listDiets = UnitOfWork.DietRepository.GetAll();
            Diet diet = new Diet();
            diet.DietName = "test";
            string name =diet.DietName ;
            return View(listDiets);
            //  return Content("hello world!!");
            // return HttpNotFound();
            //  return new EmptyResult();
           // return RedirectToAction("Index", "Home");
        }
        public ActionResult Delete(int? DietID)
        {
            UnitOfWork.DietRepository.Delete(DietID.Value);
            UnitOfWork.Commit();
            return RedirectToAction("Display", "Diet");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Diet diet)
        {          
            UnitOfWork.DietRepository.Save(diet);
            UnitOfWork.Commit();
            return RedirectToAction("Display", "Diet");
        }
    }
}
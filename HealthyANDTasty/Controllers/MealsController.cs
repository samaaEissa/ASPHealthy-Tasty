using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HealthyANDTastyModel;
using HealthyANDTastyDAL;
using HealthyANDTastyDAL.Repositories;

namespace HealthyANDTasty.Controllers
{
    public class MealsController : Controller
    {
        private HealthyANDTastyEntities db = new HealthyANDTastyEntities();
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Meals
        public ActionResult Index()
        {
            var meals = unitOfWork.MealRepository.GetAll();
            foreach(var meal in meals)
            {
                meal.ImageURl = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(meal.image));
            }
            return View(meals.ToList());
        }

        // GET: Meals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meal meal = unitOfWork.MealRepository.GetByID(id.Value);
            if (meal == null)
            {
                return HttpNotFound();
            }
            return View(meal);
        }

        // GET: Meals/Create
        public ActionResult Create()
        {
            ViewBag.DietID = new SelectList(db.Diets, "DietID", "DietName");
            return View();
        }

        // POST: Meals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mealID,Mname,price,ingrdiants,type,DietID,image")] Meal meal)
        {
            if (ModelState.IsValid)
            {
                db.Meals.Add(meal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DietID = new SelectList(db.Diets, "DietID", "DietName", meal.DietID);
            return View(meal);
        }

        // GET: Meals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meal meal = db.Meals.Find(id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            ViewBag.DietID = new SelectList(db.Diets, "DietID", "DietName", meal.DietID);
            return View(meal);
        }

        // POST: Meals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mealID,Mname,price,ingrdiants,type,DietID,image")] Meal meal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DietID = new SelectList(db.Diets, "DietID", "DietName", meal.DietID);
            return View(meal);
        }

        // GET: Meals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meal meal = db.Meals.Find(id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            return View(meal);
        }

        // POST: Meals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            unitOfWork.MealRepository.Delete(id);
           // Meal meal = db.Meals.Find(id);
           // db.Meals.Remove(meal);
           // db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
        }
    }
}

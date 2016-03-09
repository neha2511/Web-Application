using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class StudyPlanController : Controller
    {
        // GET: StudyPlan
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudyPlan/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: StudyPlan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyPlan/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyPlan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudyPlan/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudyPlan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudyPlan/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

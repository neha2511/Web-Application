using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class profileController : Controller
    {
        // GET: profile
        public ActionResult Index()
        {
            return View();
        }

        // GET: profile/Details
        public ActionResult Details()
        {
            return View();
        }

        // GET: profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: profile/Create
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

        // GET: profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: profile/Edit/5
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

        // GET: profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: profile/Delete/5
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

using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentProfileController : Controller
    {
        // GET: StudentProfile
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentProfile/Details
        public ActionResult Details()
        {
            StudentProfile profile = new StudentProfile {FirstName="Rohit",LastName="Dumbre",CWID="10406746",EmailID="Rohit@gmail.com",Number="2011001000",Gender="Male"};
            return View(profile);
        }

        // GET: StudentProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentProfile/Create
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

        // GET: StudentProfile/Edit
        public ActionResult Edit()
        {
            return View();
        }

        // POST: StudentProfile/Edit/5
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

        // GET: StudentProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentProfile/Delete/5
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

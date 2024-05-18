using MVCLab9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab9.Controllers
{
    //ctrl+M+O para reducir todo
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            //@model IEnumerable<MVCLab9.Models.PersonModel>
            //Esta esperando una lista - una coleccion

            List<PersonModel> models = new List<PersonModel>();
            models.Add(new PersonModel { Id = 1, FirstName = "Jhoselin", LastName = "Ponce", Age = 20, Address = "Av. Santa" });
            return View(models);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PersonModel model)
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

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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

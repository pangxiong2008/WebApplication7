using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class NeedShipController : Controller
    {
        // GET: NeedShip
        public ActionResult Index()
        {
            return View();
        }

        // GET: NeedShip/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NeedShip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NeedShip/Create
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

        // GET: NeedShip/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NeedShip/Edit/5
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

        // GET: NeedShip/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NeedShip/Delete/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegagamesDenmark.Controllers
{
    public class AegonsConquestController : Controller
    {
        // GET: AegonsConquest
        public ActionResult Index()
        {
            return View();
        }

        // GET: AegonsConquest/Details/5

        public ActionResult Lord()
        {
            return View();

        }

        public ActionResult Knight()
        {
            return View();

        }
        public ActionResult Maester()
        {
            return View();

        }
        public ActionResult Heir()
        {
            return View();

        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Thanks()
        {
            return View();
        }
        public ActionResult NobleHouses()
        {
            return View();
        }
        public ActionResult Rules()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AegonsConquest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AegonsConquest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AegonsConquest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AegonsConquest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AegonsConquest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AegonsConquest/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
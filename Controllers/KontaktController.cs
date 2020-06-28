using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegagamesDenmark.Controllers
{
    public class KontaktController : Controller
    {
        // GET: Kontakt
        public ActionResult Index()
        {
            return View("Create");
        }

        // GET: Kontakt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kontakt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kontakt/Create
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

        // GET: Kontakt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kontakt/Edit/5
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

        // GET: Kontakt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kontakt/Delete/5
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
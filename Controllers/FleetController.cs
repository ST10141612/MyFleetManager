﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFleetManager.Controllers
{
    public class FleetController : Controller
    {
        // GET: FleetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FleetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FleetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FleetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FleetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FleetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FleetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FleetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

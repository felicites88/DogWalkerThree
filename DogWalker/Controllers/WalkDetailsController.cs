﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogWalker.Controllers
{
    public class WalkDetailsController : Controller
    {
        // GET: WalkDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: WalkDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WalkDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkDetails/Create
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

        // GET: WalkDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalkDetails/Edit/5
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

        // GET: WalkDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkDetails/Delete/5
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

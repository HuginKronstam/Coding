using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HuginsMadness.Models;


namespace HuginsMadness.Controllers
{
    public class AccessController : Controller
    {
        private CharCreateDB _contextDB = new CharCreateDB();

        // GET: Access
        public ActionResult Index()
        {
            return View("Index", _contextDB.Accesses.ToList());
        }

        //GET: Details
        public ActionResult Details(int id)
        {
            Access access = _contextDB.Accesses.Find(id);
            if (access == null)
            {
                HttpNotFound();
            }
            return View("Details", access);
        }

        //GET: Create
        public ActionResult Create()
        {
            Access access = new Access();

            return View("Create", access);
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Access access)
        {
            if (ModelState.IsValid)
            {
                _contextDB.Accesses.Add(access);
                _contextDB.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Create", access);
        }

        //GET: Edit
        public ActionResult Edit(int id)
        {
            Access access = _contextDB.Accesses.Find(id);
            if (access == null)
                return View("Edit", access);
            return RedirectToAction("Index");
        }

        //POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Access access)
        {
            if (ModelState.IsValid)
            {

                _contextDB.Entry(access).State = EntityState.Modified;
                _contextDB.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Edit", access);
        }
    }
}
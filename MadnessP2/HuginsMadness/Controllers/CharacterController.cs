using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HuginsMadness.Models;

namespace HuginsMadness.Controllers
{
    public class CharacterController : Controller
    {
        private CharCreateDB _contextDB = new CharCreateDB();

        // GET: Character
        public ActionResult Index()
        {
            return View("Index", _contextDB.Characters.ToList());
        }

        //GET: Details
        public ActionResult Details(int id)
        {
            Character character = _contextDB.Characters.Find(id);
            if (character == null)
            {
                HttpNotFound();
            }
            return View("Details", character);
        }

        //GET: Create
        public ActionResult Create()
        {
            Character character = new Character();

            return View("Create", character);
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Character character)
        {
            if (ModelState.IsValid)
            {
                _contextDB.Characters.Add(character);
                _contextDB.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Create", character);
        }

        //GET: Edit
        public ActionResult Edit(int id)
        {
            Character character = _contextDB.Characters.Find(id);
            if (character == null)
                return View("Edit", character);
            return RedirectToAction("Index");
        }

        //POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {

                _contextDB.Entry(character).State = EntityState.Modified;
                _contextDB.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Edit", character);
        }

        // GET: /Character/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Character/Register
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(Character character)
        {
            if (ModelState.IsValid)
            {
                _contextDB.Characters.Add(character);
                _contextDB.SaveChanges();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Register", character);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: //Character/Login
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(Character character)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
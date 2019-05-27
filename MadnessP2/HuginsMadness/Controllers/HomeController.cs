using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using HuginsMadness.Controllers;
using HuginsMadness.Models;

namespace HuginsMadness.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        //TODO: Remove anon access when login is implemented
        public ActionResult Map()
        {

            string kage = "";
            string kage2 = "";
            ViewBag.Message = "Your Map page";
            GetAccessToShard(kage, kage2);
            return View();
        }
        [HttpPost]
        public void GetAccessToShard(string shard, string userName)
        {
            //AccessController acces = new AccessController();
            //var kage = (this.User.Identity.Name => acces.user
            //HuginsMadness.DataModel.AspNetUsers
            CharCreateDB db = new CharCreateDB();
            var characters = db.Characters.Where(x => x.Name == "GameMaster");
            var i = characters.Count();

            Debug.Write(" dette er et sted hvor der skal stå noget" + i + " dette er et sted hvor der skal stå noget");
            foreach (var character in characters)
            {
                var k = character.Name;
                //Debug.WriteLine("");
                Debug.Write(k);
            }
            var test = User.Identity.Name.ToString();
            Debug.WriteLine(test);
            Debug.WriteLine("gleijkngrepoiugngpoinrtgorignsåogingoign");
        }
    }
}
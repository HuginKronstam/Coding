using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelForum.Models;

namespace TravelForum.Controllers
{
    public class PostController : Controller
    {
        ForumDB db = new ForumDB();

        //GET: Post
        public ActionResult Index()
        {
            var posts = db.Posts.ToList<Post>();
            return View(posts);
        }
        public ActionResult ShowPost(int id)
        {
            var selectedPost = (from post in db.Posts
                                where post.ID == id
                                select post).FirstOrDefault();
            if (selectedPost != null)
            {
                return View(selectedPost);
            }
            return RedirectToAction("Index");
        }
        
        //GET: Post
        public ActionResult Create()
        {
            Post newPost = new Post();
            return View(newPost);
        }

        //POST: Post
        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create", post);
        }
    }
}
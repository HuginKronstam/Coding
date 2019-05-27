using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TravelForum.Models;

namespace TravelForum.Controllers
{
    public class TopicController : Controller
    {
        ForumDB db = new ForumDB();
        
        //GET: Topic
        public ActionResult Index()
        {
            var topics = db.Topics.ToList<Topic>();
            return View(topics);
        }
        public ActionResult ShowTopic(int id)
        {
            ViewBag.TopicName = "";
            var selectedTopic = (from topic in db.Topics
                                where topic.ID == id
                                select topic).FirstOrDefault();
            ViewBag.TopicName = selectedTopic.TopicName;

            if (selectedTopic != null)
            {
                var postList = (from post in db.Posts
                                where post.TopicId == id
                                select post);
                return View(postList);
            }
            return RedirectToAction("Index");
        }

        //GET: Topic
        public ActionResult Create()
        {
            Topic newTopic = new Topic();
            return View(newTopic);
        }

        //POST: Topic
        [HttpPost]
        public ActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                db.Topics.Add(topic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create", topic);
        }
    }
}
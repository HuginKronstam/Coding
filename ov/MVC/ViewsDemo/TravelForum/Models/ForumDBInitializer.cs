using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelForum.Models
{
    public class ForumDBInitializer : DropCreateDatabaseAlways<ForumDB>
    {
        protected override void Seed(ForumDB context)
        {
            Topic weak = new Topic { TopicName = "Weak Topic" };

            context.Topics.Add(weak);

            context.Posts.Add(new Post
            {
                Subject = "Weak Subject",
                Content = "Weak Content",
                Author = "Weak Author",
                Topic = weak
            });

            context.Posts.Add(new Post
            {
                Subject = "Strong Subject",
                Content = "Strong Content",
                Author = "Strong Author",
                Topic = new Topic { TopicName = "Strong Topic" }
            });

            context.Posts.Add(new Post
            {
                Subject = "Super-Weak Subject",
                Content = "Super-Weak Content",
                Author = "Super-Weak Author",
                Topic = new Topic { TopicName = "Strong Topic" }
            });

            context.Posts.Add(new Post
            {
                Subject = "Some other weak subject",
                Content = "Some other weak Content",
                Author = "By a weak author",
                Topic = weak
            });
            context.SaveChanges();
            base.Seed(context);
            
        }
    }
}
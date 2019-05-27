using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TravelForum.Models
{
    public class Post
    {
        public int ID { get; set; }
        [DisplayName("User")]
        public string Author {get;set;}
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
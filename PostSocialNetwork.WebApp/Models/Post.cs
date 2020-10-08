using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostSocialNetwork.WebApp.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string ProfileEmail { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}

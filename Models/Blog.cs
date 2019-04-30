using System.Collections.Generic;

namespace InstagramAPIClone.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public List<Post> Posts { get; set; }
    }
}
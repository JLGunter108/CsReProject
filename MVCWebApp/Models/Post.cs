using System.Collections.Generic;

namespace MVCWebApp.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
    }
}

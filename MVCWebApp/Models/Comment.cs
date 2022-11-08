using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MVCWebApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post post { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}

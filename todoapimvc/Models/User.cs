using System.ComponentModel.DataAnnotations;

namespace todoapimvc.Models
{
    public class User
    {
        [Key]
        public int Id_user { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}

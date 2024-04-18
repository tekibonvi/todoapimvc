using System.ComponentModel.DataAnnotations;

namespace todoapimvc.Models
{
    public class TodoItem
    {
        [Key]
        public int Id_todo_item { get; set; }

        [Required (ErrorMessage ="Agregue un titulo")]
        public string Ritle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agregue una descripcion")]
        public string Description { get; set; } = string.Empty;

        [Required (ErrorMessage ="Debes asignarlo a un Usuario")]
        public int User_id {  get; set; }

        public User User { get; set; } = null!;
    }
}

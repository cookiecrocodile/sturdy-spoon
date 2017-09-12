using System.ComponentModel.DataAnnotations;

namespace Receptbank.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kommentaren får inte vara tom")]
        [MinLength(4, ErrorMessage = "Kommentaren måste innehålla minst 4 tecken")]
        public string Comment { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
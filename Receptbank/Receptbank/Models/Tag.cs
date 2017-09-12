using System.ComponentModel.DataAnnotations;

namespace Receptbank.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Taggen får inte vara tom")]
        [MinLength(3, ErrorMessage = "Taggen måste innehålla minst 3 tecken")]
        public string Name { get; set; }
    }
}
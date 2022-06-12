using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please fill field Name")]
        [RegularExpression(@"^([a-zA-Z])[a-zA-Z_-]*[\w_-]*[\S]$|^([a-zA-Z])[0-9_-]*[\S]$|^[a-zA-Z]*[\S]$", ErrorMessage = "Please enter upper or lower case alphabet only")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please fill field Surname")]
        [RegularExpression(@"^([a-zA-Z])[a-zA-Z_-]*[\w_-]*[\S]$|^([a-zA-Z])[0-9_-]*[\S]$|^[a-zA-Z]*[\S]$", ErrorMessage = "Please enter upper or lower case alphabet only")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please fill field Birth Date")]
        public string BirthDate { get; set; }


        public string Gender { get; set; }

        public int ContactNumber { get; set; }


        [Required(ErrorMessage = "Please fill field Email")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}

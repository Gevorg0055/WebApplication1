using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class HRDataget
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill field Social Security Number")]
        public int SocialSecurityNumber { get; set; }


       

        [Required(ErrorMessage = "Please fill field Employee ID")]
        public int EmployeeId { get; set; }




        [Required(ErrorMessage = "Please fill field Salary")]
        public int Salary { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Employee : Person
    {
        [Required]
        public string? EmployeeId { get; set; }

        [Range(18, 65, ErrorMessage = "Tuổi phải từ 18 đến 65")]
        public int Age { get; set; }
    }
}

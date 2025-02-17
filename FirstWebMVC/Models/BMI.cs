using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng")]
        public double Weight { get; set; }  // Cân nặng (kg)

        [Required(ErrorMessage = "Vui lòng nhập chiều cao")]
        public double Height { get; set; }  // Chiều cao (m)
    }
}

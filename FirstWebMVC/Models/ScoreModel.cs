using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models
{
    public class ScoreModel
    {
        [Required(ErrorMessage = "Vui lòng nhập điểm A")]
        public double A { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm B")]
        public double B { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập điểm C")]
        public double C { get; set; }

        public double FinalScore { get; set; } // Điểm môn học theo công thức 0.6A + 0.3B + 0.1C
    }
}

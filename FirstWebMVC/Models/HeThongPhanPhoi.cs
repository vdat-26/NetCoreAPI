using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string? MaHTPP { get; set; }

        [Required]
        public string? TenHTPP { get; set; }
    }
}
